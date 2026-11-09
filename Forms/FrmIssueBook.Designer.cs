namespace LibraryManagementSystem.Forms
{
    partial class FrmIssueBook
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Button btnRefresh;

        private System.Windows.Forms.Panel pnlIssueCard;
        private System.Windows.Forms.Label lblIssueTitle;
        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.ComboBox cmbMember;
        private System.Windows.Forms.Label lblMemberInfo;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.ComboBox cmbBook;
        private System.Windows.Forms.Label lblBookInfo;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlInfoBox;
        private System.Windows.Forms.Label lblInfoTitle;
        private System.Windows.Forms.Label lblInfoText;

        private System.Windows.Forms.Panel pnlGridCard;
        private System.Windows.Forms.Label lblGridTitle;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvIssuedRecords;

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

            this.pnlIssueCard = new System.Windows.Forms.Panel();
            this.lblIssueTitle = new System.Windows.Forms.Label();
            this.lblMember = new System.Windows.Forms.Label();
            this.cmbMember = new System.Windows.Forms.ComboBox();
            this.lblMemberInfo = new System.Windows.Forms.Label();
            this.lblBook = new System.Windows.Forms.Label();
            this.cmbBook = new System.Windows.Forms.ComboBox();
            this.lblBookInfo = new System.Windows.Forms.Label();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlInfoBox = new System.Windows.Forms.Panel();
            this.lblInfoTitle = new System.Windows.Forms.Label();
            this.lblInfoText = new System.Windows.Forms.Label();

            this.pnlGridCard = new System.Windows.Forms.Panel();
            this.lblGridTitle = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvIssuedRecords = new System.Windows.Forms.DataGridView();

            this.pnlMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlIssueCard.SuspendLayout();
            this.pnlInfoBox.SuspendLayout();
            this.pnlGridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssuedRecords)).BeginInit();
            this.SuspendLayout();

            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.pnlMain.Controls.Add(this.pnlGridCard);
            this.pnlMain.Controls.Add(this.pnlIssueCard);
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(20);
            this.pnlMain.Size = new System.Drawing.Size(1030, 635);
            this.pnlMain.TabIndex = 0;

            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.btnRefresh);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Location = new System.Drawing.Point(20, 20);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(990, 80);
            this.pnlHeader.TabIndex = 0;

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblTitle.Location = new System.Drawing.Point(22, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(139, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Issue Book";

            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblSubtitle.Location = new System.Drawing.Point(25, 48);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(462, 17);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Issue available books to active members and automatically update book stock.";

            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(842, 22);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(125, 36);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // 
            // pnlIssueCard
            // 
            this.pnlIssueCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlIssueCard.BackColor = System.Drawing.Color.White;
            this.pnlIssueCard.Controls.Add(this.pnlInfoBox);
            this.pnlIssueCard.Controls.Add(this.btnClear);
            this.pnlIssueCard.Controls.Add(this.btnIssue);
            this.pnlIssueCard.Controls.Add(this.dtpDueDate);
            this.pnlIssueCard.Controls.Add(this.lblDueDate);
            this.pnlIssueCard.Controls.Add(this.dtpIssueDate);
            this.pnlIssueCard.Controls.Add(this.lblIssueDate);
            this.pnlIssueCard.Controls.Add(this.lblBookInfo);
            this.pnlIssueCard.Controls.Add(this.cmbBook);
            this.pnlIssueCard.Controls.Add(this.lblBook);
            this.pnlIssueCard.Controls.Add(this.lblMemberInfo);
            this.pnlIssueCard.Controls.Add(this.cmbMember);
            this.pnlIssueCard.Controls.Add(this.lblMember);
            this.pnlIssueCard.Controls.Add(this.lblIssueTitle);
            this.pnlIssueCard.Location = new System.Drawing.Point(20, 120);
            this.pnlIssueCard.Name = "pnlIssueCard";
            this.pnlIssueCard.Size = new System.Drawing.Size(360, 495);
            this.pnlIssueCard.TabIndex = 1;

            // 
            // lblIssueTitle
            // 
            this.lblIssueTitle.AutoSize = true;
            this.lblIssueTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblIssueTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblIssueTitle.Location = new System.Drawing.Point(20, 14);
            this.lblIssueTitle.Name = "lblIssueTitle";
            this.lblIssueTitle.Size = new System.Drawing.Size(118, 25);
            this.lblIssueTitle.TabIndex = 0;
            this.lblIssueTitle.Text = "Issue Details";

            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMember.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblMember.Location = new System.Drawing.Point(22, 58);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(103, 15);
            this.lblMember.TabIndex = 1;
            this.lblMember.Text = "Select Member";

            // 
            // cmbMember
            // 
            this.cmbMember.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.cmbMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMember.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMember.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.cmbMember.FormattingEnabled = true;
            this.cmbMember.Location = new System.Drawing.Point(25, 80);
            this.cmbMember.Name = "cmbMember";
            this.cmbMember.Size = new System.Drawing.Size(310, 25);
            this.cmbMember.TabIndex = 0;
            this.cmbMember.SelectedIndexChanged += new System.EventHandler(this.cmbMember_SelectedIndexChanged);

            // 
            // lblMemberInfo
            // 
            this.lblMemberInfo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblMemberInfo.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblMemberInfo.Location = new System.Drawing.Point(25, 112);
            this.lblMemberInfo.Name = "lblMemberInfo";
            this.lblMemberInfo.Size = new System.Drawing.Size(310, 38);
            this.lblMemberInfo.TabIndex = 3;
            this.lblMemberInfo.Text = "No member selected.";

            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBook.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblBook.Location = new System.Drawing.Point(22, 158);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(129, 15);
            this.lblBook.TabIndex = 4;
            this.lblBook.Text = "Select Available Book";

            // 
            // cmbBook
            // 
            this.cmbBook.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.cmbBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBook.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbBook.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.cmbBook.FormattingEnabled = true;
            this.cmbBook.Location = new System.Drawing.Point(25, 180);
            this.cmbBook.Name = "cmbBook";
            this.cmbBook.Size = new System.Drawing.Size(310, 25);
            this.cmbBook.TabIndex = 1;
            this.cmbBook.SelectedIndexChanged += new System.EventHandler(this.cmbBook_SelectedIndexChanged);

            // 
            // lblBookInfo
            // 
            this.lblBookInfo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblBookInfo.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblBookInfo.Location = new System.Drawing.Point(25, 212);
            this.lblBookInfo.Name = "lblBookInfo";
            this.lblBookInfo.Size = new System.Drawing.Size(310, 52);
            this.lblBookInfo.TabIndex = 6;
            this.lblBookInfo.Text = "No book selected.";

            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIssueDate.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblIssueDate.Location = new System.Drawing.Point(22, 276);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(64, 15);
            this.lblIssueDate.TabIndex = 7;
            this.lblIssueDate.Text = "Issue Date";

            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIssueDate.Location = new System.Drawing.Point(25, 298);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(145, 24);
            this.dtpIssueDate.TabIndex = 2;
            this.dtpIssueDate.ValueChanged += new System.EventHandler(this.dtpIssueDate_ValueChanged);

            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDueDate.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblDueDate.Location = new System.Drawing.Point(185, 276);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(57, 15);
            this.lblDueDate.TabIndex = 9;
            this.lblDueDate.Text = "Due Date";

            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDate.Location = new System.Drawing.Point(188, 298);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(147, 24);
            this.dtpDueDate.TabIndex = 3;

            // 
            // btnIssue
            // 
            this.btnIssue.BackColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.btnIssue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIssue.FlatAppearance.BorderSize = 0;
            this.btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnIssue.ForeColor = System.Drawing.Color.White;
            this.btnIssue.Location = new System.Drawing.Point(25, 342);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(145, 36);
            this.btnIssue.TabIndex = 4;
            this.btnIssue.Text = "Issue Book";
            this.btnIssue.UseVisualStyleBackColor = false;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);

            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnClear.Location = new System.Drawing.Point(190, 342);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(145, 36);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // 
            // pnlInfoBox
            // 
            this.pnlInfoBox.BackColor = System.Drawing.Color.FromArgb(239, 246, 255);
            this.pnlInfoBox.Controls.Add(this.lblInfoText);
            this.pnlInfoBox.Controls.Add(this.lblInfoTitle);
            this.pnlInfoBox.Location = new System.Drawing.Point(25, 398);
            this.pnlInfoBox.Name = "pnlInfoBox";
            this.pnlInfoBox.Size = new System.Drawing.Size(310, 75);
            this.pnlInfoBox.TabIndex = 13;

            // 
            // lblInfoTitle
            // 
            this.lblInfoTitle.AutoSize = true;
            this.lblInfoTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblInfoTitle.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblInfoTitle.Location = new System.Drawing.Point(12, 10);
            this.lblInfoTitle.Name = "lblInfoTitle";
            this.lblInfoTitle.Size = new System.Drawing.Size(86, 15);
            this.lblInfoTitle.TabIndex = 0;
            this.lblInfoTitle.Text = "Issue Rule";

            // 
            // lblInfoText
            // 
            this.lblInfoText.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblInfoText.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblInfoText.Location = new System.Drawing.Point(12, 30);
            this.lblInfoText.Name = "lblInfoText";
            this.lblInfoText.Size = new System.Drawing.Size(285, 38);
            this.lblInfoText.TabIndex = 1;
            this.lblInfoText.Text = "Default borrowing period is 14 days. Return module will calculate fines for overdue books.";

            // 
            // pnlGridCard
            // 
            this.pnlGridCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGridCard.BackColor = System.Drawing.Color.White;
            this.pnlGridCard.Controls.Add(this.dgvIssuedRecords);
            this.pnlGridCard.Controls.Add(this.txtSearch);
            this.pnlGridCard.Controls.Add(this.lblSearch);
            this.pnlGridCard.Controls.Add(this.lblGridTitle);
            this.pnlGridCard.Location = new System.Drawing.Point(400, 120);
            this.pnlGridCard.Name = "pnlGridCard";
            this.pnlGridCard.Size = new System.Drawing.Size(610, 495);
            this.pnlGridCard.TabIndex = 2;

            // 
            // lblGridTitle
            // 
            this.lblGridTitle.AutoSize = true;
            this.lblGridTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblGridTitle.Location = new System.Drawing.Point(20, 14);
            this.lblGridTitle.Name = "lblGridTitle";
            this.lblGridTitle.Size = new System.Drawing.Size(186, 25);
            this.lblGridTitle.TabIndex = 0;
            this.lblGridTitle.Text = "Currently Issued Books";

            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblSearch.Location = new System.Drawing.Point(330, 20);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(43, 15);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search";

            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.txtSearch.Location = new System.Drawing.Point(379, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(210, 25);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);

            // 
            // dgvIssuedRecords
            // 
            this.dgvIssuedRecords.AllowUserToAddRows = false;
            this.dgvIssuedRecords.AllowUserToDeleteRows = false;
            this.dgvIssuedRecords.AllowUserToResizeRows = false;
            this.dgvIssuedRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvIssuedRecords.BackgroundColor = System.Drawing.Color.White;
            this.dgvIssuedRecords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvIssuedRecords.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvIssuedRecords.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIssuedRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIssuedRecords.ColumnHeadersHeight = 38;
            this.dgvIssuedRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvIssuedRecords.EnableHeadersVisualStyles = false;
            this.dgvIssuedRecords.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dgvIssuedRecords.Location = new System.Drawing.Point(20, 60);
            this.dgvIssuedRecords.MultiSelect = false;
            this.dgvIssuedRecords.Name = "dgvIssuedRecords";
            this.dgvIssuedRecords.ReadOnly = true;
            this.dgvIssuedRecords.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.dgvIssuedRecords.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvIssuedRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIssuedRecords.Size = new System.Drawing.Size(570, 415);
            this.dgvIssuedRecords.TabIndex = 2;
            this.dgvIssuedRecords.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIssuedRecords_CellClick);

            // 
            // FrmIssueBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.ClientSize = new System.Drawing.Size(1030, 635);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmIssueBook";
            this.Text = "Issue Book";
            this.Load += new System.EventHandler(this.FrmIssueBook_Load);

            this.pnlMain.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlIssueCard.ResumeLayout(false);
            this.pnlIssueCard.PerformLayout();
            this.pnlInfoBox.ResumeLayout(false);
            this.pnlInfoBox.PerformLayout();
            this.pnlGridCard.ResumeLayout(false);
            this.pnlGridCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssuedRecords)).EndInit();
            this.ResumeLayout(false);
        }
    }
}