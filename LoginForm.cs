using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MyLibrary
{
    public partial class LoginForm : Form
    {
        // Database connection string - update this with your actual connection string
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyLibrary4;Integrated Security=True;";




        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "MyLibrary - Login";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // Input validation
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter your username.", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your password.", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Parameterized query to prevent SQL injection
                    string query = "SELECT UserID, Username FROM Users WHERE Username = @Username AND Password = @Password";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                int userId = reader.GetInt32(0);
                                string loggedInUsername = reader.GetString(1);

                                // Login successful - open main form
                                MainForm mainForm = new MainForm(userId, loggedInUsername);
                                mainForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password.", "Login Failed",
                                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtPassword.SelectAll();
                                txtPassword.Focus();
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow login by pressing Enter key in password field
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin.PerformClick();
                e.Handled = true;
            }
        }
    }
}
