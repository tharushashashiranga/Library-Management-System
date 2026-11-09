namespace LibraryManagementSystem.Forms
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblLogoIcon;
        private System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.Label lblSystemSubTitle;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.Button btnIssueBook;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.Label lblUserIcon;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlUserBox;

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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.btnIssueBook = new System.Windows.Forms.Button();
            this.btnMembers = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblSystemSubTitle = new System.Windows.Forms.Label();
            this.lblSystemName = new System.Windows.Forms.Label();
            this.lblLogoIcon = new System.Windows.Forms.Label();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlUserBox = new System.Windows.Forms.Panel();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserIcon = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();

            this.pnlSidebar.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            this.pnlUserBox.SuspendLayout();
            this.SuspendLayout();

            // pnlSidebar
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.btnReports);
            this.pnlSidebar.Controls.Add(this.btnReturnBook);
            this.pnlSidebar.Controls.Add(this.btnIssueBook);
            this.pnlSidebar.Controls.Add(this.btnMembers);
            this.pnlSidebar.Controls.Add(this.btnBooks);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Controls.Add(this.pnlLogo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(230, 720);
            this.pnlSidebar.TabIndex = 0;

            // pnlLogo
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.pnlLogo.Controls.Add(this.lblSystemSubTitle);
            this.pnlLogo.Controls.Add(this.lblSystemName);
            this.pnlLogo.Controls.Add(this.lblLogoIcon);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(230, 135);
            this.pnlLogo.TabIndex = 0;

            // lblLogoIcon
            this.lblLogoIcon.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblLogoIcon.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblLogoIcon.ForeColor = System.Drawing.Color.White;
            this.lblLogoIcon.Location = new System.Drawing.Point(22, 22);
            this.lblLogoIcon.Name = "lblLogoIcon";
            this.lblLogoIcon.Size = new System.Drawing.Size(48, 42);
            this.lblLogoIcon.TabIndex = 0;
            this.lblLogoIcon.Text = "LM";
            this.lblLogoIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblSystemName
            this.lblSystemName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblSystemName.ForeColor = System.Drawing.Color.White;
            this.lblSystemName.Location = new System.Drawing.Point(22, 72);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(185, 30);
            this.lblSystemName.TabIndex = 1;
            this.lblSystemName.Text = "Library";

            // lblSystemSubTitle
            this.lblSystemSubTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSystemSubTitle.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblSystemSubTitle.Location = new System.Drawing.Point(24, 105);
            this.lblSystemSubTitle.Name = "lblSystemSubTitle";
            this.lblSystemSubTitle.Size = new System.Drawing.Size(185, 20);
            this.lblSystemSubTitle.TabIndex = 2;
            this.lblSystemSubTitle.Text = "ICT Project - ITE1942";

            // btnDashboard
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnDashboard.Location = new System.Drawing.Point(0, 135);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(230, 52);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);

            // btnBooks
            this.btnBooks.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.btnBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBooks.FlatAppearance.BorderSize = 0;
            this.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooks.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBooks.ForeColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnBooks.Location = new System.Drawing.Point(0, 187);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnBooks.Size = new System.Drawing.Size(230, 52);
            this.btnBooks.TabIndex = 2;
            this.btnBooks.Text = "Book Management";
            this.btnBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBooks.UseVisualStyleBackColor = false;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);

            // btnMembers
            this.btnMembers.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.btnMembers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMembers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMembers.FlatAppearance.BorderSize = 0;
            this.btnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMembers.ForeColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnMembers.Location = new System.Drawing.Point(0, 239);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnMembers.Size = new System.Drawing.Size(230, 52);
            this.btnMembers.TabIndex = 3;
            this.btnMembers.Text = "Members / Students";
            this.btnMembers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMembers.UseVisualStyleBackColor = false;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);

            // btnIssueBook
            this.btnIssueBook.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.btnIssueBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIssueBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIssueBook.FlatAppearance.BorderSize = 0;
            this.btnIssueBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueBook.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnIssueBook.ForeColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnIssueBook.Location = new System.Drawing.Point(0, 291);
            this.btnIssueBook.Name = "btnIssueBook";
            this.btnIssueBook.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnIssueBook.Size = new System.Drawing.Size(230, 52);
            this.btnIssueBook.TabIndex = 4;
            this.btnIssueBook.Text = "Issue Book";
            this.btnIssueBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssueBook.UseVisualStyleBackColor = false;
            this.btnIssueBook.Click += new System.EventHandler(this.btnIssueBook_Click);

            // btnReturnBook
            this.btnReturnBook.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.btnReturnBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturnBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReturnBook.FlatAppearance.BorderSize = 0;
            this.btnReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnBook.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnReturnBook.ForeColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnReturnBook.Location = new System.Drawing.Point(0, 343);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnReturnBook.Size = new System.Drawing.Size(230, 52);
            this.btnReturnBook.TabIndex = 5;
            this.btnReturnBook.Text = "Return Book";
            this.btnReturnBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnBook.UseVisualStyleBackColor = false;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);

            // btnReports
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnReports.ForeColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnReports.Location = new System.Drawing.Point(0, 395);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnReports.Size = new System.Drawing.Size(230, 52);
            this.btnReports.TabIndex = 6;
            this.btnReports.Text = "Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);

            // btnLogout
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(127, 29, 29);
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 668);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(230, 52);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // pnlTopBar
            this.pnlTopBar.BackColor = System.Drawing.Color.White;
            this.pnlTopBar.Controls.Add(this.btnMinimize);
            this.pnlTopBar.Controls.Add(this.btnExit);
            this.pnlTopBar.Controls.Add(this.pnlUserBox);
            this.pnlTopBar.Controls.Add(this.lblDateTime);
            this.pnlTopBar.Controls.Add(this.lblPageTitle);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(230, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(1050, 64);
            this.pnlTopBar.TabIndex = 1;
            this.pnlTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTopBar_MouseDown);

            // lblPageTitle
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblPageTitle.Location = new System.Drawing.Point(28, 8);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(136, 32);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "Dashboard";

            // lblDateTime
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblDateTime.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblDateTime.Location = new System.Drawing.Point(31, 40);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(151, 15);
            this.lblDateTime.TabIndex = 1;
            this.lblDateTime.Text = "Monday, 01 January 2026";

            // pnlUserBox
            this.pnlUserBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUserBox.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.pnlUserBox.Controls.Add(this.lblUserRole);
            this.pnlUserBox.Controls.Add(this.lblUserName);
            this.pnlUserBox.Controls.Add(this.lblUserIcon);
            this.pnlUserBox.Location = new System.Drawing.Point(760, 9);
            this.pnlUserBox.Name = "pnlUserBox";
            this.pnlUserBox.Size = new System.Drawing.Size(205, 46);
            this.pnlUserBox.TabIndex = 3;

            // lblUserIcon
            this.lblUserIcon.AutoSize = true;
            this.lblUserIcon.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblUserIcon.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblUserIcon.Location = new System.Drawing.Point(13, 9);
            this.lblUserIcon.Name = "lblUserIcon";
            this.lblUserIcon.Size = new System.Drawing.Size(22, 28);
            this.lblUserIcon.TabIndex = 0;
            this.lblUserIcon.Text = "●";

            // lblUserName
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblUserName.Location = new System.Drawing.Point(47, 7);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(126, 15);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "System Administrator";

            // lblUserRole
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblUserRole.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblUserRole.Location = new System.Drawing.Point(48, 25);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(42, 13);
            this.lblUserRole.TabIndex = 2;
            this.lblUserRole.Text = "Admin";

            // btnMinimize
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.btnMinimize.Location = new System.Drawing.Point(976, 15);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(32, 32);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);

            // btnExit
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1012, 15);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 32);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // pnlContent
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(230, 64);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(0);
            this.pnlContent.Size = new System.Drawing.Size(1050, 656);
            this.pnlContent.TabIndex = 2;

            // FrmMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.pnlSidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);

            this.pnlSidebar.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlUserBox.ResumeLayout(false);
            this.pnlUserBox.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}