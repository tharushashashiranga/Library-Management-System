namespace LibraryManagementSystem.Forms
{
    partial class FrmBooks
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Button btnRefresh;

        private System.Windows.Forms.Panel pnlFormCard;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblBookCode;
        private System.Windows.Forms.TextBox txtBookCode;
        private System.Windows.Forms.Button btnGenerateCode;
        private System.Windows.Forms.Label lblTitleInput;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblShelf;
        private System.Windows.Forms.TextBox txtShelfLocation;
        private System.Windows.Forms.Label lblTotalQty;
        private System.Windows.Forms.NumericUpDown nudTotalQty;
        private System.Windows.Forms.Label lblAvailableQty;
        private System.Windows.Forms.NumericUpDown nudAvailableQty;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;

        private System.Windows.Forms.Panel pnlGridCard;
        private System.Windows.Forms.Label lblGridTitle;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvBooks;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();

            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();

            this.pnlFormCard = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblBookCode = new System.Windows.Forms.Label();
            this.txtBookCode = new System.Windows.Forms.TextBox();
            this.btnGenerateCode = new System.Windows.Forms.Button();
            this.lblTitleInput = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblShelf = new System.Windows.Forms.Label();
            this.txtShelfLocation = new System.Windows.Forms.TextBox();
            this.lblTotalQty = new System.Windows.Forms.Label();
            this.nudTotalQty = new System.Windows.Forms.NumericUpDown();
            this.lblAvailableQty = new System.Windows.Forms.Label();
            this.nudAvailableQty = new System.Windows.Forms.NumericUpDown();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();

            this.pnlGridCard = new System.Windows.Forms.Panel();
            this.lblGridTitle = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvBooks = new System.Windows.Forms.DataGridView();

            this.pnlMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlFormCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAvailableQty)).BeginInit();
            this.pnlGridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();

            // pnlMain
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.pnlMain.Controls.Add(this.pnlGridCard);
            this.pnlMain.Controls.Add(this.pnlFormCard);
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(10);
            this.pnlMain.Size = new System.Drawing.Size(1050, 656);
            this.pnlMain.TabIndex = 0;

            // pnlHeader
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.btnRefresh);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Location = new System.Drawing.Point(10, 10);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1030, 56);
            this.pnlHeader.TabIndex = 0;

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblTitle.Location = new System.Drawing.Point(18, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(201, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Book Management";

            // lblSubtitle
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblSubtitle.Location = new System.Drawing.Point(21, 35);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(339, 15);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Add, update, delete and search library book records with availability.";

            // btnRefresh
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(898, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(112, 32);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // pnlFormCard
            this.pnlFormCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlFormCard.BackColor = System.Drawing.Color.White;
            this.pnlFormCard.Controls.Add(this.btnClear);
            this.pnlFormCard.Controls.Add(this.btnDelete);
            this.pnlFormCard.Controls.Add(this.btnUpdate);
            this.pnlFormCard.Controls.Add(this.btnAdd);
            this.pnlFormCard.Controls.Add(this.cmbStatus);
            this.pnlFormCard.Controls.Add(this.lblStatus);
            this.pnlFormCard.Controls.Add(this.nudAvailableQty);
            this.pnlFormCard.Controls.Add(this.lblAvailableQty);
            this.pnlFormCard.Controls.Add(this.nudTotalQty);
            this.pnlFormCard.Controls.Add(this.lblTotalQty);
            this.pnlFormCard.Controls.Add(this.txtShelfLocation);
            this.pnlFormCard.Controls.Add(this.lblShelf);
            this.pnlFormCard.Controls.Add(this.txtISBN);
            this.pnlFormCard.Controls.Add(this.lblISBN);
            this.pnlFormCard.Controls.Add(this.txtPublisher);
            this.pnlFormCard.Controls.Add(this.lblPublisher);
            this.pnlFormCard.Controls.Add(this.cmbCategory);
            this.pnlFormCard.Controls.Add(this.lblCategory);
            this.pnlFormCard.Controls.Add(this.txtAuthor);
            this.pnlFormCard.Controls.Add(this.lblAuthor);
            this.pnlFormCard.Controls.Add(this.txtTitle);
            this.pnlFormCard.Controls.Add(this.lblTitleInput);
            this.pnlFormCard.Controls.Add(this.btnGenerateCode);
            this.pnlFormCard.Controls.Add(this.txtBookCode);
            this.pnlFormCard.Controls.Add(this.lblBookCode);
            this.pnlFormCard.Controls.Add(this.lblFormTitle);
            this.pnlFormCard.Location = new System.Drawing.Point(10, 78);
            this.pnlFormCard.Name = "pnlFormCard";
            this.pnlFormCard.Size = new System.Drawing.Size(370, 568);
            this.pnlFormCard.TabIndex = 1;

            // lblFormTitle
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblFormTitle.Location = new System.Drawing.Point(20, 10);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(112, 23);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "Book Details";

            // lblBookCode
            this.lblBookCode.AutoSize = true;
            this.lblBookCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBookCode.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblBookCode.Location = new System.Drawing.Point(22, 43);
            this.lblBookCode.Name = "lblBookCode";
            this.lblBookCode.Size = new System.Drawing.Size(67, 15);
            this.lblBookCode.TabIndex = 1;
            this.lblBookCode.Text = "Book Code";

            // txtBookCode
            this.txtBookCode.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.txtBookCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBookCode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBookCode.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.txtBookCode.Location = new System.Drawing.Point(25, 62);
            this.txtBookCode.Name = "txtBookCode";
            this.txtBookCode.Size = new System.Drawing.Size(220, 25);
            this.txtBookCode.TabIndex = 0;

            // btnGenerateCode
            this.btnGenerateCode.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnGenerateCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateCode.FlatAppearance.BorderSize = 0;
            this.btnGenerateCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateCode.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnGenerateCode.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnGenerateCode.Location = new System.Drawing.Point(255, 62);
            this.btnGenerateCode.Name = "btnGenerateCode";
            this.btnGenerateCode.Size = new System.Drawing.Size(90, 25);
            this.btnGenerateCode.TabIndex = 1;
            this.btnGenerateCode.Text = "Generate";
            this.btnGenerateCode.UseVisualStyleBackColor = false;
            this.btnGenerateCode.Click += new System.EventHandler(this.btnGenerateCode_Click);

            // lblTitleInput
            this.lblTitleInput.AutoSize = true;
            this.lblTitleInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitleInput.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblTitleInput.Location = new System.Drawing.Point(22, 94);
            this.lblTitleInput.Name = "lblTitleInput";
            this.lblTitleInput.Size = new System.Drawing.Size(31, 15);
            this.lblTitleInput.TabIndex = 4;
            this.lblTitleInput.Text = "Title";

            // txtTitle
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.txtTitle.Location = new System.Drawing.Point(25, 113);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(320, 25);
            this.txtTitle.TabIndex = 2;

            // lblAuthor
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAuthor.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblAuthor.Location = new System.Drawing.Point(22, 145);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(46, 15);
            this.lblAuthor.TabIndex = 6;
            this.lblAuthor.Text = "Author";

            // txtAuthor
            this.txtAuthor.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.txtAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAuthor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAuthor.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.txtAuthor.Location = new System.Drawing.Point(25, 164);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(320, 25);
            this.txtAuthor.TabIndex = 3;

            // lblCategory
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblCategory.Location = new System.Drawing.Point(22, 196);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(56, 15);
            this.lblCategory.TabIndex = 8;
            this.lblCategory.Text = "Category";

            // cmbCategory
            this.cmbCategory.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategory.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Programming",
            "Database",
            "Networking",
            "Software Engineering",
            "Web Development",
            "Information Systems",
            "Mathematics",
            "General"});
            this.cmbCategory.Location = new System.Drawing.Point(25, 215);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(320, 25);
            this.cmbCategory.TabIndex = 4;

            // lblPublisher
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPublisher.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblPublisher.Location = new System.Drawing.Point(22, 247);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(60, 15);
            this.lblPublisher.TabIndex = 10;
            this.lblPublisher.Text = "Publisher";

            // txtPublisher
            this.txtPublisher.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.txtPublisher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPublisher.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPublisher.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.txtPublisher.Location = new System.Drawing.Point(25, 266);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(320, 25);
            this.txtPublisher.TabIndex = 5;

            // lblISBN
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblISBN.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblISBN.Location = new System.Drawing.Point(22, 298);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(34, 15);
            this.lblISBN.TabIndex = 12;
            this.lblISBN.Text = "ISBN";

            // txtISBN
            this.txtISBN.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.txtISBN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtISBN.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtISBN.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.txtISBN.Location = new System.Drawing.Point(25, 317);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(150, 25);
            this.txtISBN.TabIndex = 6;

            // lblShelf
            this.lblShelf.AutoSize = true;
            this.lblShelf.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblShelf.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblShelf.Location = new System.Drawing.Point(190, 298);
            this.lblShelf.Name = "lblShelf";
            this.lblShelf.Size = new System.Drawing.Size(84, 15);
            this.lblShelf.TabIndex = 14;
            this.lblShelf.Text = "Shelf Location";

            // txtShelfLocation
            this.txtShelfLocation.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.txtShelfLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtShelfLocation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtShelfLocation.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.txtShelfLocation.Location = new System.Drawing.Point(193, 317);
            this.txtShelfLocation.Name = "txtShelfLocation";
            this.txtShelfLocation.Size = new System.Drawing.Size(152, 25);
            this.txtShelfLocation.TabIndex = 7;

            // lblTotalQty
            this.lblTotalQty.AutoSize = true;
            this.lblTotalQty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalQty.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblTotalQty.Location = new System.Drawing.Point(22, 350);
            this.lblTotalQty.Name = "lblTotalQty";
            this.lblTotalQty.Size = new System.Drawing.Size(84, 15);
            this.lblTotalQty.TabIndex = 16;
            this.lblTotalQty.Text = "Total Quantity";

            // nudTotalQty
            this.nudTotalQty.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.nudTotalQty.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudTotalQty.Location = new System.Drawing.Point(25, 370);
            this.nudTotalQty.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.nudTotalQty.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudTotalQty.Name = "nudTotalQty";
            this.nudTotalQty.Size = new System.Drawing.Size(95, 25);
            this.nudTotalQty.TabIndex = 8;
            this.nudTotalQty.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudTotalQty.ValueChanged += new System.EventHandler(this.nudTotalQty_ValueChanged);

            // lblAvailableQty
            this.lblAvailableQty.AutoSize = true;
            this.lblAvailableQty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAvailableQty.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblAvailableQty.Location = new System.Drawing.Point(135, 350);
            this.lblAvailableQty.Name = "lblAvailableQty";
            this.lblAvailableQty.Size = new System.Drawing.Size(105, 15);
            this.lblAvailableQty.TabIndex = 18;
            this.lblAvailableQty.Text = "Available Quantity";

            // nudAvailableQty
            this.nudAvailableQty.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.nudAvailableQty.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudAvailableQty.Location = new System.Drawing.Point(138, 370);
            this.nudAvailableQty.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.nudAvailableQty.Name = "nudAvailableQty";
            this.nudAvailableQty.Size = new System.Drawing.Size(95, 25);
            this.nudAvailableQty.TabIndex = 9;
            this.nudAvailableQty.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudAvailableQty.ValueChanged += new System.EventHandler(this.nudAvailableQty_ValueChanged);

            // lblStatus
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblStatus.Location = new System.Drawing.Point(250, 350);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(41, 15);
            this.lblStatus.TabIndex = 20;
            this.lblStatus.Text = "Status";

            // cmbStatus
            this.cmbStatus.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Enabled = false;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbStatus.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] { "Available", "Not Available" });
            this.cmbStatus.Location = new System.Drawing.Point(253, 370);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(92, 23);
            this.cmbStatus.TabIndex = 10;

            // btnAdd
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(25, 418);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 34);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add Book";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // btnUpdate
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(195, 418);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 34);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update Book";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // btnDelete
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(25, 462);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 34);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete Book";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // btnClear
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnClear.Location = new System.Drawing.Point(195, 462);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 34);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // pnlGridCard
            this.pnlGridCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGridCard.BackColor = System.Drawing.Color.White;
            this.pnlGridCard.Controls.Add(this.dgvBooks);
            this.pnlGridCard.Controls.Add(this.txtSearch);
            this.pnlGridCard.Controls.Add(this.lblSearch);
            this.pnlGridCard.Controls.Add(this.lblGridTitle);
            this.pnlGridCard.Location = new System.Drawing.Point(390, 78);
            this.pnlGridCard.Name = "pnlGridCard";
            this.pnlGridCard.Size = new System.Drawing.Size(650, 568);
            this.pnlGridCard.TabIndex = 2;

            // lblGridTitle
            this.lblGridTitle.AutoSize = true;
            this.lblGridTitle.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold);
            this.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblGridTitle.Location = new System.Drawing.Point(20, 14);
            this.lblGridTitle.Name = "lblGridTitle";
            this.lblGridTitle.Size = new System.Drawing.Size(118, 23);
            this.lblGridTitle.TabIndex = 0;
            this.lblGridTitle.Text = "Book Records";

            // lblSearch
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblSearch.Location = new System.Drawing.Point(358, 20);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(43, 15);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search";

            // txtSearch
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.txtSearch.Location = new System.Drawing.Point(407, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(220, 25);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);

            // dgvBooks
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.AllowUserToResizeRows = false;
            this.dgvBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBooks.BackgroundColor = System.Drawing.Color.White;
            this.dgvBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBooks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBooks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBooks.ColumnHeadersHeight = 42;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBooks.EnableHeadersVisualStyles = false;
            this.dgvBooks.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dgvBooks.Location = new System.Drawing.Point(20, 58);
            this.dgvBooks.MultiSelect = false;
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.dgvBooks.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBooks.RowTemplate.Height = 34;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(610, 490);
            this.dgvBooks.TabIndex = 2;
            this.dgvBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellClick);

            // FrmBooks
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.ClientSize = new System.Drawing.Size(1050, 656);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBooks";
            this.Text = "Book Management";
            this.Load += new System.EventHandler(this.FrmBooks_Load);

            this.pnlMain.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFormCard.ResumeLayout(false);
            this.pnlFormCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAvailableQty)).EndInit();
            this.pnlGridCard.ResumeLayout(false);
            this.pnlGridCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);
        }
    }
}