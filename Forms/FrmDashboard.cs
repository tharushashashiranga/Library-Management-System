using LibraryManagementSystem.Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagementSystem.Forms
{
    public partial class FrmDashboard : Form
    {
        private readonly DbConnection db = new DbConnection();

        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardStatistics();
            LoadRecentIssueRecords();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDashboardStatistics();
            LoadRecentIssueRecords();

            MessageBox.Show(
                "Dashboard refreshed successfully.",
                "Refresh",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void LoadDashboardStatistics()
        {
            lblTotalBooksValue.Text = GetScalarValue("SELECT IFNULL(SUM(total_quantity), 0) FROM books;");
            lblAvailableBooksValue.Text = GetScalarValue("SELECT IFNULL(SUM(available_quantity), 0) FROM books;");
            lblMembersValue.Text = GetScalarValue("SELECT COUNT(*) FROM members WHERE status = 'Active';");
            lblIssuedBooksValue.Text = GetScalarValue("SELECT COUNT(*) FROM issue_records WHERE status = 'Issued';");
            lblOverdueBooksValue.Text = GetScalarValue("SELECT COUNT(*) FROM issue_records WHERE status = 'Issued' AND due_date < CURDATE();");
            lblTotalFinesValue.Text = "Rs. " + GetScalarDecimalValue("SELECT IFNULL(SUM(fine_amount), 0) FROM issue_records;");
        }

        private void LoadRecentIssueRecords()
        {
            string query = @"
                SELECT 
                    ir.issue_id AS 'Issue ID',
                    b.book_code AS 'Book Code',
                    b.title AS 'Book Title',
                    m.member_code AS 'Member Code',
                    m.full_name AS 'Member Name',
                    ir.issue_date AS 'Issue Date',
                    ir.due_date AS 'Due Date',
                    ir.status AS 'Status'
                FROM issue_records ir
                INNER JOIN books b ON ir.book_id = b.book_id
                INNER JOIN members m ON ir.member_id = m.member_id
                ORDER BY ir.issue_id DESC
                LIMIT 8;
            ";

            DataTable dt = db.GetData(query);
            dgvRecentIssues.DataSource = dt;

            FormatRecentIssueGrid();
        }

        private string GetScalarValue(string query)
        {
            object result = db.ExecuteScalar(query);

            if (result == null || result == DBNull.Value)
            {
                return "0";
            }

            return result.ToString();
        }

        private string GetScalarDecimalValue(string query)
        {
            object result = db.ExecuteScalar(query);

            if (result == null || result == DBNull.Value)
            {
                return "0.00";
            }

            decimal value = Convert.ToDecimal(result);
            return value.ToString("N2");
        }

        private void FormatRecentIssueGrid()
        {
            if (dgvRecentIssues.Columns.Count == 0)
            {
                return;
            }

            dgvRecentIssues.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentIssues.RowTemplate.Height = 35;
            dgvRecentIssues.ClearSelection();

            if (dgvRecentIssues.Columns.Contains("Issue ID"))
            {
                dgvRecentIssues.Columns["Issue ID"].Width = 70;
            }

            if (dgvRecentIssues.Columns.Contains("Book Title"))
            {
                dgvRecentIssues.Columns["Book Title"].Width = 180;
            }

            if (dgvRecentIssues.Columns.Contains("Member Name"))
            {
                dgvRecentIssues.Columns["Member Name"].Width = 150;
            }
        }
    }
}