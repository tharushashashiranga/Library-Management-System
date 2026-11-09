namespace LibraryManagementSystem.Forms
{
    partial class FrmReturnBook
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Button btnRefresh;

        private System.Windows.Forms.Panel pnlReturnCard;
        private System.Windows.Forms.Label lblReturnTitle;
        private System.Windows.Forms.Label lblSelectedIssue;
        private System.Windows.Forms.Label lblSelectedIssueValue;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.Label lblBookValue;
        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.Label lblMemberValue;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Label lblIssueDateValue;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label lblDueDateValue;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.Button btnCalculateFine;
        private System.Windows.Forms.Panel pnlFineBox;
        private System.Windows.Forms.Label lblLateDays;
        private System.Windows.Forms.Label lblLateDaysValue;
        private System.Windows.Forms.Label lblFine;
        private System.Windows.Forms.Label lblFineValue;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnClear;

        private System.Windows.Forms.Panel pnlGridCard;
        private System.Windows.Forms.Label lblGridTitle;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvActiveIssues;

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

            this.pnlReturnCard = new System.Windows.Forms.Panel();
            this.lblReturnTitle = new System.Windows.Forms.Label();
            this.lblSelectedIssue = new System.Windows.Forms.Label();
            this.lblSelectedIssueValue = new System.Windows.Forms.Label();
            this.lblBook = new System.Windows.Forms.Label();
            this.lblBookValue = new System.Windows.Forms.Label();
            this.lblMember = new System.Windows.Forms.Label();
            this.lblMemberValue = new System.Windows.Forms.Label();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.lblIssueDateValue = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblDueDateValue = new System.Windows.Forms.Label();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.btnCalculateFine = new System.Windows.Forms.Button();
            this.pnlFineBox = new System.Windows.Forms.Panel();
            this.lblLateDays = new System.Windows.Forms.Label();
            this.lblLateDaysValue = new System.Windows.Forms.Label();
            this.lblFine = new System.Windows.Forms.Label();
            this.lblFineValue = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();

            this.pnlGridCard = new System.Windows.Forms.Panel();
            this.lblGridTitle = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvActiveIssues = new System.Windows.Forms.DataGridView();

            this.pnlMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlReturnCard.SuspendLayout();
            this.pnlFineBox.SuspendLayout();
            this.pnlGridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveIssues)).BeginInit();
            this.SuspendLayout();

            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.pnlMain.Controls.Add(this.pnlGridCard);
            this.pnlMain.Controls.Add(this.pnlReturnCard);
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
            this.lblTitle.Size = new System.Drawing.Size(158, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Return Book";

            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblSubtitle.Location = new System.Drawing.Point(25, 48);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(492, 17);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Return issued books, update availability and calculate overdue fines automatically.";

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
            // pnlReturnCard
            // 
            this.pnlReturnCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlReturnCard.BackColor = System.Drawing.Color.White;
            this.pnlReturnCard.Controls.Add(this.btnClear);
            this.pnlReturnCard.Controls.Add(this.btnReturn);
            this.pnlReturnCard.Controls.Add(this.pnlFineBox);
            this.pnlReturnCard.Controls.Add(this.btnCalculateFine);
            this.pnlReturnCard.Controls.Add(this.dtpReturnDate);
            this.pnlReturnCard.Controls.Add(this.lblReturnDate);
            this.pnlReturnCard.Controls.Add(this.lblDueDateValue);
            this.pnlReturnCard.Controls.Add(this.lblDueDate);
            this.pnlReturnCard.Controls.Add(this.lblIssueDateValue);
            this.pnlReturnCard.Controls.Add(this.lblIssueDate);
            this.pnlReturnCard.Controls.Add(this.lblMemberValue);
            this.pnlReturnCard.Controls.Add(this.lblMember);
            this.pnlReturnCard.Controls.Add(this.lblBookValue);
            this.pnlReturnCard.Controls.Add(this.lblBook);
            this.pnlReturnCard.Controls.Add(this.lblSelectedIssueValue);
            this.pnlReturnCard.Controls.Add(this.lblSelectedIssue);
            this.pnlReturnCard.Controls.Add(this.lblReturnTitle);
            this.pnlReturnCard.Location = new System.Drawing.Point(20, 120);
            this.pnlReturnCard.Name = "pnlReturnCard";
            this.pnlReturnCard.Size = new System.Drawing.Size(360, 495);
            this.pnlReturnCard.TabIndex = 1;

            // 
            // lblReturnTitle
            // 
            this.lblReturnTitle.AutoSize = true;
            this.lblReturnTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblReturnTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblReturnTitle.Location = new System.Drawing.Point(20, 14);
            this.lblReturnTitle.Name = "lblReturnTitle";
            this.lblReturnTitle.Size = new System.Drawing.Size(130, 25);
            this.lblReturnTitle.TabIndex = 0;
            this.lblReturnTitle.Text = "Return Details";

            // 
            // lblSelectedIssue
            // 
            this.lblSelectedIssue.AutoSize = true;
            this.lblSelectedIssue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSelectedIssue.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblSelectedIssue.Location = new System.Drawing.Point(22, 55);
            this.lblSelectedIssue.Name = "lblSelectedIssue";
            this.lblSelectedIssue.Size = new System.Drawing.Size(90, 15);
            this.lblSelectedIssue.TabIndex = 1;
            this.lblSelectedIssue.Text = "Selected Issue";

            // 
            // lblSelectedIssueValue
            // 
            this.lblSelectedIssueValue.AutoSize = true;
            this.lblSelectedIssueValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSelectedIssueValue.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblSelectedIssueValue.Location = new System.Drawing.Point(25, 75);
            this.lblSelectedIssueValue.Name = "lblSelectedIssueValue";
            this.lblSelectedIssueValue.Size = new System.Drawing.Size(14, 19);
            this.lblSelectedIssueValue.TabIndex = 2;
            this.lblSelectedIssueValue.Text = "-";

            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBook.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblBook.Location = new System.Drawing.Point(22, 105);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(34, 15);
            this.lblBook.TabIndex = 3;
            this.lblBook.Text = "Book";

            // 
            // lblBookValue
            // 
            this.lblBookValue.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblBookValue.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblBookValue.Location = new System.Drawing.Point(25, 126);
            this.lblBookValue.Name = "lblBookValue";
            this.lblBookValue.Size = new System.Drawing.Size(310, 38);
            this.lblBookValue.TabIndex = 4;
            this.lblBookValue.Text = "No book selected.";

            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMember.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblMember.Location = new System.Drawing.Point(22, 172);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(54, 15);
            this.lblMember.TabIndex = 5;
            this.lblMember.Text = "Member";

            // 
            // lblMemberValue
            // 
            this.lblMemberValue.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblMemberValue.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblMemberValue.Location = new System.Drawing.Point(25, 193);
            this.lblMemberValue.Name = "lblMemberValue";
            this.lblMemberValue.Size = new System.Drawing.Size(310, 38);
            this.lblMemberValue.TabIndex = 6;
            this.lblMemberValue.Text = "No member selected.";

            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIssueDate.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblIssueDate.Location = new System.Drawing.Point(22, 242);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(64, 15);
            this.lblIssueDate.TabIndex = 7;
            this.lblIssueDate.Text = "Issue Date";

            // 
            // lblIssueDateValue
            // 
            this.lblIssueDateValue.AutoSize = true;
            this.lblIssueDateValue.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblIssueDateValue.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblIssueDateValue.Location = new System.Drawing.Point(25, 263);
            this.lblIssueDateValue.Name = "lblIssueDateValue";
            this.lblIssueDateValue.Size = new System.Drawing.Size(13, 17);
            this.lblIssueDateValue.TabIndex = 8;
            this.lblIssueDateValue.Text = "-";

            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDueDate.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblDueDate.Location = new System.Drawing.Point(185, 242);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(57, 15);
            this.lblDueDate.TabIndex = 9;
            this.lblDueDate.Text = "Due Date";

            // 
            // lblDueDateValue
            // 
            this.lblDueDateValue.AutoSize = true;
            this.lblDueDateValue.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDueDateValue.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.lblDueDateValue.Location = new System.Drawing.Point(188, 263);
            this.lblDueDateValue.Name = "lblDueDateValue";
            this.lblDueDateValue.Size = new System.Drawing.Size(13, 17);
            this.lblDueDateValue.TabIndex = 10;
            this.lblDueDateValue.Text = "-";

            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblReturnDate.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblReturnDate.Location = new System.Drawing.Point(22, 295);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(73, 15);
            this.lblReturnDate.TabIndex = 11;
            this.lblReturnDate.Text = "Return Date";

            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturnDate.Location = new System.Drawing.Point(25, 317);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(145, 24);
            this.dtpReturnDate.TabIndex = 0;
            this.dtpReturnDate.ValueChanged += new System.EventHandler(this.dtpReturnDate_ValueChanged);

            // 
            // btnCalculateFine
            // 
            this.btnCalculateFine.BackColor = System.Drawing.Color.FromArgb(249, 115, 22);
            this.btnCalculateFine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculateFine.FlatAppearance.BorderSize = 0;
            this.btnCalculateFine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculateFine.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCalculateFine.ForeColor = System.Drawing.Color.White;
            this.btnCalculateFine.Location = new System.Drawing.Point(188, 315);
            this.btnCalculateFine.Name = "btnCalculateFine";
            this.btnCalculateFine.Size = new System.Drawing.Size(147, 30);
            this.btnCalculateFine.TabIndex = 1;
            this.btnCalculateFine.Text = "Calculate Fine";
            this.btnCalculateFine.UseVisualStyleBackColor = false;
            this.btnCalculateFine.Click += new System.EventHandler(this.btnCalculateFine_Click);

            // 
            // pnlFineBox
            // 
            this.pnlFineBox.BackColor = System.Drawing.Color.FromArgb(255, 247, 237);
            this.pnlFineBox.Controls.Add(this.lblFineValue);
            this.pnlFineBox.Controls.Add(this.lblFine);
            this.pnlFineBox.Controls.Add(this.lblLateDaysValue);
            this.pnlFineBox.Controls.Add(this.lblLateDays);
            this.pnlFineBox.Location = new System.Drawing.Point(25, 360);
            this.pnlFineBox.Name = "pnlFineBox";
            this.pnlFineBox.Size = new System.Drawing.Size(310, 65);
            this.pnlFineBox.TabIndex = 14;

            // 
            // lblLateDays
            // 
            this.lblLateDays.AutoSize = true;
            this.lblLateDays.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLateDays.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblLateDays.Location = new System.Drawing.Point(14, 10);
            this.lblLateDays.Name = "lblLateDays";
            this.lblLateDays.Size = new System.Drawing.Size(62, 15);
            this.lblLateDays.TabIndex = 0;
            this.lblLateDays.Text = "Late Days";

            // 
            // lblLateDaysValue
            // 
            this.lblLateDaysValue.AutoSize = true;
            this.lblLateDaysValue.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblLateDaysValue.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.lblLateDaysValue.Location = new System.Drawing.Point(13, 27);
            this.lblLateDaysValue.Name = "lblLateDaysValue";
            this.lblLateDaysValue.Size = new System.Drawing.Size(26, 30);
            this.lblLateDaysValue.TabIndex = 1;
            this.lblLateDaysValue.Text = "0";

            // 
            // lblFine
            // 
            this.lblFine.AutoSize = true;
            this.lblFine.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFine.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblFine.Location = new System.Drawing.Point(150, 10);
            this.lblFine.Name = "lblFine";
            this.lblFine.Size = new System.Drawing.Size(78, 15);
            this.lblFine.TabIndex = 2;
            this.lblFine.Text = "Fine Amount";

            // 
            // lblFineValue
            // 
            this.lblFineValue.AutoSize = true;
            this.lblFineValue.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblFineValue.ForeColor = System.Drawing.Color.FromArgb(249, 115, 22);
            this.lblFineValue.Location = new System.Drawing.Point(148, 27);
            this.lblFineValue.Name = "lblFineValue";
            this.lblFineValue.Size = new System.Drawing.Size(92, 30);
            this.lblFineValue.TabIndex = 3;
            this.lblFineValue.Text = "Rs. 0.00";

            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.Enabled = false;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(25, 445);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(145, 36);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Return Book";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);

            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnClear.Location = new System.Drawing.Point(190, 445);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(145, 36);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // 
            // pnlGridCard
            // 
            this.pnlGridCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGridCard.BackColor = System.Drawing.Color.White;
            this.pnlGridCard.Controls.Add(this.dgvActiveIssues);
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
            this.lblGridTitle.Size = new System.Drawing.Size(213, 25);
            this.lblGridTitle.TabIndex = 0;
            this.lblGridTitle.Text = "Active Issued Book Records";

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
            // dgvActiveIssues
            // 
            this.dgvActiveIssues.AllowUserToAddRows = false;
            this.dgvActiveIssues.AllowUserToDeleteRows = false;
            this.dgvActiveIssues.AllowUserToResizeRows = false;
            this.dgvActiveIssues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvActiveIssues.BackgroundColor = System.Drawing.Color.White;
            this.dgvActiveIssues.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvActiveIssues.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvActiveIssues.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActiveIssues.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvActiveIssues.ColumnHeadersHeight = 38;
            this.dgvActiveIssues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvActiveIssues.EnableHeadersVisualStyles = false;
            this.dgvActiveIssues.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dgvActiveIssues.Location = new System.Drawing.Point(20, 60);
            this.dgvActiveIssues.MultiSelect = false;
            this.dgvActiveIssues.Name = "dgvActiveIssues";
            this.dgvActiveIssues.ReadOnly = true;
            this.dgvActiveIssues.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.dgvActiveIssues.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvActiveIssues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActiveIssues.Size = new System.Drawing.Size(570, 415);
            this.dgvActiveIssues.TabIndex = 2;
            this.dgvActiveIssues.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActiveIssues_CellClick);

            // 
            // FrmReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.ClientSize = new System.Drawing.Size(1030, 635);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReturnBook";
            this.Text = "Return Book";
            this.Load += new System.EventHandler(this.FrmReturnBook_Load);

            this.pnlMain.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlReturnCard.ResumeLayout(false);
            this.pnlReturnCard.PerformLayout();
            this.pnlFineBox.ResumeLayout(false);
            this.pnlFineBox.PerformLayout();
            this.pnlGridCard.ResumeLayout(false);
            this.pnlGridCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveIssues)).EndInit();
            this.ResumeLayout(false);
        }
    }
}