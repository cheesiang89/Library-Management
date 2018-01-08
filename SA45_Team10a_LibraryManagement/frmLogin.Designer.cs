namespace SA45_Team10a_LibraryManagement
{
    partial class frmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboBoxStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(484, 643);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 39);
            this.label1.TabIndex = 15;
            this.label1.Text = "Category:";
            // 
            // cboBoxStatus
            // 
            this.cboBoxStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboBoxStatus.BackColor = System.Drawing.SystemColors.Menu;
            this.cboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxStatus.FormattingEnabled = true;
            this.cboBoxStatus.Items.AddRange(new object[] {
            "Member",
            "Librarian"});
            this.cboBoxStatus.Location = new System.Drawing.Point(769, 644);
            this.cboBoxStatus.Margin = new System.Windows.Forms.Padding(6);
            this.cboBoxStatus.Name = "cboBoxStatus";
            this.cboBoxStatus.Size = new System.Drawing.Size(572, 39);
            this.cboBoxStatus.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(439, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1143, 63);
            this.label3.TabIndex = 13;
            this.label3.Text = "Welcome to PGP Library Management System";
            // 
            // chkBoxShowPassword
            // 
            this.chkBoxShowPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkBoxShowPassword.AutoSize = true;
            this.chkBoxShowPassword.Location = new System.Drawing.Point(1389, 526);
            this.chkBoxShowPassword.Margin = new System.Windows.Forms.Padding(6);
            this.chkBoxShowPassword.Name = "chkBoxShowPassword";
            this.chkBoxShowPassword.Size = new System.Drawing.Size(255, 36);
            this.chkBoxShowPassword.TabIndex = 12;
            this.chkBoxShowPassword.Text = "Show Password";
            this.chkBoxShowPassword.UseVisualStyleBackColor = true;
            this.chkBoxShowPassword.CheckedChanged += new System.EventHandler(this.chkBoxShowPassword_CheckedChanged);
            // 
            // btnNewUser
            // 
            this.btnNewUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNewUser.Location = new System.Drawing.Point(491, 811);
            this.btnNewUser.Margin = new System.Windows.Forms.Padding(6);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(171, 69);
            this.btnNewUser.TabIndex = 11;
            this.btnNewUser.Text = "New User?";
            this.btnNewUser.UseVisualStyleBackColor = true;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.Location = new System.Drawing.Point(1152, 811);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(6);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(189, 69);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxPassword.Location = new System.Drawing.Point(769, 526);
            this.txtBoxPassword.Margin = new System.Windows.Forms.Padding(6);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(572, 38);
            this.txtBoxPassword.TabIndex = 9;
            this.txtBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(484, 516);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(253, 78);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password: \r\n(case sensitive)";
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxUsername.Location = new System.Drawing.Point(769, 400);
            this.txtBoxUsername.Margin = new System.Windows.Forms.Padding(6);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(572, 38);
            this.txtBoxUsername.TabIndex = 7;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(484, 399);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(172, 39);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "Usename:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SA45_Team10a_LibraryManagement.Properties.Resources.PGPLibraryLogo;
            this.pictureBox1.Location = new System.Drawing.Point(15, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1888, 992);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboBoxStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkBoxShowPassword);
            this.Controls.Add(this.btnNewUser);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtBoxUsername);
            this.Controls.Add(this.lblUsername);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.CheckBox chkBoxShowPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboBoxStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}