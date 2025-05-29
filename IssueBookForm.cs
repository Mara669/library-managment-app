using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MyLibrary
{
    public partial class IssueBookForm : Form
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyLibrary4;Integrated Security=True;";


        public IssueBookForm()
        {
            InitializeComponent();
            InitializeForm();
            LoadBooks();
            LoadBorrowers();
        }

        private void InitializeForm()
        {
            this.Text = "Issue Book";
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.AcceptButton = btnIssue;
            this.CancelButton = btnCancel;

            dtpIssueDate.Value = DateTime.Today;
            dtpDueDate.Value = DateTime.Today.AddDays(14);
        }

        private void LoadBooks()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(
                    "SELECT BookID, Title FROM Books WHERE AvailableCopies > 0", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    cmbBooks.DataSource = table;
                    cmbBooks.DisplayMember = "Title";
                    cmbBooks.ValueMember = "BookID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading books: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBorrowers()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(
                    "SELECT BorrowerID, Name FROM Borrowers", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    cmbBorrowers.DataSource = table;
                    cmbBorrowers.DisplayMember = "Name";
                    cmbBorrowers.ValueMember = "BorrowerID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading borrowers: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            try
            {
                int bookId = (int)cmbBooks.SelectedValue;
                int borrowerId = (int)cmbBorrowers.SelectedValue;
                DateTime issueDate = dtpIssueDate.Value;
                DateTime dueDate = dtpDueDate.Value;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Insert issued book record
                    using (SqlCommand command = new SqlCommand(
                        "INSERT INTO IssuedBooks (BookID, BorrowerID, IssueDate, DueDate) " +
                        "VALUES (@BookID, @BorrowerID, @IssueDate, @DueDate)", connection))
                    {
                        command.Parameters.AddWithValue("@BookID", bookId);
                        command.Parameters.AddWithValue("@BorrowerID", borrowerId);
                        command.Parameters.AddWithValue("@IssueDate", issueDate);
                        command.Parameters.AddWithValue("@DueDate", dueDate);
                        command.ExecuteNonQuery();
                    }

                    // Decrement available copies
                    using (SqlCommand command = new SqlCommand(
                        "UPDATE Books SET AvailableCopies = AvailableCopies - 1 " +
                        "WHERE BookID = @BookID", connection))
                    {
                        command.Parameters.AddWithValue("@BookID", bookId);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Book issued successfully!", "Success",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error issuing book: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (cmbBooks.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a book.", "Validation Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbBooks.Focus();
                return false;
            }

            if (cmbBorrowers.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a borrower.", "Validation Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbBorrowers.Focus();
                return false;
            }

            if (dtpDueDate.Value < dtpIssueDate.Value)
            {
                MessageBox.Show("Due date cannot be before issue date.", "Validation Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDueDate.Focus();
                return false;
            }

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}