namespace SA45_Team10a_LibraryManagement
{
    partial class frmReturnBook
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
            this.txtBoxDateDue = new System.Windows.Forms.TextBox();
            this.txtBoxDateBorrow = new System.Windows.Forms.TextBox();
            this.dgvReturn = new System.Windows.Forms.DataGridView();
            this.lblFine = new System.Windows.Forms.Label();
            this.txtFine = new System.Windows.Forms.TextBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.dtpDateReturn = new System.Windows.Forms.DateTimePicker();
            this.cboBoxPaymentStatus = new System.Windows.Forms.ComboBox();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.lblDateReturn = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtBoxMID = new System.Windows.Forms.TextBox();
            this.lblMID = new System.Windows.Forms.Label();
            this.lblRemark = new System.Windows.Forms.Label();
            this.lblDateBorrow = new System.Windows.Forms.Label();
            this.lblDateDue = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblLogOut = new System.Windows.Forms.Label();
            this.picBoxHome = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMIDWarning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHome)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxDateDue
            // 
            this.txtBoxDateDue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxDateDue.Location = new System.Drawing.Point(455, 502);
            this.txtBoxDateDue.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxDateDue.Name = "txtBoxDateDue";
            this.txtBoxDateDue.ReadOnly = true;
            this.txtBoxDateDue.Size = new System.Drawing.Size(344, 38);
            this.txtBoxDateDue.TabIndex = 84;
            // 
            // txtBoxDateBorrow
            // 
            this.txtBoxDateBorrow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxDateBorrow.Location = new System.Drawing.Point(455, 426);
            this.txtBoxDateBorrow.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxDateBorrow.Name = "txtBoxDateBorrow";
            this.txtBoxDateBorrow.ReadOnly = true;
            this.txtBoxDateBorrow.Size = new System.Drawing.Size(344, 38);
            this.txtBoxDateBorrow.TabIndex = 83;
            // 
            // dgvReturn
            // 
            this.dgvReturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturn.Location = new System.Drawing.Point(872, 337);
            this.dgvReturn.Margin = new System.Windows.Forms.Padding(4);
            this.dgvReturn.MultiSelect = false;
            this.dgvReturn.Name = "dgvReturn";
            this.dgvReturn.RowTemplate.Height = 40;
            this.dgvReturn.Size = new System.Drawing.Size(1444, 536);
            this.dgvReturn.TabIndex = 81;
            this.dgvReturn.SelectionChanged += new System.EventHandler(this.dgvReturn_SelectionChanged);
            // 
            // lblFine
            // 
            this.lblFine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFine.AutoSize = true;
            this.lblFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFine.Location = new System.Drawing.Point(111, 686);
            this.lblFine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFine.Name = "lblFine";
            this.lblFine.Size = new System.Drawing.Size(229, 39);
            this.lblFine.TabIndex = 79;
            this.lblFine.Text = "OverDueFine:";
            // 
            // txtFine
            // 
            this.txtFine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFine.Location = new System.Drawing.Point(455, 688);
            this.txtFine.Margin = new System.Windows.Forms.Padding(4);
            this.txtFine.Name = "txtFine";
            this.txtFine.ReadOnly = true;
            this.txtFine.Size = new System.Drawing.Size(344, 38);
            this.txtFine.TabIndex = 80;
            // 
            // txtRemark
            // 
            this.txtRemark.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRemark.Location = new System.Drawing.Point(455, 837);
            this.txtRemark.Margin = new System.Windows.Forms.Padding(4);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(344, 38);
            this.txtRemark.TabIndex = 78;
            // 
            // dtpDateReturn
            // 
            this.dtpDateReturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDateReturn.CustomFormat = "dd-MMM-yyyy";
            this.dtpDateReturn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateReturn.Location = new System.Drawing.Point(455, 608);
            this.dtpDateReturn.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateReturn.MaxDate = new System.DateTime(2017, 9, 26, 15, 44, 17, 0);
            this.dtpDateReturn.Name = "dtpDateReturn";
            this.dtpDateReturn.Size = new System.Drawing.Size(344, 38);
            this.dtpDateReturn.TabIndex = 77;
            this.dtpDateReturn.Value = new System.DateTime(2017, 9, 26, 0, 0, 0, 0);
            this.dtpDateReturn.Leave += new System.EventHandler(this.dtpDateReturn_Leave);
            // 
            // cboBoxPaymentStatus
            // 
            this.cboBoxPaymentStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboBoxPaymentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxPaymentStatus.FormattingEnabled = true;
            this.cboBoxPaymentStatus.Items.AddRange(new object[] {
            "NA",
            "PAID"});
            this.cboBoxPaymentStatus.Location = new System.Drawing.Point(455, 763);
            this.cboBoxPaymentStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cboBoxPaymentStatus.Name = "cboBoxPaymentStatus";
            this.cboBoxPaymentStatus.Size = new System.Drawing.Size(344, 39);
            this.cboBoxPaymentStatus.TabIndex = 76;
            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPaymentStatus.AutoSize = true;
            this.lblPaymentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentStatus.Location = new System.Drawing.Point(111, 761);
            this.lblPaymentStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(314, 39);
            this.lblPaymentStatus.TabIndex = 75;
            this.lblPaymentStatus.Text = "FinePaymentStatus";
            // 
            // lblDateReturn
            // 
            this.lblDateReturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDateReturn.AutoSize = true;
            this.lblDateReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateReturn.Location = new System.Drawing.Point(111, 610);
            this.lblDateReturn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateReturn.Name = "lblDateReturn";
            this.lblDateReturn.Size = new System.Drawing.Size(286, 39);
            this.lblDateReturn.TabIndex = 74;
            this.lblDateReturn.Text = "DateActualReturn";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.Location = new System.Drawing.Point(343, 924);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(148, 68);
            this.btnSubmit.TabIndex = 73;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtBoxMID
            // 
            this.txtBoxMID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxMID.Location = new System.Drawing.Point(455, 339);
            this.txtBoxMID.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxMID.Name = "txtBoxMID";
            this.txtBoxMID.Size = new System.Drawing.Size(344, 38);
            this.txtBoxMID.TabIndex = 71;
            this.txtBoxMID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBoxMID_KeyUp);
            // 
            // lblMID
            // 
            this.lblMID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMID.AutoSize = true;
            this.lblMID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMID.Location = new System.Drawing.Point(111, 337);
            this.lblMID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMID.Name = "lblMID";
            this.lblMID.Size = new System.Drawing.Size(194, 39);
            this.lblMID.TabIndex = 68;
            this.lblMID.Text = "Member ID:";
            // 
            // lblRemark
            // 
            this.lblRemark.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRemark.AutoSize = true;
            this.lblRemark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemark.Location = new System.Drawing.Point(111, 837);
            this.lblRemark.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(162, 39);
            this.lblRemark.TabIndex = 72;
            this.lblRemark.Text = "Remarks:";
            // 
            // lblDateBorrow
            // 
            this.lblDateBorrow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDateBorrow.AutoSize = true;
            this.lblDateBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateBorrow.Location = new System.Drawing.Point(111, 426);
            this.lblDateBorrow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateBorrow.Name = "lblDateBorrow";
            this.lblDateBorrow.Size = new System.Drawing.Size(215, 39);
            this.lblDateBorrow.TabIndex = 69;
            this.lblDateBorrow.Text = "Date Borrow:";
            // 
            // lblDateDue
            // 
            this.lblDateDue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDateDue.AutoSize = true;
            this.lblDateDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDue.Location = new System.Drawing.Point(111, 502);
            this.lblDateDue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateDue.Name = "lblDateDue";
            this.lblDateDue.Size = new System.Drawing.Size(170, 39);
            this.lblDateDue.TabIndex = 70;
            this.lblDateDue.Text = "Date Due:";
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(1218, 52);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(172, 32);
            this.lblUser.TabIndex = 66;
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
            this.lblLogOut.TabIndex = 65;
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
            this.picBoxHome.TabIndex = 67;
            this.picBoxHome.TabStop = false;
            this.picBoxHome.Click += new System.EventHandler(this.picBoxHome_Click);
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
            this.label4.Size = new System.Drawing.Size(319, 61);
            this.label4.TabIndex = 85;
            this.label4.Text = "Return Book";
            // 
            // lblMIDWarning
            // 
            this.lblMIDWarning.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMIDWarning.AutoSize = true;
            this.lblMIDWarning.ForeColor = System.Drawing.Color.Red;
            this.lblMIDWarning.Location = new System.Drawing.Point(118, 269);
            this.lblMIDWarning.Name = "lblMIDWarning";
            this.lblMIDWarning.Size = new System.Drawing.Size(35, 32);
            this.lblMIDWarning.TabIndex = 86;
            this.lblMIDWarning.Text = "\"\"";
            // 
            // frmReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1888, 992);
            this.Controls.Add(this.lblMIDWarning);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxDateDue);
            this.Controls.Add(this.txtBoxDateBorrow);
            this.Controls.Add(this.dgvReturn);
            this.Controls.Add(this.lblFine);
            this.Controls.Add(this.txtFine);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.dtpDateReturn);
            this.Controls.Add(this.cboBoxPaymentStatus);
            this.Controls.Add(this.lblPaymentStatus);
            this.Controls.Add(this.lblDateReturn);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtBoxMID);
            this.Controls.Add(this.lblMID);
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.lblDateBorrow);
            this.Controls.Add(this.lblDateDue);
            this.Controls.Add(this.picBoxHome);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblLogOut);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReturnBook";
            this.Text = "ReturnBook";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReturnBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxDateDue;
        private System.Windows.Forms.TextBox txtBoxDateBorrow;
        private System.Windows.Forms.DataGridView dgvReturn;
        private System.Windows.Forms.Label lblFine;
        private System.Windows.Forms.TextBox txtFine;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.DateTimePicker dtpDateReturn;
        private System.Windows.Forms.ComboBox cboBoxPaymentStatus;
        private System.Windows.Forms.Label lblPaymentStatus;
        private System.Windows.Forms.Label lblDateReturn;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtBoxMID;
        private System.Windows.Forms.Label lblMID;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.Label lblDateBorrow;
        private System.Windows.Forms.Label lblDateDue;
        private System.Windows.Forms.PictureBox picBoxHome;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblLogOut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMIDWarning;
    }
}