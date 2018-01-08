namespace SA45_Team10a_LibraryManagement
{
    partial class frmReport
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
            this.picBoxHome = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblLogOut = new System.Windows.Forms.Label();
            this.btnBookType = new System.Windows.Forms.Button();
            this.btnTransReport = new System.Windows.Forms.Button();
            this.btnMreport = new System.Windows.Forms.Button();
            this.btnBookReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHome)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxHome
            // 
            this.picBoxHome.Image = global::SA45_Team10a_LibraryManagement.Properties.Resources.PGPLibraryLogo;
            this.picBoxHome.Location = new System.Drawing.Point(13, 13);
            this.picBoxHome.Margin = new System.Windows.Forms.Padding(4);
            this.picBoxHome.Name = "picBoxHome";
            this.picBoxHome.Size = new System.Drawing.Size(254, 217);
            this.picBoxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxHome.TabIndex = 46;
            this.picBoxHome.TabStop = false;
            this.picBoxHome.Click += new System.EventHandler(this.picBoxHome_Click);
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(1218, 52);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(172, 32);
            this.lblUser.TabIndex = 45;
            this.lblUser.Text = "Librarian XX";
            this.lblUser.Click += new System.EventHandler(this.lblUser_Click);
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
            this.lblLogOut.TabIndex = 44;
            this.lblLogOut.Text = "Log Out";
            this.lblLogOut.Click += new System.EventHandler(this.lblLogOut_Click);
            // 
            // btnBookType
            // 
            this.btnBookType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBookType.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBookType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBookType.Location = new System.Drawing.Point(999, 577);
            this.btnBookType.Margin = new System.Windows.Forms.Padding(4);
            this.btnBookType.Name = "btnBookType";
            this.btnBookType.Size = new System.Drawing.Size(347, 259);
            this.btnBookType.TabIndex = 3;
            this.btnBookType.Text = "Book Type";
            this.btnBookType.UseVisualStyleBackColor = false;
            this.btnBookType.Click += new System.EventHandler(this.btnBookType_Click);
            // 
            // btnTransReport
            // 
            this.btnTransReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTransReport.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTransReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTransReport.Location = new System.Drawing.Point(999, 230);
            this.btnTransReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnTransReport.Name = "btnTransReport";
            this.btnTransReport.Size = new System.Drawing.Size(347, 259);
            this.btnTransReport.TabIndex = 2;
            this.btnTransReport.Text = "Transaction Report";
            this.btnTransReport.UseVisualStyleBackColor = false;
            this.btnTransReport.Click += new System.EventHandler(this.btnTransReport_Click);
            // 
            // btnMreport
            // 
            this.btnMreport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMreport.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnMreport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMreport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMreport.Location = new System.Drawing.Point(576, 230);
            this.btnMreport.Margin = new System.Windows.Forms.Padding(4);
            this.btnMreport.Name = "btnMreport";
            this.btnMreport.Size = new System.Drawing.Size(322, 259);
            this.btnMreport.TabIndex = 1;
            this.btnMreport.Text = "Management Report";
            this.btnMreport.UseVisualStyleBackColor = false;
            this.btnMreport.Click += new System.EventHandler(this.btnMreport_Click);
            // 
            // btnBookReport
            // 
            this.btnBookReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBookReport.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBookReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBookReport.Location = new System.Drawing.Point(576, 577);
            this.btnBookReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnBookReport.Name = "btnBookReport";
            this.btnBookReport.Size = new System.Drawing.Size(322, 259);
            this.btnBookReport.TabIndex = 0;
            this.btnBookReport.Text = "Booklisting Report";
            this.btnBookReport.UseVisualStyleBackColor = false;
            this.btnBookReport.Click += new System.EventHandler(this.btnBookReport_Click);
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1888, 992);
            this.Controls.Add(this.picBoxHome);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblLogOut);
            this.Controls.Add(this.btnBookType);
            this.Controls.Add(this.btnTransReport);
            this.Controls.Add(this.btnMreport);
            this.Controls.Add(this.btnBookReport);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReport";
            this.Text = "Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBookReport;
        private System.Windows.Forms.Button btnMreport;
        private System.Windows.Forms.Button btnTransReport;
        private System.Windows.Forms.Button btnBookType;
        private System.Windows.Forms.PictureBox picBoxHome;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblLogOut;
    }
}