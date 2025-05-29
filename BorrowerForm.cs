using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MyLibrary
{
    public partial class BorrowerForm : Form
    {
        private DataRowView borrowerRow;
        private bool isEditMode = false;
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyLibrary4;Integrated Security=True;";


        // Constructor for adding new borrower
        public BorrowerForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        // Constructor for editing existing borrower
        public BorrowerForm(DataRowView row) : this()
        {
            borrowerRow = row;
            isEditMode = true;
            PopulateForm();
        }

        private void InitializeForm()
        {
            this.Text = isEditMode ? "Edit Borrower" : "Add New Borrower";
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.AcceptButton = btnSave;
            this.CancelButton = btnCancel;
        }

        private void PopulateForm()
        {
            txtName.Text = borrowerRow["Name"].ToString();
            txtEmail.Text = borrowerRow["Email"].ToString();
            txtPhone.Text = borrowerRow["Phone"].ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            try
            {
                if (isEditMode)
                    UpdateBorrower();
                else
                    AddNewBorrower();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving borrower: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name is required.", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Phone number is required.", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase);
            }
            catch
            {
                return false;
            }
        }

        private void AddNewBorrower()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(
                "INSERT INTO Borrowers (Name, Email, Phone) VALUES (@Name, @Email, @Phone)", connection))
            {
                command.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                command.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                command.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void UpdateBorrower()
        {
            int borrowerId = (int)borrowerRow["BorrowerID"];

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(
                "UPDATE Borrowers SET Name = @Name, Email = @Email, Phone = @Phone " +
                "WHERE BorrowerID = @BorrowerID", connection))
            {
                command.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                command.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                command.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
                command.Parameters.AddWithValue("@BorrowerID", borrowerId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}