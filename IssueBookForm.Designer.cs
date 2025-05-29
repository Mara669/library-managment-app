namespace MyLibrary
{
    partial class IssueBookForm
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
            this.lblBook = new System.Windows.Forms.Label();
            this.cmbBooks = new System.Windows.Forms.ComboBox();
            this.lblBorrower = new System.Windows.Forms.Label();
            this.cmbBorrowers = new System.Windows.Forms.ComboBox();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblBook
            this.lblBook.AutoSize = true;
            this.lblBook.Location = new System.Drawing.Point(20, 20);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(35, 13);
            this.lblBook.TabIndex = 0;
            this.lblBook.Text = "Book:";

            // cmbBooks
            this.cmbBooks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBooks.FormattingEnabled = true;
            this.cmbBooks.Location = new System.Drawing.Point(100, 17);
            this.cmbBooks.Name = "cmbBooks";
            this.cmbBooks.Size = new System.Drawing.Size(200, 21);
            this.cmbBooks.TabIndex = 1;

            // lblBorrower
            this.lblBorrower.AutoSize = true;
            this.lblBorrower.Location = new System.Drawing.Point(20, 50);
            this.lblBorrower.Name = "lblBorrower";
            this.lblBorrower.Size = new System.Drawing.Size(53, 13);
            this.lblBorrower.TabIndex = 2;
            this.lblBorrower.Text = "Borrower:";

            // cmbBorrowers
            this.cmbBorrowers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBorrowers.FormattingEnabled = true;
            this.cmbBorrowers.Location = new System.Drawing.Point(100, 47);
            this.cmbBorrowers.Name = "cmbBorrowers";
            this.cmbBorrowers.Size = new System.Drawing.Size(200, 21);
            this.cmbBorrowers.TabIndex = 3;

            // lblIssueDate
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Location = new System.Drawing.Point(20, 80);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(61, 13);
            this.lblIssueDate.TabIndex = 4;
            this.lblIssueDate.Text = "Issue Date:";

            // dtpIssueDate
            this.dtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIssueDate.Location = new System.Drawing.Point(100, 77);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(100, 20);
            this.dtpIssueDate.TabIndex = 5;

            // lblDueDate
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(20, 110);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(56, 13);
            this.lblDueDate.TabIndex = 6;
            this.lblDueDate.Text = "Due Date:";

            // dtpDueDate
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDate.Location = new System.Drawing.Point(100, 107);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(100, 20);
            this.dtpDueDate.TabIndex = 7;

            // btnIssue
            this.btnIssue.Location = new System.Drawing.Point(144, 150);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(75, 23);
            this.btnIssue.TabIndex = 8;
            this.btnIssue.Text = "Issue";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);

            // btnCancel
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(225, 150);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // IssueBookForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 191);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.dtpIssueDate);
            this.Controls.Add(this.lblIssueDate);
            this.Controls.Add(this.cmbBorrowers);
            this.Controls.Add(this.lblBorrower);
            this.Controls.Add(this.cmbBooks);
            this.Controls.Add(this.lblBook);
            this.Name = "IssueBookForm";
            this.Text = "Issue Book";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.ComboBox cmbBooks;
        private System.Windows.Forms.Label lblBorrower;
        private System.Windows.Forms.ComboBox cmbBorrowers;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnCancel;
    }
}