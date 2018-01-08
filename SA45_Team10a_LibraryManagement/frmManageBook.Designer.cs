namespace SA45_Team10a_LibraryManagement
{
    partial class frmManageBook
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
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gBoxUpdateBook = new System.Windows.Forms.GroupBox();
            this.cboBoxPublisherUpdate = new System.Windows.Forms.ComboBox();
            this.cboBoxAuthorUpdate = new System.Windows.Forms.ComboBox();
            this.lblPublisherUpdate = new System.Windows.Forms.Label();
            this.lblAuthorUpdate = new System.Windows.Forms.Label();
            this.btnCancelUpdate = new System.Windows.Forms.Button();
            this.cboBoxBookTypeUpdate = new System.Windows.Forms.ComboBox();
            this.cboBoxLanguageUpdate = new System.Windows.Forms.ComboBox();
            this.txtQuantityUpdate = new System.Windows.Forms.TextBox();
            this.lblQuantityUpdate = new System.Windows.Forms.Label();
            this.txtNoteUpdate = new System.Windows.Forms.TextBox();
            this.lblNoteUpdate = new System.Windows.Forms.Label();
            this.lblBookTypeUpdate = new System.Windows.Forms.Label();
            this.lblISBNUpdate = new System.Windows.Forms.Label();
            this.txtCallNoUpdate = new System.Windows.Forms.TextBox();
            this.cboBoxSectionUpdate = new System.Windows.Forms.ComboBox();
            this.lblSectionUpdate = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtISBNUpdate = new System.Windows.Forms.TextBox();
            this.txtBookNameUpdate = new System.Windows.Forms.TextBox();
            this.lblBookIDUpdate = new System.Windows.Forms.Label();
            this.lblCallNoUpdate = new System.Windows.Forms.Label();
            this.lblBookTitleUpdate = new System.Windows.Forms.Label();
            this.lblLanguageUpdate = new System.Windows.Forms.Label();
            this.txtBookTitleUpdate = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.picBoxHome = new System.Windows.Forms.PictureBox();
            this.gBoxAddBook = new System.Windows.Forms.GroupBox();
            this.cboBoxPublisherAdd = new System.Windows.Forms.ComboBox();
            this.cboBoxAuthorAdd = new System.Windows.Forms.ComboBox();
            this.btnCancelAdd = new System.Windows.Forms.Button();
            this.cboBoxBookTypeAdd = new System.Windows.Forms.ComboBox();
            this.cboBoxLanguageAdd = new System.Windows.Forms.ComboBox();
            this.txtQuantityAdd = new System.Windows.Forms.TextBox();
            this.lblQuantityAdd = new System.Windows.Forms.Label();
            this.txtNoteAdd = new System.Windows.Forms.TextBox();
            this.lblNoteAdd = new System.Windows.Forms.Label();
            this.lblBookTypeAdd = new System.Windows.Forms.Label();
            this.lblISBNAdd = new System.Windows.Forms.Label();
            this.txtCallNoAdd = new System.Windows.Forms.TextBox();
            this.cboBoxSectionAdd = new System.Windows.Forms.ComboBox();
            this.lblSectionAdd = new System.Windows.Forms.Label();
            this.lblPublisherAdd = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtISBNAdd = new System.Windows.Forms.TextBox();
            this.lblCallNoAdd = new System.Windows.Forms.Label();
            this.lblBookTitleAdd = new System.Windows.Forms.Label();
            this.lblLanguageAdd = new System.Windows.Forms.Label();
            this.lblAuthorAdd = new System.Windows.Forms.Label();
            this.txtBookTitleAdd = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblLogOut = new System.Windows.Forms.Label();
            this.bookListingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.gBoxUpdateBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHome)).BeginInit();
            this.gBoxAddBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookListingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(737, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(359, 63);
            this.label3.TabIndex = 62;
            this.label3.Text = "Manage Book";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(902, 175);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(242, 87);
            this.button2.TabIndex = 44;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.gBoxUpdateBook);
            this.panel1.Location = new System.Drawing.Point(506, 359);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 940);
            this.panel1.TabIndex = 41;
            this.panel1.Visible = false;
            // 
            // gBoxUpdateBook
            // 
            this.gBoxUpdateBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gBoxUpdateBook.Controls.Add(this.cboBoxPublisherUpdate);
            this.gBoxUpdateBook.Controls.Add(this.cboBoxAuthorUpdate);
            this.gBoxUpdateBook.Controls.Add(this.lblPublisherUpdate);
            this.gBoxUpdateBook.Controls.Add(this.lblAuthorUpdate);
            this.gBoxUpdateBook.Controls.Add(this.btnCancelUpdate);
            this.gBoxUpdateBook.Controls.Add(this.cboBoxBookTypeUpdate);
            this.gBoxUpdateBook.Controls.Add(this.cboBoxLanguageUpdate);
            this.gBoxUpdateBook.Controls.Add(this.txtQuantityUpdate);
            this.gBoxUpdateBook.Controls.Add(this.lblQuantityUpdate);
            this.gBoxUpdateBook.Controls.Add(this.txtNoteUpdate);
            this.gBoxUpdateBook.Controls.Add(this.lblNoteUpdate);
            this.gBoxUpdateBook.Controls.Add(this.lblBookTypeUpdate);
            this.gBoxUpdateBook.Controls.Add(this.lblISBNUpdate);
            this.gBoxUpdateBook.Controls.Add(this.txtCallNoUpdate);
            this.gBoxUpdateBook.Controls.Add(this.cboBoxSectionUpdate);
            this.gBoxUpdateBook.Controls.Add(this.lblSectionUpdate);
            this.gBoxUpdateBook.Controls.Add(this.btnUpdate);
            this.gBoxUpdateBook.Controls.Add(this.txtISBNUpdate);
            this.gBoxUpdateBook.Controls.Add(this.txtBookNameUpdate);
            this.gBoxUpdateBook.Controls.Add(this.lblBookIDUpdate);
            this.gBoxUpdateBook.Controls.Add(this.lblCallNoUpdate);
            this.gBoxUpdateBook.Controls.Add(this.lblBookTitleUpdate);
            this.gBoxUpdateBook.Controls.Add(this.lblLanguageUpdate);
            this.gBoxUpdateBook.Controls.Add(this.txtBookTitleUpdate);
            this.gBoxUpdateBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxUpdateBook.Location = new System.Drawing.Point(20, 19);
            this.gBoxUpdateBook.Margin = new System.Windows.Forms.Padding(4);
            this.gBoxUpdateBook.Name = "gBoxUpdateBook";
            this.gBoxUpdateBook.Padding = new System.Windows.Forms.Padding(4);
            this.gBoxUpdateBook.Size = new System.Drawing.Size(760, 903);
            this.gBoxUpdateBook.TabIndex = 41;
            this.gBoxUpdateBook.TabStop = false;
            this.gBoxUpdateBook.Text = "Update Book";
            // 
            // cboBoxPublisherUpdate
            // 
            this.cboBoxPublisherUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxPublisherUpdate.FormattingEnabled = true;
            this.cboBoxPublisherUpdate.Items.AddRange(new object[] {
            "Gale",
            "CiNii",
            "EBSCO Publishing"});
            this.cboBoxPublisherUpdate.Location = new System.Drawing.Point(364, 459);
            this.cboBoxPublisherUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.cboBoxPublisherUpdate.Name = "cboBoxPublisherUpdate";
            this.cboBoxPublisherUpdate.Size = new System.Drawing.Size(372, 54);
            this.cboBoxPublisherUpdate.TabIndex = 37;
            // 
            // cboBoxAuthorUpdate
            // 
            this.cboBoxAuthorUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxAuthorUpdate.FormattingEnabled = true;
            this.cboBoxAuthorUpdate.Items.AddRange(new object[] {
            "Jin Yong",
            "Jiro Akagawa",
            "Stephen King",
            "JK Rowling",
            "Nicholas Sparks"});
            this.cboBoxAuthorUpdate.Location = new System.Drawing.Point(364, 397);
            this.cboBoxAuthorUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.cboBoxAuthorUpdate.Name = "cboBoxAuthorUpdate";
            this.cboBoxAuthorUpdate.Size = new System.Drawing.Size(372, 54);
            this.cboBoxAuthorUpdate.TabIndex = 36;
            // 
            // lblPublisherUpdate
            // 
            this.lblPublisherUpdate.AutoSize = true;
            this.lblPublisherUpdate.Location = new System.Drawing.Point(16, 467);
            this.lblPublisherUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPublisherUpdate.Name = "lblPublisherUpdate";
            this.lblPublisherUpdate.Size = new System.Drawing.Size(314, 46);
            this.lblPublisherUpdate.TabIndex = 35;
            this.lblPublisherUpdate.Text = "Publisher Name:";
            // 
            // lblAuthorUpdate
            // 
            this.lblAuthorUpdate.AutoSize = true;
            this.lblAuthorUpdate.Location = new System.Drawing.Point(16, 403);
            this.lblAuthorUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthorUpdate.Name = "lblAuthorUpdate";
            this.lblAuthorUpdate.Size = new System.Drawing.Size(266, 46);
            this.lblAuthorUpdate.TabIndex = 34;
            this.lblAuthorUpdate.Text = "Author Name:";
            // 
            // btnCancelUpdate
            // 
            this.btnCancelUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelUpdate.Location = new System.Drawing.Point(604, 800);
            this.btnCancelUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelUpdate.Name = "btnCancelUpdate";
            this.btnCancelUpdate.Size = new System.Drawing.Size(132, 66);
            this.btnCancelUpdate.TabIndex = 31;
            this.btnCancelUpdate.Text = "Cancel";
            this.btnCancelUpdate.UseVisualStyleBackColor = true;
            this.btnCancelUpdate.Click += new System.EventHandler(this.btnCancelUpdate_Click);
            // 
            // cboBoxBookTypeUpdate
            // 
            this.cboBoxBookTypeUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxBookTypeUpdate.FormattingEnabled = true;
            this.cboBoxBookTypeUpdate.Items.AddRange(new object[] {
            "Fantasy",
            "Horrow",
            "Action",
            "Mystery",
            "Romance"});
            this.cboBoxBookTypeUpdate.Location = new System.Drawing.Point(364, 271);
            this.cboBoxBookTypeUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.cboBoxBookTypeUpdate.Name = "cboBoxBookTypeUpdate";
            this.cboBoxBookTypeUpdate.Size = new System.Drawing.Size(372, 54);
            this.cboBoxBookTypeUpdate.TabIndex = 30;
            // 
            // cboBoxLanguageUpdate
            // 
            this.cboBoxLanguageUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxLanguageUpdate.FormattingEnabled = true;
            this.cboBoxLanguageUpdate.Items.AddRange(new object[] {
            "English",
            "Chinese"});
            this.cboBoxLanguageUpdate.Location = new System.Drawing.Point(364, 333);
            this.cboBoxLanguageUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.cboBoxLanguageUpdate.Name = "cboBoxLanguageUpdate";
            this.cboBoxLanguageUpdate.Size = new System.Drawing.Size(372, 54);
            this.cboBoxLanguageUpdate.TabIndex = 29;
            // 
            // txtQuantityUpdate
            // 
            this.txtQuantityUpdate.Location = new System.Drawing.Point(364, 707);
            this.txtQuantityUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantityUpdate.Name = "txtQuantityUpdate";
            this.txtQuantityUpdate.Size = new System.Drawing.Size(372, 53);
            this.txtQuantityUpdate.TabIndex = 27;
            // 
            // lblQuantityUpdate
            // 
            this.lblQuantityUpdate.AutoSize = true;
            this.lblQuantityUpdate.Location = new System.Drawing.Point(16, 715);
            this.lblQuantityUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantityUpdate.Name = "lblQuantityUpdate";
            this.lblQuantityUpdate.Size = new System.Drawing.Size(179, 46);
            this.lblQuantityUpdate.TabIndex = 26;
            this.lblQuantityUpdate.Text = "Quantity:";
            // 
            // txtNoteUpdate
            // 
            this.txtNoteUpdate.Location = new System.Drawing.Point(364, 645);
            this.txtNoteUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoteUpdate.Name = "txtNoteUpdate";
            this.txtNoteUpdate.Size = new System.Drawing.Size(372, 53);
            this.txtNoteUpdate.TabIndex = 25;
            // 
            // lblNoteUpdate
            // 
            this.lblNoteUpdate.AutoSize = true;
            this.lblNoteUpdate.Location = new System.Drawing.Point(16, 653);
            this.lblNoteUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoteUpdate.Name = "lblNoteUpdate";
            this.lblNoteUpdate.Size = new System.Drawing.Size(136, 46);
            this.lblNoteUpdate.TabIndex = 24;
            this.lblNoteUpdate.Text = "Notes:";
            // 
            // lblBookTypeUpdate
            // 
            this.lblBookTypeUpdate.AutoSize = true;
            this.lblBookTypeUpdate.Location = new System.Drawing.Point(16, 273);
            this.lblBookTypeUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookTypeUpdate.Name = "lblBookTypeUpdate";
            this.lblBookTypeUpdate.Size = new System.Drawing.Size(212, 46);
            this.lblBookTypeUpdate.TabIndex = 23;
            this.lblBookTypeUpdate.Text = "BookType:";
            // 
            // lblISBNUpdate
            // 
            this.lblISBNUpdate.AutoSize = true;
            this.lblISBNUpdate.Location = new System.Drawing.Point(16, 147);
            this.lblISBNUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblISBNUpdate.Name = "lblISBNUpdate";
            this.lblISBNUpdate.Size = new System.Drawing.Size(124, 46);
            this.lblISBNUpdate.TabIndex = 21;
            this.lblISBNUpdate.Text = "ISBN:";
            // 
            // txtCallNoUpdate
            // 
            this.txtCallNoUpdate.Location = new System.Drawing.Point(364, 583);
            this.txtCallNoUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.txtCallNoUpdate.Name = "txtCallNoUpdate";
            this.txtCallNoUpdate.Size = new System.Drawing.Size(372, 53);
            this.txtCallNoUpdate.TabIndex = 20;
            // 
            // cboBoxSectionUpdate
            // 
            this.cboBoxSectionUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxSectionUpdate.FormattingEnabled = true;
            this.cboBoxSectionUpdate.Items.AddRange(new object[] {
            "Young Adult",
            "Adult"});
            this.cboBoxSectionUpdate.Location = new System.Drawing.Point(364, 521);
            this.cboBoxSectionUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.cboBoxSectionUpdate.Name = "cboBoxSectionUpdate";
            this.cboBoxSectionUpdate.Size = new System.Drawing.Size(372, 54);
            this.cboBoxSectionUpdate.TabIndex = 18;
            // 
            // lblSectionUpdate
            // 
            this.lblSectionUpdate.AutoSize = true;
            this.lblSectionUpdate.Location = new System.Drawing.Point(16, 525);
            this.lblSectionUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSectionUpdate.Name = "lblSectionUpdate";
            this.lblSectionUpdate.Size = new System.Drawing.Size(166, 46);
            this.lblSectionUpdate.TabIndex = 17;
            this.lblSectionUpdate.Text = "Section:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(24, 800);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(132, 66);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtISBNUpdate
            // 
            this.txtISBNUpdate.Location = new System.Drawing.Point(364, 147);
            this.txtISBNUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.txtISBNUpdate.Name = "txtISBNUpdate";
            this.txtISBNUpdate.Size = new System.Drawing.Size(372, 53);
            this.txtISBNUpdate.TabIndex = 13;
            // 
            // txtBookNameUpdate
            // 
            this.txtBookNameUpdate.Location = new System.Drawing.Point(364, 85);
            this.txtBookNameUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookNameUpdate.Name = "txtBookNameUpdate";
            this.txtBookNameUpdate.Size = new System.Drawing.Size(372, 53);
            this.txtBookNameUpdate.TabIndex = 5;
            this.txtBookNameUpdate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBookNameUpdate_KeyPress);
            // 
            // lblBookIDUpdate
            // 
            this.lblBookIDUpdate.AutoSize = true;
            this.lblBookIDUpdate.Location = new System.Drawing.Point(16, 85);
            this.lblBookIDUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookIDUpdate.Name = "lblBookIDUpdate";
            this.lblBookIDUpdate.Size = new System.Drawing.Size(174, 46);
            this.lblBookIDUpdate.TabIndex = 1;
            this.lblBookIDUpdate.Text = "Book ID:";
            // 
            // lblCallNoUpdate
            // 
            this.lblCallNoUpdate.AutoSize = true;
            this.lblCallNoUpdate.Location = new System.Drawing.Point(16, 589);
            this.lblCallNoUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCallNoUpdate.Name = "lblCallNoUpdate";
            this.lblCallNoUpdate.Size = new System.Drawing.Size(241, 46);
            this.lblCallNoUpdate.TabIndex = 9;
            this.lblCallNoUpdate.Text = "CallNumber:";
            // 
            // lblBookTitleUpdate
            // 
            this.lblBookTitleUpdate.AutoSize = true;
            this.lblBookTitleUpdate.Location = new System.Drawing.Point(16, 211);
            this.lblBookTitleUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookTitleUpdate.Name = "lblBookTitleUpdate";
            this.lblBookTitleUpdate.Size = new System.Drawing.Size(199, 46);
            this.lblBookTitleUpdate.TabIndex = 2;
            this.lblBookTitleUpdate.Text = "BookTitle:";
            // 
            // lblLanguageUpdate
            // 
            this.lblLanguageUpdate.AutoSize = true;
            this.lblLanguageUpdate.Location = new System.Drawing.Point(16, 337);
            this.lblLanguageUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLanguageUpdate.Name = "lblLanguageUpdate";
            this.lblLanguageUpdate.Size = new System.Drawing.Size(207, 46);
            this.lblLanguageUpdate.TabIndex = 3;
            this.lblLanguageUpdate.Text = "Language:";
            // 
            // txtBookTitleUpdate
            // 
            this.txtBookTitleUpdate.Location = new System.Drawing.Point(364, 209);
            this.txtBookTitleUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookTitleUpdate.Name = "txtBookTitleUpdate";
            this.txtBookTitleUpdate.Size = new System.Drawing.Size(372, 53);
            this.txtBookTitleUpdate.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(656, 175);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 87);
            this.button1.TabIndex = 42;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picBoxHome
            // 
            this.picBoxHome.Image = global::SA45_Team10a_LibraryManagement.Properties.Resources.PGPLibraryLogo;
            this.picBoxHome.Location = new System.Drawing.Point(13, 13);
            this.picBoxHome.Margin = new System.Windows.Forms.Padding(4);
            this.picBoxHome.Name = "picBoxHome";
            this.picBoxHome.Size = new System.Drawing.Size(254, 217);
            this.picBoxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxHome.TabIndex = 47;
            this.picBoxHome.TabStop = false;
            this.picBoxHome.Click += new System.EventHandler(this.picBoxHome_Click);
            // 
            // gBoxAddBook
            // 
            this.gBoxAddBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gBoxAddBook.Controls.Add(this.cboBoxPublisherAdd);
            this.gBoxAddBook.Controls.Add(this.cboBoxAuthorAdd);
            this.gBoxAddBook.Controls.Add(this.btnCancelAdd);
            this.gBoxAddBook.Controls.Add(this.cboBoxBookTypeAdd);
            this.gBoxAddBook.Controls.Add(this.cboBoxLanguageAdd);
            this.gBoxAddBook.Controls.Add(this.txtQuantityAdd);
            this.gBoxAddBook.Controls.Add(this.lblQuantityAdd);
            this.gBoxAddBook.Controls.Add(this.txtNoteAdd);
            this.gBoxAddBook.Controls.Add(this.lblNoteAdd);
            this.gBoxAddBook.Controls.Add(this.lblBookTypeAdd);
            this.gBoxAddBook.Controls.Add(this.lblISBNAdd);
            this.gBoxAddBook.Controls.Add(this.txtCallNoAdd);
            this.gBoxAddBook.Controls.Add(this.cboBoxSectionAdd);
            this.gBoxAddBook.Controls.Add(this.lblSectionAdd);
            this.gBoxAddBook.Controls.Add(this.lblPublisherAdd);
            this.gBoxAddBook.Controls.Add(this.btnAdd);
            this.gBoxAddBook.Controls.Add(this.txtISBNAdd);
            this.gBoxAddBook.Controls.Add(this.lblCallNoAdd);
            this.gBoxAddBook.Controls.Add(this.lblBookTitleAdd);
            this.gBoxAddBook.Controls.Add(this.lblLanguageAdd);
            this.gBoxAddBook.Controls.Add(this.lblAuthorAdd);
            this.gBoxAddBook.Controls.Add(this.txtBookTitleAdd);
            this.gBoxAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxAddBook.Location = new System.Drawing.Point(530, 377);
            this.gBoxAddBook.Margin = new System.Windows.Forms.Padding(4);
            this.gBoxAddBook.Name = "gBoxAddBook";
            this.gBoxAddBook.Padding = new System.Windows.Forms.Padding(4);
            this.gBoxAddBook.Size = new System.Drawing.Size(760, 903);
            this.gBoxAddBook.TabIndex = 43;
            this.gBoxAddBook.TabStop = false;
            this.gBoxAddBook.Text = "Add New Book";
            // 
            // cboBoxPublisherAdd
            // 
            this.cboBoxPublisherAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxPublisherAdd.FormattingEnabled = true;
            this.cboBoxPublisherAdd.Items.AddRange(new object[] {
            "Gale",
            "CiNii",
            "EBSCO Publishing"});
            this.cboBoxPublisherAdd.Location = new System.Drawing.Point(362, 395);
            this.cboBoxPublisherAdd.Margin = new System.Windows.Forms.Padding(4);
            this.cboBoxPublisherAdd.Name = "cboBoxPublisherAdd";
            this.cboBoxPublisherAdd.Size = new System.Drawing.Size(372, 54);
            this.cboBoxPublisherAdd.TabIndex = 33;
            // 
            // cboBoxAuthorAdd
            // 
            this.cboBoxAuthorAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxAuthorAdd.FormattingEnabled = true;
            this.cboBoxAuthorAdd.Items.AddRange(new object[] {
            "Jin Yong",
            "Jiro Akagawa",
            "Stephen King",
            "JK Rowling",
            "Nicholas Sparks"});
            this.cboBoxAuthorAdd.Location = new System.Drawing.Point(362, 332);
            this.cboBoxAuthorAdd.Margin = new System.Windows.Forms.Padding(4);
            this.cboBoxAuthorAdd.Name = "cboBoxAuthorAdd";
            this.cboBoxAuthorAdd.Size = new System.Drawing.Size(372, 54);
            this.cboBoxAuthorAdd.TabIndex = 32;
            // 
            // btnCancelAdd
            // 
            this.btnCancelAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAdd.Location = new System.Drawing.Point(602, 800);
            this.btnCancelAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelAdd.Name = "btnCancelAdd";
            this.btnCancelAdd.Size = new System.Drawing.Size(132, 66);
            this.btnCancelAdd.TabIndex = 31;
            this.btnCancelAdd.Text = "Cancel";
            this.btnCancelAdd.UseVisualStyleBackColor = true;
            this.btnCancelAdd.Click += new System.EventHandler(this.btnCancelAdd_Click);
            // 
            // cboBoxBookTypeAdd
            // 
            this.cboBoxBookTypeAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxBookTypeAdd.FormattingEnabled = true;
            this.cboBoxBookTypeAdd.Items.AddRange(new object[] {
            "Fantasy",
            "Horrow",
            "Action",
            "Mystery",
            "Romance"});
            this.cboBoxBookTypeAdd.Location = new System.Drawing.Point(362, 206);
            this.cboBoxBookTypeAdd.Margin = new System.Windows.Forms.Padding(4);
            this.cboBoxBookTypeAdd.Name = "cboBoxBookTypeAdd";
            this.cboBoxBookTypeAdd.Size = new System.Drawing.Size(372, 54);
            this.cboBoxBookTypeAdd.TabIndex = 30;
            // 
            // cboBoxLanguageAdd
            // 
            this.cboBoxLanguageAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxLanguageAdd.FormattingEnabled = true;
            this.cboBoxLanguageAdd.Items.AddRange(new object[] {
            "English",
            "Chinese"});
            this.cboBoxLanguageAdd.Location = new System.Drawing.Point(362, 269);
            this.cboBoxLanguageAdd.Margin = new System.Windows.Forms.Padding(4);
            this.cboBoxLanguageAdd.Name = "cboBoxLanguageAdd";
            this.cboBoxLanguageAdd.Size = new System.Drawing.Size(372, 54);
            this.cboBoxLanguageAdd.TabIndex = 29;
            // 
            // txtQuantityAdd
            // 
            this.txtQuantityAdd.Location = new System.Drawing.Point(362, 645);
            this.txtQuantityAdd.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantityAdd.Name = "txtQuantityAdd";
            this.txtQuantityAdd.Size = new System.Drawing.Size(372, 53);
            this.txtQuantityAdd.TabIndex = 27;
            // 
            // lblQuantityAdd
            // 
            this.lblQuantityAdd.AutoSize = true;
            this.lblQuantityAdd.Location = new System.Drawing.Point(16, 659);
            this.lblQuantityAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantityAdd.Name = "lblQuantityAdd";
            this.lblQuantityAdd.Size = new System.Drawing.Size(179, 46);
            this.lblQuantityAdd.TabIndex = 26;
            this.lblQuantityAdd.Text = "Quantity:";
            // 
            // txtNoteAdd
            // 
            this.txtNoteAdd.Location = new System.Drawing.Point(362, 583);
            this.txtNoteAdd.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoteAdd.Name = "txtNoteAdd";
            this.txtNoteAdd.Size = new System.Drawing.Size(372, 53);
            this.txtNoteAdd.TabIndex = 25;
            // 
            // lblNoteAdd
            // 
            this.lblNoteAdd.AutoSize = true;
            this.lblNoteAdd.Location = new System.Drawing.Point(16, 597);
            this.lblNoteAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoteAdd.Name = "lblNoteAdd";
            this.lblNoteAdd.Size = new System.Drawing.Size(136, 46);
            this.lblNoteAdd.TabIndex = 24;
            this.lblNoteAdd.Text = "Notes:";
            // 
            // lblBookTypeAdd
            // 
            this.lblBookTypeAdd.AutoSize = true;
            this.lblBookTypeAdd.Location = new System.Drawing.Point(16, 219);
            this.lblBookTypeAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookTypeAdd.Name = "lblBookTypeAdd";
            this.lblBookTypeAdd.Size = new System.Drawing.Size(212, 46);
            this.lblBookTypeAdd.TabIndex = 23;
            this.lblBookTypeAdd.Text = "BookType:";
            // 
            // lblISBNAdd
            // 
            this.lblISBNAdd.AutoSize = true;
            this.lblISBNAdd.Location = new System.Drawing.Point(16, 154);
            this.lblISBNAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblISBNAdd.Name = "lblISBNAdd";
            this.lblISBNAdd.Size = new System.Drawing.Size(124, 46);
            this.lblISBNAdd.TabIndex = 21;
            this.lblISBNAdd.Text = "ISBN:";
            // 
            // txtCallNoAdd
            // 
            this.txtCallNoAdd.Location = new System.Drawing.Point(362, 521);
            this.txtCallNoAdd.Margin = new System.Windows.Forms.Padding(4);
            this.txtCallNoAdd.Name = "txtCallNoAdd";
            this.txtCallNoAdd.Size = new System.Drawing.Size(372, 53);
            this.txtCallNoAdd.TabIndex = 20;
            // 
            // cboBoxSectionAdd
            // 
            this.cboBoxSectionAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxSectionAdd.FormattingEnabled = true;
            this.cboBoxSectionAdd.Items.AddRange(new object[] {
            "Young Adult",
            "Adult"});
            this.cboBoxSectionAdd.Location = new System.Drawing.Point(362, 458);
            this.cboBoxSectionAdd.Margin = new System.Windows.Forms.Padding(4);
            this.cboBoxSectionAdd.Name = "cboBoxSectionAdd";
            this.cboBoxSectionAdd.Size = new System.Drawing.Size(372, 54);
            this.cboBoxSectionAdd.TabIndex = 18;
            // 
            // lblSectionAdd
            // 
            this.lblSectionAdd.AutoSize = true;
            this.lblSectionAdd.Location = new System.Drawing.Point(16, 471);
            this.lblSectionAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSectionAdd.Name = "lblSectionAdd";
            this.lblSectionAdd.Size = new System.Drawing.Size(166, 46);
            this.lblSectionAdd.TabIndex = 17;
            this.lblSectionAdd.Text = "Section:";
            // 
            // lblPublisherAdd
            // 
            this.lblPublisherAdd.AutoSize = true;
            this.lblPublisherAdd.Location = new System.Drawing.Point(16, 407);
            this.lblPublisherAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPublisherAdd.Name = "lblPublisherAdd";
            this.lblPublisherAdd.Size = new System.Drawing.Size(314, 46);
            this.lblPublisherAdd.TabIndex = 16;
            this.lblPublisherAdd.Text = "Publisher Name:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(24, 800);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(132, 66);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtISBNAdd
            // 
            this.txtISBNAdd.Location = new System.Drawing.Point(362, 144);
            this.txtISBNAdd.Margin = new System.Windows.Forms.Padding(4);
            this.txtISBNAdd.Name = "txtISBNAdd";
            this.txtISBNAdd.Size = new System.Drawing.Size(372, 53);
            this.txtISBNAdd.TabIndex = 13;
            // 
            // lblCallNoAdd
            // 
            this.lblCallNoAdd.AutoSize = true;
            this.lblCallNoAdd.Location = new System.Drawing.Point(16, 533);
            this.lblCallNoAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCallNoAdd.Name = "lblCallNoAdd";
            this.lblCallNoAdd.Size = new System.Drawing.Size(241, 46);
            this.lblCallNoAdd.TabIndex = 9;
            this.lblCallNoAdd.Text = "CallNumber:";
            // 
            // lblBookTitleAdd
            // 
            this.lblBookTitleAdd.AutoSize = true;
            this.lblBookTitleAdd.Location = new System.Drawing.Point(16, 84);
            this.lblBookTitleAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookTitleAdd.Name = "lblBookTitleAdd";
            this.lblBookTitleAdd.Size = new System.Drawing.Size(199, 46);
            this.lblBookTitleAdd.TabIndex = 2;
            this.lblBookTitleAdd.Text = "BookTitle:";
            // 
            // lblLanguageAdd
            // 
            this.lblLanguageAdd.AutoSize = true;
            this.lblLanguageAdd.Location = new System.Drawing.Point(16, 281);
            this.lblLanguageAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLanguageAdd.Name = "lblLanguageAdd";
            this.lblLanguageAdd.Size = new System.Drawing.Size(207, 46);
            this.lblLanguageAdd.TabIndex = 3;
            this.lblLanguageAdd.Text = "Language:";
            // 
            // lblAuthorAdd
            // 
            this.lblAuthorAdd.AutoSize = true;
            this.lblAuthorAdd.Location = new System.Drawing.Point(16, 345);
            this.lblAuthorAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthorAdd.Name = "lblAuthorAdd";
            this.lblAuthorAdd.Size = new System.Drawing.Size(266, 46);
            this.lblAuthorAdd.TabIndex = 4;
            this.lblAuthorAdd.Text = "Author Name:";
            // 
            // txtBookTitleAdd
            // 
            this.txtBookTitleAdd.Location = new System.Drawing.Point(362, 82);
            this.txtBookTitleAdd.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookTitleAdd.Name = "txtBookTitleAdd";
            this.txtBookTitleAdd.Size = new System.Drawing.Size(372, 53);
            this.txtBookTitleAdd.TabIndex = 6;
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(1218, 52);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(172, 32);
            this.lblUser.TabIndex = 46;
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
            this.lblLogOut.TabIndex = 45;
            this.lblLogOut.Text = "Log Out";
            this.lblLogOut.Click += new System.EventHandler(this.lblLogOut_Click);
            // 
            // bookListingBindingSource
            // 
            this.bookListingBindingSource.DataSource = typeof(SA45_Team10a_LibraryManagement.BookListing);
            // 
            // frmManageBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1888, 992);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picBoxHome);
            this.Controls.Add(this.gBoxAddBook);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblLogOut);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmManageBook";
            this.Text = "ManageBook";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmManageBook_Load);
            this.panel1.ResumeLayout(false);
            this.gBoxUpdateBook.ResumeLayout(false);
            this.gBoxUpdateBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHome)).EndInit();
            this.gBoxAddBook.ResumeLayout(false);
            this.gBoxAddBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookListingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cboBoxPublisherAdd;
        private System.Windows.Forms.ComboBox cboBoxAuthorAdd;
        private System.Windows.Forms.Button btnCancelAdd;
        private System.Windows.Forms.ComboBox cboBoxBookTypeAdd;
        private System.Windows.Forms.ComboBox cboBoxLanguageAdd;
        private System.Windows.Forms.TextBox txtQuantityAdd;
        private System.Windows.Forms.Label lblQuantityAdd;
        private System.Windows.Forms.TextBox txtNoteAdd;
        private System.Windows.Forms.Label lblNoteAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gBoxUpdateBook;
        private System.Windows.Forms.ComboBox cboBoxPublisherUpdate;
        private System.Windows.Forms.ComboBox cboBoxAuthorUpdate;
        private System.Windows.Forms.Label lblPublisherUpdate;
        private System.Windows.Forms.Label lblAuthorUpdate;
        private System.Windows.Forms.Button btnCancelUpdate;
        private System.Windows.Forms.ComboBox cboBoxBookTypeUpdate;
        private System.Windows.Forms.ComboBox cboBoxLanguageUpdate;
        private System.Windows.Forms.TextBox txtQuantityUpdate;
        private System.Windows.Forms.Label lblQuantityUpdate;
        private System.Windows.Forms.TextBox txtNoteUpdate;
        private System.Windows.Forms.Label lblNoteUpdate;
        private System.Windows.Forms.Label lblBookTypeUpdate;
        private System.Windows.Forms.Label lblISBNUpdate;
        private System.Windows.Forms.TextBox txtCallNoUpdate;
        private System.Windows.Forms.ComboBox cboBoxSectionUpdate;
        private System.Windows.Forms.Label lblSectionUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtISBNUpdate;
        private System.Windows.Forms.TextBox txtBookNameUpdate;
        private System.Windows.Forms.Label lblBookIDUpdate;
        private System.Windows.Forms.Label lblCallNoUpdate;
        private System.Windows.Forms.Label lblBookTitleUpdate;
        private System.Windows.Forms.Label lblLanguageUpdate;
        private System.Windows.Forms.TextBox txtBookTitleUpdate;
        private System.Windows.Forms.BindingSource bookListingBindingSource;
        private System.Windows.Forms.Label lblBookTypeAdd;
        private System.Windows.Forms.Label lblISBNAdd;
        private System.Windows.Forms.TextBox txtCallNoAdd;
        private System.Windows.Forms.ComboBox cboBoxSectionAdd;
        private System.Windows.Forms.Label lblSectionAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picBoxHome;
        private System.Windows.Forms.Label lblPublisherAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtISBNAdd;
        private System.Windows.Forms.Label lblCallNoAdd;
        private System.Windows.Forms.Label lblBookTitleAdd;
        private System.Windows.Forms.Label lblLanguageAdd;
        private System.Windows.Forms.Label lblAuthorAdd;
        private System.Windows.Forms.GroupBox gBoxAddBook;
        private System.Windows.Forms.TextBox txtBookTitleAdd;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblLogOut;
        private System.Windows.Forms.Label label3;
    }
}