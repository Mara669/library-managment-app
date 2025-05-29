namespace MyLibrary
{
    partial class OverdueBooksForm
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
            this.dgvOverdueBooks = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverdueBooks)).BeginInit();
            this.SuspendLayout();

            // dgvOverdueBooks
            this.dgvOverdueBooks.AllowUserToAddRows = false;
            this.dgvOverdueBooks.AllowUserToDeleteRows = false;
            this.dgvOverdueBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOverdueBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvOverdueBooks.Location = new System.Drawing.Point(0, 0);
            this.dgvOverdueBooks.Name = "dgvOverdueBooks";
            this.dgvOverdueBooks.ReadOnly = true;
            this.dgvOverdueBooks.Size = new System.Drawing.Size(684, 250);
            this.dgvOverdueBooks.TabIndex = 0;

            // btnClose
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(597, 260);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // OverdueBooksForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 295);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvOverdueBooks);
            this.Name = "OverdueBooksForm";
            this.Text = "Overdue Books";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverdueBooks)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvOverdueBooks;
        private System.Windows.Forms.Button btnClose;
    }
}