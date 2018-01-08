namespace SA45_Team10a_LibraryManagement
{
    partial class frmDashboardMember
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
            this.btnBorrowBook = new System.Windows.Forms.Button();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.lblLogOut = new System.Windows.Forms.Label();
            this.lblUserDetails = new System.Windows.Forms.Label();
            this.picBoxHome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHome)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBorrowBook
            // 
            this.btnBorrowBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBorrowBook.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBorrowBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrowBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBorrowBook.Location = new System.Drawing.Point(516, 351);
            this.btnBorrowBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrowBook.Name = "btnBorrowBook";
            this.btnBorrowBook.Size = new System.Drawing.Size(370, 331);
            this.btnBorrowBook.TabIndex = 0;
            this.btnBorrowBook.Text = "Borrow Book";
            this.btnBorrowBook.UseVisualStyleBackColor = false;
            this.btnBorrowBook.Click += new System.EventHandler(this.btnBorrowBook_Click);
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchBook.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearchBook.Location = new System.Drawing.Point(1030, 351);
            this.btnSearchBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(370, 331);
            this.btnSearchBook.TabIndex = 1;
            this.btnSearchBook.Text = "Search Book";
            this.btnSearchBook.UseVisualStyleBackColor = false;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
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
            this.lblLogOut.TabIndex = 7;
            this.lblLogOut.Text = "Log Out";
            this.lblLogOut.Click += new System.EventHandler(this.lblLogOut_Click);
            // 
            // lblUserDetails
            // 
            this.lblUserDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserDetails.AutoSize = true;
            this.lblUserDetails.Location = new System.Drawing.Point(1218, 52);
            this.lblUserDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserDetails.Name = "lblUserDetails";
            this.lblUserDetails.Size = new System.Drawing.Size(290, 32);
            this.lblUserDetails.TabIndex = 42;
            this.lblUserDetails.Text = "Category + Username";
            this.lblUserDetails.Click += new System.EventHandler(this.lblUser_Click);
            // 
            // picBoxHome
            // 
            this.picBoxHome.Image = global::SA45_Team10a_LibraryManagement.Properties.Resources.PGPLibraryLogo;
            this.picBoxHome.Location = new System.Drawing.Point(13, 13);
            this.picBoxHome.Margin = new System.Windows.Forms.Padding(4);
            this.picBoxHome.Name = "picBoxHome";
            this.picBoxHome.Size = new System.Drawing.Size(254, 217);
            this.picBoxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxHome.TabIndex = 41;
            this.picBoxHome.TabStop = false;
            // 
            // frmDashboardMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1888, 992);
            this.Controls.Add(this.lblUserDetails);
            this.Controls.Add(this.picBoxHome);
            this.Controls.Add(this.lblLogOut);
            this.Controls.Add(this.btnSearchBook);
            this.Controls.Add(this.btnBorrowBook);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDashboardMember";
            this.Text = "Dashboard (Member)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBorrowBook;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.Label lblLogOut;
        private System.Windows.Forms.PictureBox picBoxHome;
        private System.Windows.Forms.Label lblUserDetails;
    }
}