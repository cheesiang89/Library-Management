namespace SA45_Team10a_LibraryManagement
{
    partial class frmProfile
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
            this.lblUserDetails = new System.Windows.Forms.Label();
            this.lblLogOut = new System.Windows.Forms.Label();
            this.dgvProfile = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfile)).BeginInit();
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
            this.picBoxHome.TabIndex = 44;
            this.picBoxHome.TabStop = false;
            this.picBoxHome.Click += new System.EventHandler(this.picBoxHome_Click);
            // 
            // lblUserDetails
            // 
            this.lblUserDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserDetails.AutoSize = true;
            this.lblUserDetails.Location = new System.Drawing.Point(1218, 52);
            this.lblUserDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserDetails.Name = "lblUserDetails";
            this.lblUserDetails.Size = new System.Drawing.Size(352, 32);
            this.lblUserDetails.TabIndex = 43;
            this.lblUserDetails.Text = "UserCategory+UserDetails";
            this.lblUserDetails.Click += new System.EventHandler(this.frmProfile_Load);
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
            this.lblLogOut.TabIndex = 42;
            this.lblLogOut.Text = "Log Out";
            this.lblLogOut.Click += new System.EventHandler(this.lblLogOut_Click);
            // 
            // dgvProfile
            // 
            this.dgvProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvProfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfile.Location = new System.Drawing.Point(238, 359);
            this.dgvProfile.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProfile.MultiSelect = false;
            this.dgvProfile.Name = "dgvProfile";
            this.dgvProfile.RowTemplate.Height = 40;
            this.dgvProfile.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProfile.Size = new System.Drawing.Size(1420, 333);
            this.dgvProfile.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(737, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 61);
            this.label4.TabIndex = 70;
            this.label4.Text = "Profile";
            // 
            // frmProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1888, 992);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picBoxHome);
            this.Controls.Add(this.lblUserDetails);
            this.Controls.Add(this.lblLogOut);
            this.Controls.Add(this.dgvProfile);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProfile";
            this.Text = "Profile";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxHome;
        private System.Windows.Forms.Label lblUserDetails;
        private System.Windows.Forms.Label lblLogOut;
        private System.Windows.Forms.DataGridView dgvProfile;
        private System.Windows.Forms.Label label4;
    }
}