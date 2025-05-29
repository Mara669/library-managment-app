using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MyLibrary
{
    public partial class MainForm : Form
    {
        private int currentUserId;
        private string currentUsername;
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyLibrary4;Integrated Security=True;";

        public MainForm(int userId, string username)
        {
            InitializeComponent();
            currentUserId = userId;
            currentUsername = username;
            InitializeUI();
            LoadData();
        }

        private void InitializeUI()
        {
            this.Text = $"MyLibrary - Welcome, {currentUsername}";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            this.FormClosing += MainForm_FormClosing;

            // Configure status bar
            tslLoggedIn.Text = $"User: {currentUsername}";
            tslDate.Text = DateTime.Now.ToShortDateString();

            // Configure tab control
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.ItemSize = new System.Drawing.Size(120, 30);
        }

        private void LoadData()
        {
            LoadBooks();
            LoadBorrowers();
            LoadIssuedBooks();
        }

        private void LoadBooks()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand("SELECT * FROM Books", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvBooks.DataSource = table;
                    dgvBooks.AutoResizeColumns();
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
                using (SqlCommand command = new SqlCommand("SELECT * FROM Borrowers", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvBorrowers.DataSource = table;
                    dgvBorrowers.AutoResizeColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading borrowers: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadIssuedBooks()
        {
            try
            {
                string query = @"SELECT i.IssueID, b.Title, br.Name, i.IssueDate, i.DueDate 
                               FROM IssuedBooks i
                               JOIN Books b ON i.BookID = b.BookID
                               JOIN Borrowers br ON i.BorrowerID = br.BorrowerID
                               WHERE i.Returned = 0";

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvIssuedBooks.DataSource = table;
                    dgvIssuedBooks.AutoResizeColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading issued books: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm();
            if (bookForm.ShowDialog() == DialogResult.OK)
            {
                LoadBooks();
            }
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book to edit.", "Information",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataRowView row = (DataRowView)dgvBooks.SelectedRows[0].DataBoundItem;
            BookForm bookForm = new BookForm(row);
            if (bookForm.ShowDialog() == DialogResult.OK)
            {
                LoadBooks();
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book to delete.", "Information",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this book?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int bookId = (int)dgvBooks.SelectedRows[0].Cells["BookID"].Value;

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    using (SqlCommand command = new SqlCommand("DELETE FROM Books WHERE BookID = @BookID", connection))
                    {
                        command.Parameters.AddWithValue("@BookID", bookId);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }

                    LoadBooks();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting book: {ex.Message}", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddBorrower_Click(object sender, EventArgs e)
        {
            BorrowerForm borrowerForm = new BorrowerForm();
            if (borrowerForm.ShowDialog() == DialogResult.OK)
            {
                LoadBorrowers();
            }
        }

        private void btnEditBorrower_Click(object sender, EventArgs e)
        {
            if (dgvBorrowers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a borrower to edit.", "Information",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataRowView row = (DataRowView)dgvBorrowers.SelectedRows[0].DataBoundItem;
            BorrowerForm borrowerForm = new BorrowerForm(row);
            if (borrowerForm.ShowDialog() == DialogResult.OK)
            {
                LoadBorrowers();
            }
        }

        private void btnDeleteBorrower_Click(object sender, EventArgs e)
        {
            if (dgvBorrowers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a borrower to delete.", "Information",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this borrower?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int borrowerId = (int)dgvBorrowers.SelectedRows[0].Cells["BorrowerID"].Value;

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    using (SqlCommand command = new SqlCommand("DELETE FROM Borrowers WHERE BorrowerID = @BorrowerID", connection))
                    {
                        command.Parameters.AddWithValue("@BorrowerID", borrowerId);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }

                    LoadBorrowers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting borrower: {ex.Message}", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            IssueBookForm issueForm = new IssueBookForm();
            if (issueForm.ShowDialog() == DialogResult.OK)
            {
                LoadBooks();
                LoadIssuedBooks();
            }
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            ReturnBookForm returnForm = new ReturnBookForm();
            if (returnForm.ShowDialog() == DialogResult.OK)
            {
                LoadBooks();
                LoadIssuedBooks();
            }
        }

        private void btnOverdueBooks_Click(object sender, EventArgs e)
        {
            OverdueBooksForm overdueForm = new OverdueBooksForm();
            overdueForm.ShowDialog();
        }

        private void btnFilterBooks_Click(object sender, EventArgs e)
        {
            try
            {
                string authorFilter = txtAuthorFilter.Text.Trim();
                string yearFilter = txtYearFilter.Text.Trim();

                string filter = "";
                if (!string.IsNullOrEmpty(authorFilter))
                {
                    filter += $"Author LIKE '%{authorFilter}%'";
                }

                if (!string.IsNullOrEmpty(yearFilter))
                {
                    if (!string.IsNullOrEmpty(filter)) filter += " AND ";
                    filter += $"Year = {yearFilter}";
                }

                ((DataTable)dgvBooks.DataSource).DefaultView.RowFilter = filter;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error applying filter: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            txtAuthorFilter.Clear();
            txtYearFilter.Clear();
            ((DataTable)dgvBooks.DataSource).DefaultView.RowFilter = "";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirm Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabPageBooks)
            {
                LoadBooks();
            }
            else if (tabControl.SelectedTab == tabPageBorrowers)
            {
                LoadBorrowers();
            }
            else if (tabControl.SelectedTab == tabPageTransactions)
            {
                LoadIssuedBooks();
            }
        }
    }
}