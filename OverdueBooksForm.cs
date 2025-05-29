using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MyLibrary
{
    public partial class OverdueBooksForm : Form
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyLibrary4;Integrated Security=True;";


        public OverdueBooksForm()
        {
            InitializeComponent();
            InitializeForm();
            LoadOverdueBooks();
        }

        private void InitializeForm()
        {
            this.Text = "Overdue Books";
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.AcceptButton = btnClose;
        }

        private void LoadOverdueBooks()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(
                    @"SELECT b.Title, br.Name, br.Email, br.Phone, 
                             i.IssueDate, i.DueDate, 
                             DATEDIFF(day, i.DueDate, GETDATE()) AS DaysOverdue
                      FROM IssuedBooks i
                      JOIN Books b ON i.BookID = b.BookID
                      JOIN Borrowers br ON i.BorrowerID = br.BorrowerID
                      WHERE i.Returned = 0 AND i.DueDate < GETDATE()
                      ORDER BY DaysOverdue DESC", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvOverdueBooks.DataSource = table;
                    dgvOverdueBooks.AutoResizeColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading overdue books: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}