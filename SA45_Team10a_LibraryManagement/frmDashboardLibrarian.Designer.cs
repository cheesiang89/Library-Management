namespace SA45_Team10a_LibraryManagement
{
    partial class frmDashboardLibrarian
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUserDetails = new System.Windows.Forms.Label();
            this.lblLogOut = new System.Windows.Forms.Label();
            this.btnManageMember = new System.Windows.Forms.Button();
            this.btnManageBook = new System.Windows.Forms.Button();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.picBoxHome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHome)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserDetails
            // 
            this.lblUserDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserDetails.AutoSize = true;
            this.lblUserDetails.Location = new System.Drawing.Point(1218, 52);
            this.lblUserDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserDetails.Name = "lblUserDetails";
            this.lblUserDetails.Size = new System.Drawing.Size(353, 32);
            this.lblUserDetails.TabIndex = 51;
            this.lblUserDetails.Text = "UserCategory + UserName";
            // 
            // lblLogOut
            // 
            this.lblLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogOut.AutoSize = true;
            this.lblLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogOut.Location = new System.Drawing.Point(1636, 52);
            this.lblLogOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(116, 32);
            this.lblLogOut.TabIndex = 49;
            this.lblLogOut.Text = "Log Out";
            this.lblLogOut.Click += new System.EventHandler(this.lblLogOut_Click);
            // 
            // btnManageMember
            // 
            this.btnManageMember.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnManageMember.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnManageMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageMember.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnManageMember.Location = new System.Drawing.Point(428, 248);
            this.btnManageMember.Margin = new System.Windows.Forms.Padding(4);
            this.btnManageMember.Name = "btnManageMember";
            this.btnManageMember.Size = new System.Drawing.Size(333, 278);
            this.btnManageMember.TabIndex = 48;
            this.btnManageMember.Text = "Manage Member";
            this.btnManageMember.UseVisualStyleBackColor = false;
            this.btnManageMember.Click += new System.EventHandler(this.btnManageMember_Click);
            // 
            // btnManageBook
            // 
            this.btnManageBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnManageBook.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnManageBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnManageBook.Location = new System.Drawing.Point(1214, 248);
            this.btnManageBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnManageBook.Name = "btnManageBook";
            this.btnManageBook.Size = new System.Drawing.Size(379, 278);
            this.btnManageBook.TabIndex = 47;
            this.btnManageBook.Text = "Manage Book";
            this.btnManageBook.UseVisualStyleBackColor = false;
            this.btnManageBook.Click += new System.EventHandler(this.btnManageBook_Click);
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReturnBook.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnReturnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReturnBook.Location = new System.Drawing.Point(823, 248);
            this.btnReturnBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(329, 278);
            this.btnReturnBook.TabIndex = 46;
            this.btnReturnBook.Text = "Return Book";
            this.btnReturnBook.UseVisualStyleBackColor = false;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGenerateReport.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGenerateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenerateReport.Location = new System.Drawing.Point(823, 585);
            this.btnGenerateReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(329, 278);
            this.btnGenerateReport.TabIndex = 45;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchBook.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearchBook.Location = new System.Drawing.Point(428, 585);
            this.btnSearchBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(333, 278);
            this.btnSearchBook.TabIndex = 44;
            this.btnSearchBook.Text = "Search Book";
            this.btnSearchBook.UseVisualStyleBackColor = false;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // picBoxHome
            // 
            this.picBoxHome.Image = global::SA45_Team10a_LibraryManagement.Properties.Resources.PGPLibraryLogo;
            this.picBoxHome.Location = new System.Drawing.Point(13, 13);
            this.picBoxHome.Margin = new System.Windows.Forms.Padding(4);
            this.picBoxHome.Name = "picBoxHome";
            this.picBoxHome.Size = new System.Drawing.Size(254, 217);
            this.picBoxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxHome.TabIndex = 50;
            this.picBoxHome.TabStop = false;
            // 
            // frmDashboardLibrarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1888, 992);
            this.Controls.Add(this.lblUserDetails);
            this.Controls.Add(this.picBoxHome);
            this.Controls.Add(this.lblLogOut);
            this.Controls.Add(this.btnManageMember);
            this.Controls.Add(this.btnManageBook);
            this.Controls.Add(this.btnReturnBook);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.btnSearchBook);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmDashboardLibrarian";
            this.Text = "Dashboard (Librarian)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDashboardLibrarian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserDetails;
        private System.Windows.Forms.PictureBox picBoxHome;
        private System.Windows.Forms.Label lblLogOut;
        private System.Windows.Forms.Button btnManageMember;
        private System.Windows.Forms.Button btnManageBook;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Button btnSearchBook;
    }
}