namespace SA45_Team10a_LibraryManagement
{
    partial class frmBorrowBook
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
            this.lblNoBooksWarning = new System.Windows.Forms.Label();
            this.lblAvailableQuantity = new System.Windows.Forms.Label();
            this.txtBoxAvailableQuantity = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblUserDetails = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtBoxBookName = new System.Windows.Forms.TextBox();
            this.txtBoxMemberName = new System.Windows.Forms.TextBox();
            this.btnSearchBID = new System.Windows.Forms.Button();
            this.txtBoxMemberID = new System.Windows.Forms.TextBox();
            this.lblBookID = new System.Windows.Forms.Label();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.dtpDue = new System.Windows.Forms.DateTimePicker();
            this.lblDateBorrow = new System.Windows.Forms.Label();
            this.dtpBorrow = new System.Windows.Forms.DateTimePicker();
            this.lblDateDue = new System.Windows.Forms.Label();
            this.txtBoxBookID = new System.Windows.Forms.TextBox();
            this.lblLogOut = new System.Windows.Forms.Label();
            this.picBoxHome = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHome)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNoBooksWarning
            // 
            this.lblNoBooksWarning.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNoBooksWarning.AutoSize = true;
            this.lblNoBooksWarning.ForeColor = System.Drawing.Color.Red;
            this.lblNoBooksWarning.Location = new System.Drawing.Point(789, 522);
            this.lblNoBooksWarning.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNoBooksWarning.Name = "lblNoBooksWarning";
            this.lblNoBooksWarning.Size = new System.Drawing.Size(249, 32);
            this.lblNoBooksWarning.TabIndex = 60;
            this.lblNoBooksWarning.Text = "Book not available";
            // 
            // lblAvailableQuantity
            // 
            this.lblAvailableQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAvailableQuantity.AutoSize = true;
            this.lblAvailableQuantity.Location = new System.Drawing.Point(1456, 400);
            this.lblAvailableQuantity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAvailableQuantity.Name = "lblAvailableQuantity";
            this.lblAvailableQuantity.Size = new System.Drawing.Size(247, 32);
            this.lblAvailableQuantity.TabIndex = 59;
            this.lblAvailableQuantity.Text = "Available Quantity";
            // 
            // txtBoxAvailableQuantity
            // 
            this.txtBoxAvailableQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxAvailableQuantity.Location = new System.Drawing.Point(1462, 450);
            this.txtBoxAvailableQuantity.Margin = new System.Windows.Forms.Padding(6);
            this.txtBoxAvailableQuantity.Name = "txtBoxAvailableQuantity";
            this.txtBoxAvailableQuantity.ReadOnly = true;
            this.txtBoxAvailableQuantity.Size = new System.Drawing.Size(241, 38);
            this.txtBoxAvailableQuantity.TabIndex = 58;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.Location = new System.Drawing.Point(1111, 853);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(166, 74);
            this.btnReset.TabIndex = 57;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblUserDetails
            // 
            this.lblUserDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserDetails.AutoSize = true;
            this.lblUserDetails.Location = new System.Drawing.Point(1218, 52);
            this.lblUserDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserDetails.Name = "lblUserDetails";
            this.lblUserDetails.Size = new System.Drawing.Size(163, 32);
            this.lblUserDetails.TabIndex = 54;
            this.lblUserDetails.Text = "Member XX";
            this.lblUserDetails.Click += new System.EventHandler(this.lblUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-222, -200);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 32);
            this.label1.TabIndex = 53;
            this.label1.Text = "label1";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.Location = new System.Drawing.Point(512, 853);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(166, 74);
            this.btnSubmit.TabIndex = 52;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtBoxBookName
            // 
            this.txtBoxBookName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxBookName.Location = new System.Drawing.Point(780, 452);
            this.txtBoxBookName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxBookName.Multiline = true;
            this.txtBoxBookName.Name = "txtBoxBookName";
            this.txtBoxBookName.ReadOnly = true;
            this.txtBoxBookName.Size = new System.Drawing.Size(488, 39);
            this.txtBoxBookName.TabIndex = 51;
            // 
            // txtBoxMemberName
            // 
            this.txtBoxMemberName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxMemberName.Location = new System.Drawing.Point(780, 308);
            this.txtBoxMemberName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxMemberName.Name = "txtBoxMemberName";
            this.txtBoxMemberName.ReadOnly = true;
            this.txtBoxMemberName.Size = new System.Drawing.Size(488, 38);
            this.txtBoxMemberName.TabIndex = 50;
            // 
            // btnSearchBID
            // 
            this.btnSearchBID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchBID.Location = new System.Drawing.Point(1298, 400);
            this.btnSearchBID.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchBID.Name = "btnSearchBID";
            this.btnSearchBID.Size = new System.Drawing.Size(68, 54);
            this.btnSearchBID.TabIndex = 49;
            this.btnSearchBID.Text = "...";
            this.btnSearchBID.UseVisualStyleBackColor = true;
            this.btnSearchBID.Click += new System.EventHandler(this.btnSearchBID_Click);
            // 
            // txtBoxMemberID
            // 
            this.txtBoxMemberID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxMemberID.Location = new System.Drawing.Point(780, 254);
            this.txtBoxMemberID.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxMemberID.Name = "txtBoxMemberID";
            this.txtBoxMemberID.ReadOnly = true;
            this.txtBoxMemberID.Size = new System.Drawing.Size(488, 38);
            this.txtBoxMemberID.TabIndex = 45;
            // 
            // lblBookID
            // 
            this.lblBookID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBookID.AutoSize = true;
            this.lblBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookID.Location = new System.Drawing.Point(504, 400);
            this.lblBookID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(148, 39);
            this.lblBookID.TabIndex = 41;
            this.lblBookID.Text = "Book ID:";
            // 
            // lblMemberID
            // 
            this.lblMemberID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberID.Location = new System.Drawing.Point(504, 254);
            this.lblMemberID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(194, 39);
            this.lblMemberID.TabIndex = 42;
            this.lblMemberID.Text = "Member ID:";
            // 
            // dtpDue
            // 
            this.dtpDue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDue.CustomFormat = "dd-MMM-yyyy";
            this.dtpDue.Enabled = false;
            this.dtpDue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDue.Location = new System.Drawing.Point(780, 702);
            this.dtpDue.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDue.Name = "dtpDue";
            this.dtpDue.Size = new System.Drawing.Size(488, 38);
            this.dtpDue.TabIndex = 48;
            // 
            // lblDateBorrow
            // 
            this.lblDateBorrow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDateBorrow.AutoSize = true;
            this.lblDateBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateBorrow.Location = new System.Drawing.Point(504, 578);
            this.lblDateBorrow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateBorrow.Name = "lblDateBorrow";
            this.lblDateBorrow.Size = new System.Drawing.Size(215, 39);
            this.lblDateBorrow.TabIndex = 43;
            this.lblDateBorrow.Text = "Date Borrow:";
            // 
            // dtpBorrow
            // 
            this.dtpBorrow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpBorrow.CustomFormat = "dd-MMM-yyyy";
            this.dtpBorrow.Enabled = false;
            this.dtpBorrow.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBorrow.Location = new System.Drawing.Point(780, 586);
            this.dtpBorrow.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBorrow.Name = "dtpBorrow";
            this.dtpBorrow.Size = new System.Drawing.Size(488, 38);
            this.dtpBorrow.TabIndex = 47;
            // 
            // lblDateDue
            // 
            this.lblDateDue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDateDue.AutoSize = true;
            this.lblDateDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDue.Location = new System.Drawing.Point(504, 702);
            this.lblDateDue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateDue.Name = "lblDateDue";
            this.lblDateDue.Size = new System.Drawing.Size(170, 39);
            this.lblDateDue.TabIndex = 44;
            this.lblDateDue.Text = "Date Due:";
            // 
            // txtBoxBookID
            // 
            this.txtBoxBookID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxBookID.Location = new System.Drawing.Point(780, 400);
            this.txtBoxBookID.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxBookID.Name = "txtBoxBookID";
            this.txtBoxBookID.ReadOnly = true;
            this.txtBoxBookID.Size = new System.Drawing.Size(488, 38);
            this.txtBoxBookID.TabIndex = 46;
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
            this.lblLogOut.TabIndex = 40;
            this.lblLogOut.Text = "Log Out";
            this.lblLogOut.Click += new System.EventHandler(this.lblLogOut_Click);
            // 
            // picBoxHome
            // 
            this.picBoxHome.Image = global::SA45_Team10a_LibraryManagement.Properties.Resources.PGPLibraryLogo;
            this.picBoxHome.Location = new System.Drawing.Point(13, 13);
            this.picBoxHome.Margin = new System.Windows.Forms.Padding(4);
            this.picBoxHome.Name = "picBoxHome";
            this.picBoxHome.Size = new System.Drawing.Size(254, 217);
            this.picBoxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxHome.TabIndex = 55;
            this.picBoxHome.TabStop = false;
            this.picBoxHome.Click += new System.EventHandler(this.picBoxHome_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(797, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 61);
            this.label3.TabIndex = 61;
            this.label3.Text = "Borrow Book";
            // 
            // frmBorrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1888, 992);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNoBooksWarning);
            this.Controls.Add(this.lblAvailableQuantity);
            this.Controls.Add(this.txtBoxAvailableQuantity);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.picBoxHome);
            this.Controls.Add(this.lblUserDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtBoxBookName);
            this.Controls.Add(this.txtBoxMemberName);
            this.Controls.Add(this.btnSearchBID);
            this.Controls.Add(this.txtBoxMemberID);
            this.Controls.Add(this.lblBookID);
            this.Controls.Add(this.lblMemberID);
            this.Controls.Add(this.dtpDue);
            this.Controls.Add(this.lblDateBorrow);
            this.Controls.Add(this.dtpBorrow);
            this.Controls.Add(this.lblDateDue);
            this.Controls.Add(this.txtBoxBookID);
            this.Controls.Add(this.lblLogOut);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBorrowBook";
            this.Text = "Borrow Book";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBorrowBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNoBooksWarning;
        private System.Windows.Forms.Label lblAvailableQuantity;
        private System.Windows.Forms.TextBox txtBoxAvailableQuantity;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox picBoxHome;
        private System.Windows.Forms.Label lblUserDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtBoxBookName;
        private System.Windows.Forms.TextBox txtBoxMemberName;
        private System.Windows.Forms.Button btnSearchBID;
        private System.Windows.Forms.TextBox txtBoxMemberID;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.DateTimePicker dtpDue;
        private System.Windows.Forms.Label lblDateBorrow;
        private System.Windows.Forms.DateTimePicker dtpBorrow;
        private System.Windows.Forms.Label lblDateDue;
        private System.Windows.Forms.TextBox txtBoxBookID;
        private System.Windows.Forms.Label lblLogOut;
        private System.Windows.Forms.Label label3;
    }
}