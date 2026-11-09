namespace LibraryManagementSystem.Forms
{
    partial class FrmReports
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Button btnRefresh;

        private System.Windows.Forms.Panel pnlFilterCard;
        private System.Windows.Forms.Label lblReportType;
        private System.Windows.Forms.ComboBox cmbReportType;
        private System.Windows.Forms.CheckBox chkUseDateFilter;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Button btnLoadReport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnClear;

        private System.Windows.Forms.Panel pnlSummaryCard;
        private System.Windows.Forms.Label lblReportTypeTitle;
        private System.Windows.Forms.Label lblReportTypeValue;
        private System.Windows.Forms.Label lblRecordCountTitle;
        private System.Windows.Forms.Label lblRecordCountValue;
        private System.Windows.Forms.Label lblTotalFineTitle;
        private System.Windows.Forms.Label lblTotalFineValue;
        private System.Windows.Forms.Label lblGeneratedTitle;
        private System.Windows.Forms.Label lblGeneratedValue;

        private System.Windows.Forms.Panel pnlGridCard;
        private System.Windows.Forms.Label lblGridTitle;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvReports;

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

            this.pnlFilterCard = new System.Windows.Forms.Panel();
            this.lblReportType = new System.Windows.Forms.Label();
            this.cmbReportType = new System.Windows.Forms.ComboBox();
            this.chkUseDateFilter = new System.Windows.Forms.CheckBox();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.lblToDate = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.btnLoadReport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();

            this.pnlSummaryCard = new System.Windows.Forms.Panel();
            this.lblReportTypeTitle = new System.Windows.Forms.Label();
            this.lblReportTypeValue = new System.Windows.Forms.Label();
            this.lblRecordCountTitle = new System.Windows.Forms.Label();
            this.lblRecordCountValue = new System.Windows.Forms.Label();
            this.lblTotalFineTitle = new System.Windows.Forms.Label();
            this.lblTotalFineValue = new System.Windows.Forms.Label();
            this.lblGeneratedTitle = new System.Windows.Forms.Label();
            this.lblGeneratedValue = new System.Windows.Forms.Label();

            this.pnlGridCard = new System.Windows.Forms.Panel();
            this.lblGridTitle = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvReports = new System.Windows.Forms.DataGridView();

            this.pnlMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlFilterCard.SuspendLayout();
            this.pnlSummaryCard.SuspendLayout();
            this.pnlGridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.SuspendLayout();

            // pnlMain
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.pnlMain.Controls.Add(this.pnlGridCard);
            this.pnlMain.Controls.Add(this.pnlSummaryCard);
            this.pnlMain.Controls.Add(this.pnlFilterCard);
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
            this.lblTitle.Size = new System.Drawing.Size(84, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Reports";

            // lblSubtitle
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblSubtitle.Location = new System.Drawing.Point(21, 35);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(392, 15);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Generate library reports for books, members, issued books, returns and fines.";

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

            // pnlFilterCard
            this.pnlFilterCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFilterCard.BackColor = System.Drawing.Color.White;
            this.pnlFilterCard.Controls.Add(this.btnClear);
            this.pnlFilterCard.Controls.Add(this.btnExport);
            this.pnlFilterCard.Controls.Add(this.btnLoadReport);
            this.pnlFilterCard.Controls.Add(this.dtpToDate);
            this.pnlFilterCard.Controls.Add(this.lblToDate);
            this.pnlFilterCard.Controls.Add(this.dtpFromDate);
            this.pnlFilterCard.Controls.Add(this.lblFromDate);
            this.pnlFilterCard.Controls.Add(this.chkUseDateFilter);
            this.pnlFilterCard.Controls.Add(this.cmbReportType);
            this.pnlFilterCard.Controls.Add(this.lblReportType);
            this.pnlFilterCard.Location = new System.Drawing.Point(10, 78);
            this.pnlFilterCard.Name = "pnlFilterCard";
            this.pnlFilterCard.Size = new System.Drawing.Size(1030, 82);
            this.pnlFilterCard.TabIndex = 1;

            // lblReportType
            this.lblReportType.AutoSize = true;
            this.lblReportType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblReportType.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblReportType.Location = new System.Drawing.Point(20, 14);
            this.lblReportType.Name = "lblReportType";
            this.lblReportType.Size = new System.Drawing.Size(74, 15);
            this.lblReportType.TabIndex = 0;
            this.lblReportType.Text = "Report Type";

            // cmbReportType
            this.cmbReportType.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbReportType.FormattingEnabled = true;
            this.cmbReportType.Items.AddRange(new object[] {
            "All Books",
            "Available Books",
            "All Members",
            "Currently Issued Books",
            "Returned Books",
            "Overdue Books",
            "Fine Report"});
            this.cmbReportType.Location = new System.Drawing.Point(23, 34);
            this.cmbReportType.Name = "cmbReportType";
            this.cmbReportType.Size = new System.Drawing.Size(210, 25);
            this.cmbReportType.TabIndex = 0;
            this.cmbReportType.SelectedIndexChanged += new System.EventHandler(this.cmbReportType_SelectedIndexChanged);

            // chkUseDateFilter
            this.chkUseDateFilter.AutoSize = true;
            this.chkUseDateFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.chkUseDateFilter.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.chkUseDateFilter.Location = new System.Drawing.Point(258, 36);
            this.chkUseDateFilter.Name = "chkUseDateFilter";
            this.chkUseDateFilter.Size = new System.Drawing.Size(112, 19);
            this.chkUseDateFilter.TabIndex = 1;
            this.chkUseDateFilter.Text = "Use date filter";
            this.chkUseDateFilter.UseVisualStyleBackColor = true;
            this.chkUseDateFilter.CheckedChanged += new System.EventHandler(this.chkUseDateFilter_CheckedChanged);

            // lblFromDate
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFromDate.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblFromDate.Location = new System.Drawing.Point(395, 14);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(64, 15);
            this.lblFromDate.TabIndex = 3;
            this.lblFromDate.Text = "From Date";

            // dtpFromDate
            this.dtpFromDate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.Location = new System.Drawing.Point(398, 34);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(120, 24);
            this.dtpFromDate.TabIndex = 2;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);

            // lblToDate
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblToDate.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblToDate.Location = new System.Drawing.Point(535, 14);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(48, 15);
            this.lblToDate.TabIndex = 5;
            this.lblToDate.Text = "To Date";

            // dtpToDate
            this.dtpToDate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDate.Location = new System.Drawing.Point(538, 34);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(120, 24);
            this.dtpToDate.TabIndex = 3;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);

            // btnLoadReport
            this.btnLoadReport.BackColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.btnLoadReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadReport.FlatAppearance.BorderSize = 0;
            this.btnLoadReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadReport.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLoadReport.ForeColor = System.Drawing.Color.White;
            this.btnLoadReport.Location = new System.Drawing.Point(690, 28);
            this.btnLoadReport.Name = "btnLoadReport";
            this.btnLoadReport.Size = new System.Drawing.Size(100, 34);
            this.btnLoadReport.TabIndex = 4;
            this.btnLoadReport.Text = "Load";
            this.btnLoadReport.UseVisualStyleBackColor = false;
            this.btnLoadReport.Click += new System.EventHandler(this.btnLoadReport_Click);

            // btnExport
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(802, 28);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(100, 34);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Export CSV";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);

            // btnClear
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnClear.Location = new System.Drawing.Point(914, 28);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 34);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // pnlSummaryCard
            this.pnlSummaryCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSummaryCard.BackColor = System.Drawing.Color.White;
            this.pnlSummaryCard.Controls.Add(this.lblGeneratedValue);
            this.pnlSummaryCard.Controls.Add(this.lblGeneratedTitle);
            this.pnlSummaryCard.Controls.Add(this.lblTotalFineValue);
            this.pnlSummaryCard.Controls.Add(this.lblTotalFineTitle);
            this.pnlSummaryCard.Controls.Add(this.lblRecordCountValue);
            this.pnlSummaryCard.Controls.Add(this.lblRecordCountTitle);
            this.pnlSummaryCard.Controls.Add(this.lblReportTypeValue);
            this.pnlSummaryCard.Controls.Add(this.lblReportTypeTitle);
            this.pnlSummaryCard.Location = new System.Drawing.Point(10, 172);
            this.pnlSummaryCard.Name = "pnlSummaryCard";
            this.pnlSummaryCard.Size = new System.Drawing.Size(1030, 64);
            this.pnlSummaryCard.TabIndex = 2;

            // lblReportTypeTitle
            this.lblReportTypeTitle.AutoSize = true;
            this.lblReportTypeTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblReportTypeTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblReportTypeTitle.Location = new System.Drawing.Point(20, 10);
            this.lblReportTypeTitle.Name = "lblReportTypeTitle";
            this.lblReportTypeTitle.Size = new System.Drawing.Size(72, 15);
            this.lblReportTypeTitle.TabIndex = 0;
            this.lblReportTypeTitle.Text = "Report Type";

            // lblReportTypeValue
            this.lblReportTypeValue.AutoSize = true;
            this.lblReportTypeValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblReportTypeValue.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblReportTypeValue.Location = new System.Drawing.Point(20, 30);
            this.lblReportTypeValue.Name = "lblReportTypeValue";
            this.lblReportTypeValue.Size = new System.Drawing.Size(80, 21);
            this.lblReportTypeValue.TabIndex = 1;
            this.lblReportTypeValue.Text = "All Books";

            // lblRecordCountTitle
            this.lblRecordCountTitle.AutoSize = true;
            this.lblRecordCountTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblRecordCountTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblRecordCountTitle.Location = new System.Drawing.Point(300, 10);
            this.lblRecordCountTitle.Name = "lblRecordCountTitle";
            this.lblRecordCountTitle.Size = new System.Drawing.Size(82, 15);
            this.lblRecordCountTitle.TabIndex = 2;
            this.lblRecordCountTitle.Text = "Record Count";

            // lblRecordCountValue
            this.lblRecordCountValue.AutoSize = true;
            this.lblRecordCountValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRecordCountValue.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblRecordCountValue.Location = new System.Drawing.Point(300, 30);
            this.lblRecordCountValue.Name = "lblRecordCountValue";
            this.lblRecordCountValue.Size = new System.Drawing.Size(19, 21);
            this.lblRecordCountValue.TabIndex = 3;
            this.lblRecordCountValue.Text = "0";

            // lblTotalFineTitle
            this.lblTotalFineTitle.AutoSize = true;
            this.lblTotalFineTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblTotalFineTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblTotalFineTitle.Location = new System.Drawing.Point(530, 10);
            this.lblTotalFineTitle.Name = "lblTotalFineTitle";
            this.lblTotalFineTitle.Size = new System.Drawing.Size(60, 15);
            this.lblTotalFineTitle.TabIndex = 4;
            this.lblTotalFineTitle.Text = "Total Fine";

            // lblTotalFineValue
            this.lblTotalFineValue.AutoSize = true;
            this.lblTotalFineValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalFineValue.ForeColor = System.Drawing.Color.FromArgb(249, 115, 22);
            this.lblTotalFineValue.Location = new System.Drawing.Point(530, 30);
            this.lblTotalFineValue.Name = "lblTotalFineValue";
            this.lblTotalFineValue.Size = new System.Drawing.Size(67, 21);
            this.lblTotalFineValue.TabIndex = 5;
            this.lblTotalFineValue.Text = "Rs. 0.00";

            // lblGeneratedTitle
            this.lblGeneratedTitle.AutoSize = true;
            this.lblGeneratedTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblGeneratedTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblGeneratedTitle.Location = new System.Drawing.Point(760, 10);
            this.lblGeneratedTitle.Name = "lblGeneratedTitle";
            this.lblGeneratedTitle.Size = new System.Drawing.Size(77, 15);
            this.lblGeneratedTitle.TabIndex = 6;
            this.lblGeneratedTitle.Text = "Generated At";

            // lblGeneratedValue
            this.lblGeneratedValue.AutoSize = true;
            this.lblGeneratedValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblGeneratedValue.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblGeneratedValue.Location = new System.Drawing.Point(760, 30);
            this.lblGeneratedValue.Name = "lblGeneratedValue";
            this.lblGeneratedValue.Size = new System.Drawing.Size(16, 21);
            this.lblGeneratedValue.TabIndex = 7;
            this.lblGeneratedValue.Text = "-";

            // pnlGridCard
            this.pnlGridCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGridCard.BackColor = System.Drawing.Color.White;
            this.pnlGridCard.Controls.Add(this.dgvReports);
            this.pnlGridCard.Controls.Add(this.txtSearch);
            this.pnlGridCard.Controls.Add(this.lblSearch);
            this.pnlGridCard.Controls.Add(this.lblGridTitle);
            this.pnlGridCard.Location = new System.Drawing.Point(10, 248);
            this.pnlGridCard.Name = "pnlGridCard";
            this.pnlGridCard.Size = new System.Drawing.Size(1030, 398);
            this.pnlGridCard.TabIndex = 3;

            // lblGridTitle
            this.lblGridTitle.AutoSize = true;
            this.lblGridTitle.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold);
            this.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblGridTitle.Location = new System.Drawing.Point(20, 14);
            this.lblGridTitle.Name = "lblGridTitle";
            this.lblGridTitle.Size = new System.Drawing.Size(120, 23);
            this.lblGridTitle.TabIndex = 0;
            this.lblGridTitle.Text = "Report Results";

            // lblSearch
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblSearch.Location = new System.Drawing.Point(738, 20);
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
            this.txtSearch.Location = new System.Drawing.Point(787, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(220, 25);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);

            // dgvReports
            this.dgvReports.AllowUserToAddRows = false;
            this.dgvReports.AllowUserToDeleteRows = false;
            this.dgvReports.AllowUserToResizeRows = false;
            this.dgvReports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReports.BackgroundColor = System.Drawing.Color.White;
            this.dgvReports.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReports.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReports.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReports.ColumnHeadersHeight = 42;
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReports.EnableHeadersVisualStyles = false;
            this.dgvReports.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dgvReports.Location = new System.Drawing.Point(20, 58);
            this.dgvReports.MultiSelect = false;
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.ReadOnly = true;
            this.dgvReports.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.dgvReports.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReports.RowTemplate.Height = 34;
            this.dgvReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReports.Size = new System.Drawing.Size(990, 320);
            this.dgvReports.TabIndex = 2;

            // FrmReports
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.ClientSize = new System.Drawing.Size(1050, 656);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.FrmReports_Load);

            this.pnlMain.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFilterCard.ResumeLayout(false);
            this.pnlFilterCard.PerformLayout();
            this.pnlSummaryCard.ResumeLayout(false);
            this.pnlSummaryCard.PerformLayout();
            this.pnlGridCard.ResumeLayout(false);
            this.pnlGridCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.ResumeLayout(false);
        }
    }
}