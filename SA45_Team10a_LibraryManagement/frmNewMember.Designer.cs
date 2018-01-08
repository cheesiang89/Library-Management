namespace SA45_Team10a_LibraryManagement
{
    partial class frmNewMember
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxPasswordCheck = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblMemberRegistration = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.chkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(473, 689);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 39);
            this.label3.TabIndex = 64;
            this.label3.Text = "Retype password";
            // 
            // txtBoxPasswordCheck
            // 
            this.txtBoxPasswordCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxPasswordCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPasswordCheck.Location = new System.Drawing.Point(852, 689);
            this.txtBoxPasswordCheck.Margin = new System.Windows.Forms.Padding(6);
            this.txtBoxPasswordCheck.Name = "txtBoxPasswordCheck";
            this.txtBoxPasswordCheck.Size = new System.Drawing.Size(518, 53);
            this.txtBoxPasswordCheck.TabIndex = 63;
            this.txtBoxPasswordCheck.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPasswordCheck_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(473, 390);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 78);
            this.label1.TabIndex = 62;
            this.label1.Text = "Usename:\r\n(NOT Case sensitive)";
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPassword.Location = new System.Drawing.Point(852, 525);
            this.txtBoxPassword.Margin = new System.Windows.Forms.Padding(6);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(518, 53);
            this.txtBoxPassword.TabIndex = 60;
            this.txtBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(473, 531);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 39);
            this.label2.TabIndex = 59;
            this.label2.Text = "Password ";
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUsername.Location = new System.Drawing.Point(852, 402);
            this.txtBoxUsername.Margin = new System.Windows.Forms.Padding(6);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(518, 53);
            this.txtBoxUsername.TabIndex = 58;
            this.txtBoxUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxUsername_KeyPress);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Location = new System.Drawing.Point(1162, 814);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(132, 68);
            this.btnCancel.TabIndex = 57;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNext.Location = new System.Drawing.Point(559, 814);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(132, 70);
            this.btnNext.TabIndex = 44;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblMemberRegistration
            // 
            this.lblMemberRegistration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMemberRegistration.AutoSize = true;
            this.lblMemberRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberRegistration.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMemberRegistration.Location = new System.Drawing.Point(737, 39);
            this.lblMemberRegistration.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMemberRegistration.Name = "lblMemberRegistration";
            this.lblMemberRegistration.Size = new System.Drawing.Size(653, 78);
            this.lblMemberRegistration.TabIndex = 65;
            this.lblMemberRegistration.Text = "Member Registration: \r\nStep 1 - Choose Username and Password";
            this.lblMemberRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInstruction
            // 
            this.lblInstruction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.Location = new System.Drawing.Point(718, 597);
            this.lblInstruction.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(761, 32);
            this.lblInstruction.TabIndex = 66;
            this.lblInstruction.Text = "*Password is case-sensitive and min. length of 6 characters";
            // 
            // chkBoxShowPassword
            // 
            this.chkBoxShowPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkBoxShowPassword.AutoSize = true;
            this.chkBoxShowPassword.Location = new System.Drawing.Point(1399, 534);
            this.chkBoxShowPassword.Margin = new System.Windows.Forms.Padding(6);
            this.chkBoxShowPassword.Name = "chkBoxShowPassword";
            this.chkBoxShowPassword.Size = new System.Drawing.Size(255, 36);
            this.chkBoxShowPassword.TabIndex = 67;
            this.chkBoxShowPassword.Text = "Show Password";
            this.chkBoxShowPassword.UseVisualStyleBackColor = true;
            this.chkBoxShowPassword.CheckedChanged += new System.EventHandler(this.chkBoxShowPassword_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SA45_Team10a_LibraryManagement.Properties.Resources.PGPLibraryLogo;
            this.pictureBox1.Location = new System.Drawing.Point(15, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // frmNewMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1888, 992);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chkBoxShowPassword);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.lblMemberRegistration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxPasswordCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxUsername);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNext);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNewMember";
            this.Text = "New Member Registration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNewMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxPasswordCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblMemberRegistration;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.CheckBox chkBoxShowPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}