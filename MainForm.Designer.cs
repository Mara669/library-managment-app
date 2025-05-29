namespace MyLibrary
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageBooks = new System.Windows.Forms.TabPage();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.panelBookButtons = new System.Windows.Forms.Panel();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.panelBookFilter = new System.Windows.Forms.Panel();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.btnFilterBooks = new System.Windows.Forms.Button();
            this.txtYearFilter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAuthorFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageBorrowers = new System.Windows.Forms.TabPage();
            this.dgvBorrowers = new System.Windows.Forms.DataGridView();
            this.panelBorrowerButtons = new System.Windows.Forms.Panel();
            this.btnAddBorrower = new System.Windows.Forms.Button();
            this.btnEditBorrower = new System.Windows.Forms.Button();
            this.btnDeleteBorrower = new System.Windows.Forms.Button();
            this.tabPageTransactions = new System.Windows.Forms.TabPage();
            this.dgvIssuedBooks = new System.Windows.Forms.DataGridView();
            this.panelTransactionButtons = new System.Windows.Forms.Panel();
            this.btnIssueBook = new System.Windows.Forms.Button();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.btnOverdueBooks = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tslLoggedIn = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl.SuspendLayout();
            this.tabPageBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.panelBookButtons.SuspendLayout();
            this.panelBookFilter.SuspendLayout();
            this.tabPageBorrowers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowers)).BeginInit();
            this.panelBorrowerButtons.SuspendLayout();
            this.tabPageTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssuedBooks)).BeginInit();
            this.panelTransactionButtons.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageBooks);
            this.tabControl.Controls.Add(this.tabPageBorrowers);
            this.tabControl.Controls.Add(this.tabPageTransactions);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 402);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPageBooks
            // 
            this.tabPageBooks.Controls.Add(this.dgvBooks);
            this.tabPageBooks.Controls.Add(this.panelBookButtons);
            this.tabPageBooks.Controls.Add(this.panelBookFilter);
            this.tabPageBooks.Location = new System.Drawing.Point(4, 22);
            this.tabPageBooks.Name = "tabPageBooks";
            this.tabPageBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBooks.Size = new System.Drawing.Size(792, 376);
            this.tabPageBooks.TabIndex = 0;
            this.tabPageBooks.Text = "Books Management";
            this.tabPageBooks.UseVisualStyleBackColor = true;
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBooks.Location = new System.Drawing.Point(3, 55);
            this.dgvBooks.MultiSelect = false;
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(786, 291);
            this.dgvBooks.TabIndex = 0;
            // 
            // panelBookButtons
            // 
            this.panelBookButtons.Controls.Add(this.btnAddBook);
            this.panelBookButtons.Controls.Add(this.btnEditBook);
            this.panelBookButtons.Controls.Add(this.btnDeleteBook);
            this.panelBookButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBookButtons.Location = new System.Drawing.Point(3, 346);
            this.panelBookButtons.Name = "panelBookButtons";
            this.panelBookButtons.Size = new System.Drawing.Size(786, 27);
            this.panelBookButtons.TabIndex = 1;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(3, 3);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(75, 23);
            this.btnAddBook.TabIndex = 0;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnEditBook
            // 
            this.btnEditBook.Location = new System.Drawing.Point(84, 3);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(75, 23);
            this.btnEditBook.TabIndex = 1;
            this.btnEditBook.Text = "Edit Book";
            this.btnEditBook.UseVisualStyleBackColor = true;
            this.btnEditBook.Click += new System.EventHandler(this.btnEditBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(165, 3);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteBook.TabIndex = 2;
            this.btnDeleteBook.Text = "Delete Book";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // panelBookFilter
            // 
            this.panelBookFilter.Controls.Add(this.btnClearFilter);
            this.panelBookFilter.Controls.Add(this.btnFilterBooks);
            this.panelBookFilter.Controls.Add(this.txtYearFilter);
            this.panelBookFilter.Controls.Add(this.label2);
            this.panelBookFilter.Controls.Add(this.txtAuthorFilter);
            this.panelBookFilter.Controls.Add(this.label1);
            this.panelBookFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBookFilter.Location = new System.Drawing.Point(3, 3);
            this.panelBookFilter.Name = "panelBookFilter";
            this.panelBookFilter.Size = new System.Drawing.Size(786, 52);
            this.panelBookFilter.TabIndex = 2;
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Location = new System.Drawing.Point(328, 28);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(75, 23);
            this.btnClearFilter.TabIndex = 5;
            this.btnClearFilter.Text = "Clear Filter";
            this.btnClearFilter.UseVisualStyleBackColor = true;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // btnFilterBooks
            // 
            this.btnFilterBooks.Location = new System.Drawing.Point(247, 28);
            this.btnFilterBooks.Name = "btnFilterBooks";
            this.btnFilterBooks.Size = new System.Drawing.Size(75, 23);
            this.btnFilterBooks.TabIndex = 4;
            this.btnFilterBooks.Text = "Filter";
            this.btnFilterBooks.UseVisualStyleBackColor = true;
            this.btnFilterBooks.Click += new System.EventHandler(this.btnFilterBooks_Click);
            // 
            // txtYearFilter
            // 
            this.txtYearFilter.Location = new System.Drawing.Point(247, 3);
            this.txtYearFilter.Name = "txtYearFilter";
            this.txtYearFilter.Size = new System.Drawing.Size(100, 20);
            this.txtYearFilter.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Year:";
            // 
            // txtAuthorFilter
            // 
            this.txtAuthorFilter.Location = new System.Drawing.Point(51, 3);
            this.txtAuthorFilter.Name = "txtAuthorFilter";
            this.txtAuthorFilter.Size = new System.Drawing.Size(150, 20);
            this.txtAuthorFilter.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Author:";
            // 
            // tabPageBorrowers
            // 
            this.tabPageBorrowers.Controls.Add(this.dgvBorrowers);
            this.tabPageBorrowers.Controls.Add(this.panelBorrowerButtons);
            this.tabPageBorrowers.Location = new System.Drawing.Point(4, 22);
            this.tabPageBorrowers.Name = "tabPageBorrowers";
            this.tabPageBorrowers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBorrowers.Size = new System.Drawing.Size(792, 376);
            this.tabPageBorrowers.TabIndex = 1;
            this.tabPageBorrowers.Text = "Borrowers Management";
            this.tabPageBorrowers.UseVisualStyleBackColor = true;
            // 
            // dgvBorrowers
            // 
            this.dgvBorrowers.AllowUserToAddRows = false;
            this.dgvBorrowers.AllowUserToDeleteRows = false;
            this.dgvBorrowers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBorrowers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBorrowers.Location = new System.Drawing.Point(3, 3);
            this.dgvBorrowers.MultiSelect = false;
            this.dgvBorrowers.Name = "dgvBorrowers";
            this.dgvBorrowers.ReadOnly = true;
            this.dgvBorrowers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorrowers.Size = new System.Drawing.Size(786, 346);
            this.dgvBorrowers.TabIndex = 0;
            // 
            // panelBorrowerButtons
            // 
            this.panelBorrowerButtons.Controls.Add(this.btnAddBorrower);
            this.panelBorrowerButtons.Controls.Add(this.btnEditBorrower);
            this.panelBorrowerButtons.Controls.Add(this.btnDeleteBorrower);
            this.panelBorrowerButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBorrowerButtons.Location = new System.Drawing.Point(3, 349);
            this.panelBorrowerButtons.Name = "panelBorrowerButtons";
            this.panelBorrowerButtons.Size = new System.Drawing.Size(786, 24);
            this.panelBorrowerButtons.TabIndex = 1;
            // 
            // btnAddBorrower
            // 
            this.btnAddBorrower.Location = new System.Drawing.Point(3, 1);
            this.btnAddBorrower.Name = "btnAddBorrower";
            this.btnAddBorrower.Size = new System.Drawing.Size(90, 23);
            this.btnAddBorrower.TabIndex = 0;
            this.btnAddBorrower.Text = "Add Borrower";
            this.btnAddBorrower.UseVisualStyleBackColor = true;
            this.btnAddBorrower.Click += new System.EventHandler(this.btnAddBorrower_Click);
            // 
            // btnEditBorrower
            // 
            this.btnEditBorrower.Location = new System.Drawing.Point(99, 1);
            this.btnEditBorrower.Name = "btnEditBorrower";
            this.btnEditBorrower.Size = new System.Drawing.Size(90, 23);
            this.btnEditBorrower.TabIndex = 1;
            this.btnEditBorrower.Text = "Edit Borrower";
            this.btnEditBorrower.UseVisualStyleBackColor = true;
            this.btnEditBorrower.Click += new System.EventHandler(this.btnEditBorrower_Click);
            // 
            // btnDeleteBorrower
            // 
            this.btnDeleteBorrower.Location = new System.Drawing.Point(195, 1);
            this.btnDeleteBorrower.Name = "btnDeleteBorrower";
            this.btnDeleteBorrower.Size = new System.Drawing.Size(90, 23);
            this.btnDeleteBorrower.TabIndex = 2;
            this.btnDeleteBorrower.Text = "Delete Borrower";
            this.btnDeleteBorrower.UseVisualStyleBackColor = true;
            this.btnDeleteBorrower.Click += new System.EventHandler(this.btnDeleteBorrower_Click);
            // 
            // tabPageTransactions
            // 
            this.tabPageTransactions.Controls.Add(this.dgvIssuedBooks);
            this.tabPageTransactions.Controls.Add(this.panelTransactionButtons);
            this.tabPageTransactions.Location = new System.Drawing.Point(4, 22);
            this.tabPageTransactions.Name = "tabPageTransactions";
            this.tabPageTransactions.Size = new System.Drawing.Size(792, 376);
            this.tabPageTransactions.TabIndex = 2;
            this.tabPageTransactions.Text = "Book Transactions";
            this.tabPageTransactions.UseVisualStyleBackColor = true;
            // 
            // dgvIssuedBooks
            // 
            this.dgvIssuedBooks.AllowUserToAddRows = false;
            this.dgvIssuedBooks.AllowUserToDeleteRows = false;
            this.dgvIssuedBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIssuedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIssuedBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIssuedBooks.Location = new System.Drawing.Point(0, 0);
            this.dgvIssuedBooks.MultiSelect = false;
            this.dgvIssuedBooks.Name = "dgvIssuedBooks";
            this.dgvIssuedBooks.ReadOnly = true;
            this.dgvIssuedBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIssuedBooks.Size = new System.Drawing.Size(792, 349);
            this.dgvIssuedBooks.TabIndex = 0;
            // 
            // panelTransactionButtons
            // 
            this.panelTransactionButtons.Controls.Add(this.btnIssueBook);
            this.panelTransactionButtons.Controls.Add(this.btnReturnBook);
            this.panelTransactionButtons.Controls.Add(this.btnOverdueBooks);
            this.panelTransactionButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTransactionButtons.Location = new System.Drawing.Point(0, 349);
            this.panelTransactionButtons.Name = "panelTransactionButtons";
            this.panelTransactionButtons.Size = new System.Drawing.Size(792, 27);
            this.panelTransactionButtons.TabIndex = 1;
            // 
            // btnIssueBook
            // 
            this.btnIssueBook.Location = new System.Drawing.Point(3, 3);
            this.btnIssueBook.Name = "btnIssueBook";
            this.btnIssueBook.Size = new System.Drawing.Size(75, 23);
            this.btnIssueBook.TabIndex = 0;
            this.btnIssueBook.Text = "Issue Book";
            this.btnIssueBook.UseVisualStyleBackColor = true;
            this.btnIssueBook.Click += new System.EventHandler(this.btnIssueBook_Click);
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Location = new System.Drawing.Point(84, 3);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(75, 23);
            this.btnReturnBook.TabIndex = 1;
            this.btnReturnBook.Text = "Return Book";
            this.btnReturnBook.UseVisualStyleBackColor = true;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // btnOverdueBooks
            // 
            this.btnOverdueBooks.Location = new System.Drawing.Point(165, 3);
            this.btnOverdueBooks.Name = "btnOverdueBooks";
            this.btnOverdueBooks.Size = new System.Drawing.Size(100, 23);
            this.btnOverdueBooks.TabIndex = 2;
            this.btnOverdueBooks.Text = "Overdue Books";
            this.btnOverdueBooks.UseVisualStyleBackColor = true;
            this.btnOverdueBooks.Click += new System.EventHandler(this.btnOverdueBooks_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslLoggedIn,
            this.tslDate});
            this.statusStrip.Location = new System.Drawing.Point(0, 426);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 24);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tslLoggedIn
            // 
            this.tslLoggedIn.Name = "tslLoggedIn";
            this.tslLoggedIn.Size = new System.Drawing.Size(118, 19);
            this.tslLoggedIn.Text = "toolStripStatusLabel1";
            // 
            // tslDate
            // 
            this.tslDate.Name = "tslDate";
            this.tslDate.Size = new System.Drawing.Size(118, 19);
            this.tslDate.Text = "toolStripStatusLabel2";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyLibrary - Library Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tabControl.ResumeLayout(false);
            this.tabPageBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.panelBookButtons.ResumeLayout(false);
            this.panelBookFilter.ResumeLayout(false);
            this.panelBookFilter.PerformLayout();
            this.tabPageBorrowers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowers)).EndInit();
            this.panelBorrowerButtons.ResumeLayout(false);
            this.tabPageTransactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssuedBooks)).EndInit();
            this.panelTransactionButtons.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageBooks;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Panel panelBookButtons;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnEditBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.TabPage tabPageBorrowers;
        private System.Windows.Forms.DataGridView dgvBorrowers;
        private System.Windows.Forms.Panel panelBorrowerButtons;
        private System.Windows.Forms.Button btnAddBorrower;
        private System.Windows.Forms.Button btnEditBorrower;
        private System.Windows.Forms.Button btnDeleteBorrower;
        private System.Windows.Forms.TabPage tabPageTransactions;
        private System.Windows.Forms.DataGridView dgvIssuedBooks;
        private System.Windows.Forms.Panel panelTransactionButtons;
        private System.Windows.Forms.Button btnIssueBook;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tslLoggedIn;
        private System.Windows.Forms.ToolStripStatusLabel tslDate;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panelBookFilter;
        private System.Windows.Forms.TextBox txtAuthorFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.Button btnFilterBooks;
        private System.Windows.Forms.TextBox txtYearFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOverdueBooks;
    }
}