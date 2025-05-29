using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MyLibrary
{
    public partial class ReturnBookForm : Form
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyLibrary4;Integrated Security=True;";

        public ReturnBookForm()
        {
            InitializeComponent();
            InitializeForm();
            LoadIssuedBooks();
        }

        private void InitializeForm()
        {
            this.Text = "Return Book";
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.AcceptButton = btnReturn;
            this.CancelButton = btnCancel;
        }

        private void LoadIssuedBooks()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(
                    @"SELECT i.IssueID, b.Title, br.Name, i.IssueDate, i.DueDate 
                      FROM IssuedBooks i
                      JOIN Books b ON i.BookID = b.BookID
                      JOIN Borrowers br ON i.BorrowerID = br.BorrowerID
                      WHERE i.Returned = 0", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvIssuedBooks.DataSource = table;
                    dgvIssuedBooks.AutoResizeColumns();
                    dgvIssuedBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading issued books: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (dgvIssuedBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book to return.", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to mark this book as returned?",
                "Confirm Return", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int issueId = (int)dgvIssuedBooks.SelectedRows[0].Cells["IssueID"].Value;
                    int bookId = GetBookIdFromIssue(issueId);

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Mark book as returned
                        using (SqlCommand command = new SqlCommand(
                            "UPDATE IssuedBooks SET Returned = 1 WHERE IssueID = @IssueID", connection))
                        {
                            command.Parameters.AddWithValue("@IssueID", issueId);
                            command.ExecuteNonQuery();
                        }

                        // Increment available copies
                        using (SqlCommand command = new SqlCommand(
                            "UPDATE Books SET AvailableCopies = AvailableCopies + 1 WHERE BookID = @BookID", connection))
                        {
                            command.Parameters.AddWithValue("@BookID", bookId);
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Book returned successfully!", "Success",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadIssuedBooks();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error returning book: {ex.Message}", "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private int GetBookIdFromIssue(int issueId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(
                "SELECT BookID FROM IssuedBooks WHERE IssueID = @IssueID", connection))
            {
                command.Parameters.AddWithValue("@IssueID", issueId);
                connection.Open();
                return (int)command.ExecuteScalar();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}