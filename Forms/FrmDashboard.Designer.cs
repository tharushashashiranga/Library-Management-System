namespace LibraryManagementSystem.Forms
{
    partial class FrmDashboard
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Button btnRefresh;

        private System.Windows.Forms.Panel pnlCardTotalBooks;
        private System.Windows.Forms.Label lblTotalBooksTitle;
        private System.Windows.Forms.Label lblTotalBooksValue;
        private System.Windows.Forms.Label lblTotalBooksIcon;

        private System.Windows.Forms.Panel pnlCardAvailableBooks;
        private System.Windows.Forms.Label lblAvailableBooksTitle;
        private System.Windows.Forms.Label lblAvailableBooksValue;
        private System.Windows.Forms.Label lblAvailableBooksIcon;

        private System.Windows.Forms.Panel pnlCardMembers;
        private System.Windows.Forms.Label lblMembersTitle;
        private System.Windows.Forms.Label lblMembersValue;
        private System.Windows.Forms.Label lblMembersIcon;

        private System.Windows.Forms.Panel pnlCardIssuedBooks;
        private System.Windows.Forms.Label lblIssuedBooksTitle;
        private System.Windows.Forms.Label lblIssuedBooksValue;
        private System.Windows.Forms.Label lblIssuedBooksIcon;

        private System.Windows.Forms.Panel pnlCardOverdueBooks;
        private System.Windows.Forms.Label lblOverdueBooksTitle;
        private System.Windows.Forms.Label lblOverdueBooksValue;
        private System.Windows.Forms.Label lblOverdueBooksIcon;

        private System.Windows.Forms.Panel pnlCardFines;
        private System.Windows.Forms.Label lblTotalFinesTitle;
        private System.Windows.Forms.Label lblTotalFinesValue;
        private System.Windows.Forms.Label lblTotalFinesIcon;

        private System.Windows.Forms.Panel pnlRecentIssues;
        private System.Windows.Forms.Label lblRecentIssuesTitle;
        private System.Windows.Forms.DataGridView dgvRecentIssues;

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

            this.pnlCardTotalBooks = new System.Windows.Forms.Panel();
            this.lblTotalBooksTitle = new System.Windows.Forms.Label();
            this.lblTotalBooksValue = new System.Windows.Forms.Label();
            this.lblTotalBooksIcon = new System.Windows.Forms.Label();

            this.pnlCardAvailableBooks = new System.Windows.Forms.Panel();
            this.lblAvailableBooksTitle = new System.Windows.Forms.Label();
            this.lblAvailableBooksValue = new System.Windows.Forms.Label();
            this.lblAvailableBooksIcon = new System.Windows.Forms.Label();

            this.pnlCardMembers = new System.Windows.Forms.Panel();
            this.lblMembersTitle = new System.Windows.Forms.Label();
            this.lblMembersValue = new System.Windows.Forms.Label();
            this.lblMembersIcon = new System.Windows.Forms.Label();

            this.pnlCardIssuedBooks = new System.Windows.Forms.Panel();
            this.lblIssuedBooksTitle = new System.Windows.Forms.Label();
            this.lblIssuedBooksValue = new System.Windows.Forms.Label();
            this.lblIssuedBooksIcon = new System.Windows.Forms.Label();

            this.pnlCardOverdueBooks = new System.Windows.Forms.Panel();
            this.lblOverdueBooksTitle = new System.Windows.Forms.Label();
            this.lblOverdueBooksValue = new System.Windows.Forms.Label();
            this.lblOverdueBooksIcon = new System.Windows.Forms.Label();

            this.pnlCardFines = new System.Windows.Forms.Panel();
            this.lblTotalFinesTitle = new System.Windows.Forms.Label();
            this.lblTotalFinesValue = new System.Windows.Forms.Label();
            this.lblTotalFinesIcon = new System.Windows.Forms.Label();

            this.pnlRecentIssues = new System.Windows.Forms.Panel();
            this.lblRecentIssuesTitle = new System.Windows.Forms.Label();
            this.dgvRecentIssues = new System.Windows.Forms.DataGridView();

            this.pnlMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlCardTotalBooks.SuspendLayout();
            this.pnlCardAvailableBooks.SuspendLayout();
            this.pnlCardMembers.SuspendLayout();
            this.pnlCardIssuedBooks.SuspendLayout();
            this.pnlCardOverdueBooks.SuspendLayout();
            this.pnlCardFines.SuspendLayout();
            this.pnlRecentIssues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentIssues)).BeginInit();
            this.SuspendLayout();

            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.pnlMain.Controls.Add(this.pnlRecentIssues);
            this.pnlMain.Controls.Add(this.pnlCardFines);
            this.pnlMain.Controls.Add(this.pnlCardOverdueBooks);
            this.pnlMain.Controls.Add(this.pnlCardIssuedBooks);
            this.pnlMain.Controls.Add(this.pnlCardMembers);
            this.pnlMain.Controls.Add(this.pnlCardAvailableBooks);
            this.pnlMain.Controls.Add(this.pnlCardTotalBooks);
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
            this.pnlHeader.Size = new System.Drawing.Size(990, 85);
            this.pnlHeader.TabIndex = 0;

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblTitle.Location = new System.Drawing.Point(24, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(206, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "System Overview";

            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblSubtitle.Location = new System.Drawing.Point(27, 51);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(441, 17);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Quick summary of books, members, issued books, overdue items and fines.";

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
            this.btnRefresh.Location = new System.Drawing.Point(838, 24);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(125, 38);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // 
            // pnlCardTotalBooks
            // 
            this.pnlCardTotalBooks.BackColor = System.Drawing.Color.White;
            this.pnlCardTotalBooks.Controls.Add(this.lblTotalBooksIcon);
            this.pnlCardTotalBooks.Controls.Add(this.lblTotalBooksValue);
            this.pnlCardTotalBooks.Controls.Add(this.lblTotalBooksTitle);
            this.pnlCardTotalBooks.Location = new System.Drawing.Point(20, 125);
            this.pnlCardTotalBooks.Name = "pnlCardTotalBooks";
            this.pnlCardTotalBooks.Size = new System.Drawing.Size(305, 105);
            this.pnlCardTotalBooks.TabIndex = 1;

            // 
            // lblTotalBooksTitle
            // 
            this.lblTotalBooksTitle.AutoSize = true;
            this.lblTotalBooksTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalBooksTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblTotalBooksTitle.Location = new System.Drawing.Point(20, 18);
            this.lblTotalBooksTitle.Name = "lblTotalBooksTitle";
            this.lblTotalBooksTitle.Size = new System.Drawing.Size(86, 19);
            this.lblTotalBooksTitle.TabIndex = 0;
            this.lblTotalBooksTitle.Text = "Total Books";

            // 
            // lblTotalBooksValue
            // 
            this.lblTotalBooksValue.AutoSize = true;
            this.lblTotalBooksValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTotalBooksValue.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblTotalBooksValue.Location = new System.Drawing.Point(18, 42);
            this.lblTotalBooksValue.Name = "lblTotalBooksValue";
            this.lblTotalBooksValue.Size = new System.Drawing.Size(38, 45);
            this.lblTotalBooksValue.TabIndex = 1;
            this.lblTotalBooksValue.Text = "0";

            // 
            // lblTotalBooksIcon
            // 
            this.lblTotalBooksIcon.AutoSize = true;
            this.lblTotalBooksIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 28F);
            this.lblTotalBooksIcon.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblTotalBooksIcon.Location = new System.Drawing.Point(225, 27);
            this.lblTotalBooksIcon.Name = "lblTotalBooksIcon";
            this.lblTotalBooksIcon.Size = new System.Drawing.Size(56, 50);
            this.lblTotalBooksIcon.TabIndex = 2;
            this.lblTotalBooksIcon.Text = "📚";

            // 
            // pnlCardAvailableBooks
            // 
            this.pnlCardAvailableBooks.BackColor = System.Drawing.Color.White;
            this.pnlCardAvailableBooks.Controls.Add(this.lblAvailableBooksIcon);
            this.pnlCardAvailableBooks.Controls.Add(this.lblAvailableBooksValue);
            this.pnlCardAvailableBooks.Controls.Add(this.lblAvailableBooksTitle);
            this.pnlCardAvailableBooks.Location = new System.Drawing.Point(362, 125);
            this.pnlCardAvailableBooks.Name = "pnlCardAvailableBooks";
            this.pnlCardAvailableBooks.Size = new System.Drawing.Size(305, 105);
            this.pnlCardAvailableBooks.TabIndex = 2;

            // 
            // lblAvailableBooksTitle
            // 
            this.lblAvailableBooksTitle.AutoSize = true;
            this.lblAvailableBooksTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAvailableBooksTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblAvailableBooksTitle.Location = new System.Drawing.Point(20, 18);
            this.lblAvailableBooksTitle.Name = "lblAvailableBooksTitle";
            this.lblAvailableBooksTitle.Size = new System.Drawing.Size(115, 19);
            this.lblAvailableBooksTitle.TabIndex = 0;
            this.lblAvailableBooksTitle.Text = "Available Books";

            // 
            // lblAvailableBooksValue
            // 
            this.lblAvailableBooksValue.AutoSize = true;
            this.lblAvailableBooksValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblAvailableBooksValue.ForeColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.lblAvailableBooksValue.Location = new System.Drawing.Point(18, 42);
            this.lblAvailableBooksValue.Name = "lblAvailableBooksValue";
            this.lblAvailableBooksValue.Size = new System.Drawing.Size(38, 45);
            this.lblAvailableBooksValue.TabIndex = 1;
            this.lblAvailableBooksValue.Text = "0";

            // 
            // lblAvailableBooksIcon
            // 
            this.lblAvailableBooksIcon.AutoSize = true;
            this.lblAvailableBooksIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 28F);
            this.lblAvailableBooksIcon.ForeColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.lblAvailableBooksIcon.Location = new System.Drawing.Point(225, 27);
            this.lblAvailableBooksIcon.Name = "lblAvailableBooksIcon";
            this.lblAvailableBooksIcon.Size = new System.Drawing.Size(56, 50);
            this.lblAvailableBooksIcon.TabIndex = 2;
            this.lblAvailableBooksIcon.Text = "✅";

            // 
            // pnlCardMembers
            // 
            this.pnlCardMembers.BackColor = System.Drawing.Color.White;
            this.pnlCardMembers.Controls.Add(this.lblMembersIcon);
            this.pnlCardMembers.Controls.Add(this.lblMembersValue);
            this.pnlCardMembers.Controls.Add(this.lblMembersTitle);
            this.pnlCardMembers.Location = new System.Drawing.Point(704, 125);
            this.pnlCardMembers.Name = "pnlCardMembers";
            this.pnlCardMembers.Size = new System.Drawing.Size(306, 105);
            this.pnlCardMembers.TabIndex = 3;

            // 
            // lblMembersTitle
            // 
            this.lblMembersTitle.AutoSize = true;
            this.lblMembersTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMembersTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblMembersTitle.Location = new System.Drawing.Point(20, 18);
            this.lblMembersTitle.Name = "lblMembersTitle";
            this.lblMembersTitle.Size = new System.Drawing.Size(117, 19);
            this.lblMembersTitle.TabIndex = 0;
            this.lblMembersTitle.Text = "Active Members";

            // 
            // lblMembersValue
            // 
            this.lblMembersValue.AutoSize = true;
            this.lblMembersValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblMembersValue.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblMembersValue.Location = new System.Drawing.Point(18, 42);
            this.lblMembersValue.Name = "lblMembersValue";
            this.lblMembersValue.Size = new System.Drawing.Size(38, 45);
            this.lblMembersValue.TabIndex = 1;
            this.lblMembersValue.Text = "0";

            // 
            // lblMembersIcon
            // 
            this.lblMembersIcon.AutoSize = true;
            this.lblMembersIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 28F);
            this.lblMembersIcon.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblMembersIcon.Location = new System.Drawing.Point(225, 27);
            this.lblMembersIcon.Name = "lblMembersIcon";
            this.lblMembersIcon.Size = new System.Drawing.Size(56, 50);
            this.lblMembersIcon.TabIndex = 2;
            this.lblMembersIcon.Text = "👥";

            // 
            // pnlCardIssuedBooks
            // 
            this.pnlCardIssuedBooks.BackColor = System.Drawing.Color.White;
            this.pnlCardIssuedBooks.Controls.Add(this.lblIssuedBooksIcon);
            this.pnlCardIssuedBooks.Controls.Add(this.lblIssuedBooksValue);
            this.pnlCardIssuedBooks.Controls.Add(this.lblIssuedBooksTitle);
            this.pnlCardIssuedBooks.Location = new System.Drawing.Point(20, 250);
            this.pnlCardIssuedBooks.Name = "pnlCardIssuedBooks";
            this.pnlCardIssuedBooks.Size = new System.Drawing.Size(305, 105);
            this.pnlCardIssuedBooks.TabIndex = 4;

            // 
            // lblIssuedBooksTitle
            // 
            this.lblIssuedBooksTitle.AutoSize = true;
            this.lblIssuedBooksTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblIssuedBooksTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblIssuedBooksTitle.Location = new System.Drawing.Point(20, 18);
            this.lblIssuedBooksTitle.Name = "lblIssuedBooksTitle";
            this.lblIssuedBooksTitle.Size = new System.Drawing.Size(96, 19);
            this.lblIssuedBooksTitle.TabIndex = 0;
            this.lblIssuedBooksTitle.Text = "Issued Books";

            // 
            // lblIssuedBooksValue
            // 
            this.lblIssuedBooksValue.AutoSize = true;
            this.lblIssuedBooksValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblIssuedBooksValue.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblIssuedBooksValue.Location = new System.Drawing.Point(18, 42);
            this.lblIssuedBooksValue.Name = "lblIssuedBooksValue";
            this.lblIssuedBooksValue.Size = new System.Drawing.Size(38, 45);
            this.lblIssuedBooksValue.TabIndex = 1;
            this.lblIssuedBooksValue.Text = "0";

            // 
            // lblIssuedBooksIcon
            // 
            this.lblIssuedBooksIcon.AutoSize = true;
            this.lblIssuedBooksIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 28F);
            this.lblIssuedBooksIcon.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblIssuedBooksIcon.Location = new System.Drawing.Point(225, 27);
            this.lblIssuedBooksIcon.Name = "lblIssuedBooksIcon";
            this.lblIssuedBooksIcon.Size = new System.Drawing.Size(56, 50);
            this.lblIssuedBooksIcon.TabIndex = 2;
            this.lblIssuedBooksIcon.Text = "📖";

            // 
            // pnlCardOverdueBooks
            // 
            this.pnlCardOverdueBooks.BackColor = System.Drawing.Color.White;
            this.pnlCardOverdueBooks.Controls.Add(this.lblOverdueBooksIcon);
            this.pnlCardOverdueBooks.Controls.Add(this.lblOverdueBooksValue);
            this.pnlCardOverdueBooks.Controls.Add(this.lblOverdueBooksTitle);
            this.pnlCardOverdueBooks.Location = new System.Drawing.Point(362, 250);
            this.pnlCardOverdueBooks.Name = "pnlCardOverdueBooks";
            this.pnlCardOverdueBooks.Size = new System.Drawing.Size(305, 105);
            this.pnlCardOverdueBooks.TabIndex = 5;

            // 
            // lblOverdueBooksTitle
            // 
            this.lblOverdueBooksTitle.AutoSize = true;
            this.lblOverdueBooksTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblOverdueBooksTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblOverdueBooksTitle.Location = new System.Drawing.Point(20, 18);
            this.lblOverdueBooksTitle.Name = "lblOverdueBooksTitle";
            this.lblOverdueBooksTitle.Size = new System.Drawing.Size(107, 19);
            this.lblOverdueBooksTitle.TabIndex = 0;
            this.lblOverdueBooksTitle.Text = "Overdue Books";

            // 
            // lblOverdueBooksValue
            // 
            this.lblOverdueBooksValue.AutoSize = true;
            this.lblOverdueBooksValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblOverdueBooksValue.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.lblOverdueBooksValue.Location = new System.Drawing.Point(18, 42);
            this.lblOverdueBooksValue.Name = "lblOverdueBooksValue";
            this.lblOverdueBooksValue.Size = new System.Drawing.Size(38, 45);
            this.lblOverdueBooksValue.TabIndex = 1;
            this.lblOverdueBooksValue.Text = "0";

            // 
            // lblOverdueBooksIcon
            // 
            this.lblOverdueBooksIcon.AutoSize = true;
            this.lblOverdueBooksIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 28F);
            this.lblOverdueBooksIcon.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.lblOverdueBooksIcon.Location = new System.Drawing.Point(225, 27);
            this.lblOverdueBooksIcon.Name = "lblOverdueBooksIcon";
            this.lblOverdueBooksIcon.Size = new System.Drawing.Size(56, 50);
            this.lblOverdueBooksIcon.TabIndex = 2;
            this.lblOverdueBooksIcon.Text = "⚠️";

            // 
            // pnlCardFines
            // 
            this.pnlCardFines.BackColor = System.Drawing.Color.White;
            this.pnlCardFines.Controls.Add(this.lblTotalFinesIcon);
            this.pnlCardFines.Controls.Add(this.lblTotalFinesValue);
            this.pnlCardFines.Controls.Add(this.lblTotalFinesTitle);
            this.pnlCardFines.Location = new System.Drawing.Point(704, 250);
            this.pnlCardFines.Name = "pnlCardFines";
            this.pnlCardFines.Size = new System.Drawing.Size(306, 105);
            this.pnlCardFines.TabIndex = 6;

            // 
            // lblTotalFinesTitle
            // 
            this.lblTotalFinesTitle.AutoSize = true;
            this.lblTotalFinesTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalFinesTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblTotalFinesTitle.Location = new System.Drawing.Point(20, 18);
            this.lblTotalFinesTitle.Name = "lblTotalFinesTitle";
            this.lblTotalFinesTitle.Size = new System.Drawing.Size(82, 19);
            this.lblTotalFinesTitle.TabIndex = 0;
            this.lblTotalFinesTitle.Text = "Total Fines";

            // 
            // lblTotalFinesValue
            // 
            this.lblTotalFinesValue.AutoSize = true;
            this.lblTotalFinesValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalFinesValue.ForeColor = System.Drawing.Color.FromArgb(249, 115, 22);
            this.lblTotalFinesValue.Location = new System.Drawing.Point(18, 47);
            this.lblTotalFinesValue.Name = "lblTotalFinesValue";
            this.lblTotalFinesValue.Size = new System.Drawing.Size(109, 37);
            this.lblTotalFinesValue.TabIndex = 1;
            this.lblTotalFinesValue.Text = "Rs. 0.00";

            // 
            // lblTotalFinesIcon
            // 
            this.lblTotalFinesIcon.AutoSize = true;
            this.lblTotalFinesIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 28F);
            this.lblTotalFinesIcon.ForeColor = System.Drawing.Color.FromArgb(249, 115, 22);
            this.lblTotalFinesIcon.Location = new System.Drawing.Point(225, 27);
            this.lblTotalFinesIcon.Name = "lblTotalFinesIcon";
            this.lblTotalFinesIcon.Size = new System.Drawing.Size(56, 50);
            this.lblTotalFinesIcon.TabIndex = 2;
            this.lblTotalFinesIcon.Text = "💰";

            // 
            // pnlRecentIssues
            // 
            this.pnlRecentIssues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRecentIssues.BackColor = System.Drawing.Color.White;
            this.pnlRecentIssues.Controls.Add(this.dgvRecentIssues);
            this.pnlRecentIssues.Controls.Add(this.lblRecentIssuesTitle);
            this.pnlRecentIssues.Location = new System.Drawing.Point(20, 375);
            this.pnlRecentIssues.Name = "pnlRecentIssues";
            this.pnlRecentIssues.Size = new System.Drawing.Size(990, 240);
            this.pnlRecentIssues.TabIndex = 7;

            // 
            // lblRecentIssuesTitle
            // 
            this.lblRecentIssuesTitle.AutoSize = true;
            this.lblRecentIssuesTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblRecentIssuesTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblRecentIssuesTitle.Location = new System.Drawing.Point(20, 14);
            this.lblRecentIssuesTitle.Name = "lblRecentIssuesTitle";
            this.lblRecentIssuesTitle.Size = new System.Drawing.Size(185, 25);
            this.lblRecentIssuesTitle.TabIndex = 0;
            this.lblRecentIssuesTitle.Text = "Recent Issue Records";

            // 
            // dgvRecentIssues
            // 
            this.dgvRecentIssues.AllowUserToAddRows = false;
            this.dgvRecentIssues.AllowUserToDeleteRows = false;
            this.dgvRecentIssues.AllowUserToResizeRows = false;
            this.dgvRecentIssues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRecentIssues.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecentIssues.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecentIssues.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRecentIssues.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecentIssues.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRecentIssues.ColumnHeadersHeight = 38;
            this.dgvRecentIssues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRecentIssues.EnableHeadersVisualStyles = false;
            this.dgvRecentIssues.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dgvRecentIssues.Location = new System.Drawing.Point(20, 52);
            this.dgvRecentIssues.MultiSelect = false;
            this.dgvRecentIssues.Name = "dgvRecentIssues";
            this.dgvRecentIssues.ReadOnly = true;
            this.dgvRecentIssues.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.dgvRecentIssues.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRecentIssues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecentIssues.Size = new System.Drawing.Size(950, 170);
            this.dgvRecentIssues.TabIndex = 1;

            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.ClientSize = new System.Drawing.Size(1030, 635);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.FrmDashboard_Load);

            this.pnlMain.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlCardTotalBooks.ResumeLayout(false);
            this.pnlCardTotalBooks.PerformLayout();
            this.pnlCardAvailableBooks.ResumeLayout(false);
            this.pnlCardAvailableBooks.PerformLayout();
            this.pnlCardMembers.ResumeLayout(false);
            this.pnlCardMembers.PerformLayout();
            this.pnlCardIssuedBooks.ResumeLayout(false);
            this.pnlCardIssuedBooks.PerformLayout();
            this.pnlCardOverdueBooks.ResumeLayout(false);
            this.pnlCardOverdueBooks.PerformLayout();
            this.pnlCardFines.ResumeLayout(false);
            this.pnlCardFines.PerformLayout();
            this.pnlRecentIssues.ResumeLayout(false);
            this.pnlRecentIssues.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentIssues)).EndInit();
            this.ResumeLayout(false);
        }
    }
}