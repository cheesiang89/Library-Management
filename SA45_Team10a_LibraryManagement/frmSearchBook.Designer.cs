namespace SA45_Team10a_LibraryManagement
{
    partial class frmSearchBook
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
            this.lblDateDue = new System.Windows.Forms.Label();
            this.lblBookAvailble = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBookNotFound = new System.Windows.Forms.Label();
            this.lblCriteria = new System.Windows.Forms.Label();
            this.listBoxDateDue = new System.Windows.Forms.ListBox();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BooksQuantityAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublisherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CallNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picBoxHome = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblLogOut = new System.Windows.Forms.Label();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHome)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDateDue
            // 
            this.lblDateDue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDateDue.AutoSize = true;
            this.lblDateDue.Location = new System.Drawing.Point(395, 851);
            this.lblDateDue.Name = "lblDateDue";
            this.lblDateDue.Size = new System.Drawing.Size(134, 32);
            this.lblDateDue.TabIndex = 88;
            this.lblDateDue.Text = "Date Due";
            // 
            // lblBookAvailble
            // 
            this.lblBookAvailble.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBookAvailble.AutoSize = true;
            this.lblBookAvailble.ForeColor = System.Drawing.Color.Black;
            this.lblBookAvailble.Location = new System.Drawing.Point(1193, 900);
            this.lblBookAvailble.Name = "lblBookAvailble";
            this.lblBookAvailble.Size = new System.Drawing.Size(230, 32);
            this.lblBookAvailble.TabIndex = 87;
            this.lblBookAvailble.Text = "Book is available";
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
            this.label4.Size = new System.Drawing.Size(328, 61);
            this.label4.TabIndex = 86;
            this.label4.Text = "Search Book";
            // 
            // lblBookNotFound
            // 
            this.lblBookNotFound.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBookNotFound.AutoSize = true;
            this.lblBookNotFound.ForeColor = System.Drawing.Color.Red;
            this.lblBookNotFound.Location = new System.Drawing.Point(1511, 237);
            this.lblBookNotFound.Name = "lblBookNotFound";
            this.lblBookNotFound.Size = new System.Drawing.Size(206, 32);
            this.lblBookNotFound.TabIndex = 41;
            this.lblBookNotFound.Text = "Book not found";
            // 
            // lblCriteria
            // 
            this.lblCriteria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCriteria.AutoSize = true;
            this.lblCriteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriteria.Location = new System.Drawing.Point(587, 302);
            this.lblCriteria.Name = "lblCriteria";
            this.lblCriteria.Size = new System.Drawing.Size(515, 32);
            this.lblCriteria.TabIndex = 40;
            this.lblCriteria.Text = "Can search by: Title, Author, Book Type";
            // 
            // listBoxDateDue
            // 
            this.listBoxDateDue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxDateDue.FormattingEnabled = true;
            this.listBoxDateDue.ItemHeight = 31;
            this.listBoxDateDue.Location = new System.Drawing.Point(395, 890);
            this.listBoxDateDue.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxDateDue.Name = "listBoxDateDue";
            this.listBoxDateDue.Size = new System.Drawing.Size(432, 283);
            this.listBoxDateDue.TabIndex = 39;
            // 
            // dgvSearch
            // 
            this.dgvSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID,
            this.BookTitle,
            this.BookType,
            this.AuthorName,
            this.BooksQuantityAvailable,
            this.ISBN,
            this.Language,
            this.PublisherName,
            this.Notes,
            this.Section,
            this.CallNumber});
            this.dgvSearch.Location = new System.Drawing.Point(304, 373);
            this.dgvSearch.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSearch.MultiSelect = false;
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.RowTemplate.Height = 40;
            this.dgvSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearch.Size = new System.Drawing.Size(1368, 470);
            this.dgvSearch.TabIndex = 38;
            this.dgvSearch.SelectionChanged += new System.EventHandler(this.dgvSearch_SelectionChanged);
            // 
            // BookID
            // 
            this.BookID.DataPropertyName = "BookID";
            this.BookID.HeaderText = "BookID";
            this.BookID.Name = "BookID";
            // 
            // BookTitle
            // 
            this.BookTitle.DataPropertyName = "BookTitle";
            this.BookTitle.HeaderText = "BookTitle";
            this.BookTitle.Name = "BookTitle";
            // 
            // BookType
            // 
            this.BookType.DataPropertyName = "BookType";
            this.BookType.HeaderText = "BookType";
            this.BookType.Name = "BookType";
            // 
            // AuthorName
            // 
            this.AuthorName.DataPropertyName = "AuthorName";
            this.AuthorName.HeaderText = "AuthorName";
            this.AuthorName.Name = "AuthorName";
            // 
            // BooksQuantityAvailable
            // 
            this.BooksQuantityAvailable.DataPropertyName = "QuantityAvailable";
            this.BooksQuantityAvailable.HeaderText = "BooksQuantityAvailable";
            this.BooksQuantityAvailable.Name = "BooksQuantityAvailable";
            // 
            // ISBN
            // 
            this.ISBN.DataPropertyName = "ISBN";
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            // 
            // Language
            // 
            this.Language.DataPropertyName = "Language";
            this.Language.HeaderText = "Language";
            this.Language.Name = "Language";
            // 
            // PublisherName
            // 
            this.PublisherName.DataPropertyName = "PublisherName";
            this.PublisherName.HeaderText = "PublisherName";
            this.PublisherName.Name = "PublisherName";
            // 
            // Notes
            // 
            this.Notes.DataPropertyName = "Notes";
            this.Notes.HeaderText = "Notes";
            this.Notes.Name = "Notes";
            // 
            // Section
            // 
            this.Section.DataPropertyName = "Section";
            this.Section.HeaderText = "Section";
            this.Section.Name = "Section";
            // 
            // CallNumber
            // 
            this.CallNumber.DataPropertyName = "CallNumber";
            this.CallNumber.HeaderText = "CallNumber";
            this.CallNumber.Name = "CallNumber";
            // 
            // picBoxHome
            // 
            this.picBoxHome.Image = global::SA45_Team10a_LibraryManagement.Properties.Resources.PGPLibraryLogo;
            this.picBoxHome.Location = new System.Drawing.Point(13, 13);
            this.picBoxHome.Margin = new System.Windows.Forms.Padding(4);
            this.picBoxHome.Name = "picBoxHome";
            this.picBoxHome.Size = new System.Drawing.Size(254, 217);
            this.picBoxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxHome.TabIndex = 37;
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
            this.lblUser.Size = new System.Drawing.Size(163, 32);
            this.lblUser.TabIndex = 36;
            this.lblUser.Text = "Member XX";
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
            this.lblLogOut.TabIndex = 35;
            this.lblLogOut.Text = "Log Out";
            this.lblLogOut.Click += new System.EventHandler(this.lblLogOut_Click);
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxSearch.Location = new System.Drawing.Point(575, 237);
            this.txtBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(552, 38);
            this.txtBoxSearch.TabIndex = 3;
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.Location = new System.Drawing.Point(1241, 221);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(208, 68);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmSearchBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1888, 992);
            this.Controls.Add(this.lblDateDue);
            this.Controls.Add(this.lblBookAvailble);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblBookNotFound);
            this.Controls.Add(this.lblCriteria);
            this.Controls.Add(this.listBoxDateDue);
            this.Controls.Add(this.dgvSearch);
            this.Controls.Add(this.picBoxHome);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblLogOut);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.btnSearch);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSearchBook";
            this.Text = "SearchBook";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSearchBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.PictureBox picBoxHome;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblLogOut;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.ListBox listBoxDateDue;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookType;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BooksQuantityAvailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Language;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublisherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Section;
        private System.Windows.Forms.DataGridViewTextBoxColumn CallNumber;
        private System.Windows.Forms.Label lblCriteria;
        private System.Windows.Forms.Label lblBookNotFound;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBookAvailble;
        private System.Windows.Forms.Label lblDateDue;
    }
}