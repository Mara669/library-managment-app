using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MyLibrary
{
    public partial class BookForm : Form
    {
        private DataRowView bookRow;
        private bool isEditMode = false;
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyLibrary4;Integrated Security=True;";

        // Constructor for adding a new book
        public BookForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        // Constructor for editing an existing book
        public BookForm(DataRowView row) : this()
        {
            bookRow = row;
            isEditMode = true;
            PopulateForm();
        }

        private void InitializeForm()
        {
            this.Text = isEditMode ? "Edit Book" : "Add New Book";
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.AcceptButton = btnSave;
            this.CancelButton = btnCancel;

            // Set default values
            numYear.Minimum = 1800;
            numYear.Maximum = DateTime.Now.Year;
            numYear.Value = DateTime.Now.Year;
            numCopies.Minimum = 1;
            numCopies.Value = 1;
        }

        private void PopulateForm()
        {
            txtTitle.Text = bookRow["Title"].ToString();
            txtAuthor.Text = bookRow["Author"].ToString();
            numYear.Value = Convert.ToInt32(bookRow["Year"]);
            numCopies.Value = Convert.ToInt32(bookRow["AvailableCopies"]);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            try
            {
                if (isEditMode)
                {
                    UpdateBook();
                }
                else
                {
                    AddNewBook();
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving book: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Title is required.", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitle.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAuthor.Text))
            {
                MessageBox.Show("Author is required.", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAuthor.Focus();
                return false;
            }

            if (numYear.Value < 1800 || numYear.Value > DateTime.Now.Year)
            {
                MessageBox.Show($"Year must be between 1800 and {DateTime.Now.Year}.", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numYear.Focus();
                return false;
            }

            if (numCopies.Value < 0)
            {
                MessageBox.Show("Available copies cannot be negative.", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numCopies.Focus();
                return false;
            }

            return true;
        }

        private void AddNewBook()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(
                "INSERT INTO Books (Title, Author, Year, AvailableCopies) " +
                "VALUES (@Title, @Author, @Year, @AvailableCopies)", connection))
            {
                command.Parameters.AddWithValue("@Title", txtTitle.Text.Trim());
                command.Parameters.AddWithValue("@Author", txtAuthor.Text.Trim());
                command.Parameters.AddWithValue("@Year", (int)numYear.Value);
                command.Parameters.AddWithValue("@AvailableCopies", (int)numCopies.Value);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void UpdateBook()
        {
            int bookId = (int)bookRow["BookID"];

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(
                "UPDATE Books SET Title = @Title, Author = @Author, " +
                "Year = @Year, AvailableCopies = @AvailableCopies " +
                "WHERE BookID = @BookID", connection))
            {
                command.Parameters.AddWithValue("@Title", txtTitle.Text.Trim());
                command.Parameters.AddWithValue("@Author", txtAuthor.Text.Trim());
                command.Parameters.AddWithValue("@Year", (int)numYear.Value);
                command.Parameters.AddWithValue("@AvailableCopies", (int)numCopies.Value);
                command.Parameters.AddWithValue("@BookID", bookId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BookForm_Load(object sender, EventArgs e)
        {

        }
    }
}