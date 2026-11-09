using LibraryManagementSystem.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagementSystem.Forms
{
    public partial class FrmReports : Form
    {
        private readonly DbConnection db = new DbConnection();
        private DataTable currentReportData = new DataTable();

        public FrmReports()
        {
            InitializeComponent();
        }

        private void FrmReports_Load(object sender, EventArgs e)
        {
            cmbReportType.SelectedIndex = 0;
            dtpFromDate.Value = DateTime.Today.AddMonths(-1);
            dtpToDate.Value = DateTime.Today;
            chkUseDateFilter.Checked = false;

            UpdateDateFilterState();
            LoadReport();
        }

        private void btnLoadReport_Click(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportReportToCsv();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFilters();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadReport();

            MessageBox.Show(
                "Report refreshed successfully.",
                "Refresh",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void cmbReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void chkUseDateFilter_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDateFilterState();
            LoadReport();
        }

        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            if (chkUseDateFilter.Checked)
            {
                LoadReport();
            }
        }

        private void dtpToDate_ValueChanged(object sender, EventArgs e)
        {
            if (chkUseDateFilter.Checked)
            {
                LoadReport();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void LoadReport()
        {
            if (cmbReportType.SelectedItem == null)
            {
                return;
            }

            string reportType = cmbReportType.SelectedItem.ToString();
            string searchText = txtSearch.Text.Trim();

            List<MySqlParameter> parameters = new List<MySqlParameter>();
            parameters.Add(new MySqlParameter("@search", "%" + searchText + "%"));

            string query = BuildReportQuery(reportType, parameters);

            currentReportData = db.GetData(query, parameters.ToArray());
            dgvReports.DataSource = currentReportData;

            FormatReportGrid();
            UpdateSummary(reportType);
        }

        private string BuildReportQuery(string reportType, List<MySqlParameter> parameters)
        {
            bool useDateFilter = chkUseDateFilter.Checked;
            DateTime fromDate = dtpFromDate.Value.Date;
            DateTime toDate = dtpToDate.Value.Date;

            if (useDateFilter)
            {
                parameters.Add(new MySqlParameter("@from_date", fromDate));
                parameters.Add(new MySqlParameter("@to_date", toDate));
            }

            switch (reportType)
            {
                case "All Books":
                    return @"
                        SELECT 
                            book_code AS 'Book Code',
                            title AS 'Title',
                            author AS 'Author',
                            category AS 'Category',
                            IFNULL(publisher, '') AS 'Publisher',
                            IFNULL(isbn, '') AS 'ISBN',
                            IFNULL(shelf_location, '') AS 'Shelf',
                            total_quantity AS 'Total Qty',
                            available_quantity AS 'Available Qty',
                            status AS 'Status'
                        FROM books
                        WHERE 
                            book_code LIKE @search OR
                            title LIKE @search OR
                            author LIKE @search OR
                            category LIKE @search OR
                            publisher LIKE @search OR
                            isbn LIKE @search
                        ORDER BY book_id DESC;
                    ";

                case "Available Books":
                    return @"
                        SELECT 
                            book_code AS 'Book Code',
                            title AS 'Title',
                            author AS 'Author',
                            category AS 'Category',
                            IFNULL(publisher, '') AS 'Publisher',
                            IFNULL(isbn, '') AS 'ISBN',
                            IFNULL(shelf_location, '') AS 'Shelf',
                            total_quantity AS 'Total Qty',
                            available_quantity AS 'Available Qty',
                            status AS 'Status'
                        FROM books
                        WHERE 
                            available_quantity > 0
                            AND
                            (
                                book_code LIKE @search OR
                                title LIKE @search OR
                                author LIKE @search OR
                                category LIKE @search OR
                                publisher LIKE @search OR
                                isbn LIKE @search
                            )
                        ORDER BY title ASC;
                    ";

                case "All Members":
                    return @"
                        SELECT 
                            member_code AS 'Member Code',
                            full_name AS 'Full Name',
                            contact_no AS 'Contact No',
                            IFNULL(email, '') AS 'Email',
                            IFNULL(address, '') AS 'Address',
                            registered_date AS 'Registered Date',
                            status AS 'Status'
                        FROM members
                        WHERE
                            member_code LIKE @search OR
                            full_name LIKE @search OR
                            contact_no LIKE @search OR
                            email LIKE @search OR
                            address LIKE @search
                        ORDER BY member_id DESC;
                    ";

                case "Currently Issued Books":
                    return @"
                        SELECT 
                            ir.issue_id AS 'Issue ID',
                            b.book_code AS 'Book Code',
                            b.title AS 'Book Title',
                            m.member_code AS 'Member Code',
                            m.full_name AS 'Member Name',
                            ir.issue_date AS 'Issue Date',
                            ir.due_date AS 'Due Date',
                            CASE
                                WHEN DATEDIFF(CURDATE(), ir.due_date) > 0 THEN DATEDIFF(CURDATE(), ir.due_date)
                                ELSE 0
                            END AS 'Late Days',
                            ir.status AS 'Status'
                        FROM issue_records ir
                        INNER JOIN books b ON ir.book_id = b.book_id
                        INNER JOIN members m ON ir.member_id = m.member_id
                        WHERE 
                            ir.status = 'Issued'
                            AND
                            (
                                b.book_code LIKE @search OR
                                b.title LIKE @search OR
                                m.member_code LIKE @search OR
                                m.full_name LIKE @search
                            )
                            " + GetDateFilterSql("ir.issue_date", useDateFilter) + @"
                        ORDER BY ir.issue_id DESC;
                    ";

                case "Returned Books":
                    return @"
                        SELECT 
                            ir.issue_id AS 'Issue ID',
                            b.book_code AS 'Book Code',
                            b.title AS 'Book Title',
                            m.member_code AS 'Member Code',
                            m.full_name AS 'Member Name',
                            ir.issue_date AS 'Issue Date',
                            ir.due_date AS 'Due Date',
                            ir.return_date AS 'Return Date',
                            ir.fine_amount AS 'Fine Amount',
                            ir.status AS 'Status'
                        FROM issue_records ir
                        INNER JOIN books b ON ir.book_id = b.book_id
                        INNER JOIN members m ON ir.member_id = m.member_id
                        WHERE 
                            ir.status = 'Returned'
                            AND
                            (
                                b.book_code LIKE @search OR
                                b.title LIKE @search OR
                                m.member_code LIKE @search OR
                                m.full_name LIKE @search
                            )
                            " + GetDateFilterSql("ir.return_date", useDateFilter) + @"
                        ORDER BY ir.return_date DESC;
                    ";

                case "Overdue Books":
                    return @"
                        SELECT 
                            ir.issue_id AS 'Issue ID',
                            b.book_code AS 'Book Code',
                            b.title AS 'Book Title',
                            m.member_code AS 'Member Code',
                            m.full_name AS 'Member Name',
                            ir.issue_date AS 'Issue Date',
                            ir.due_date AS 'Due Date',
                            DATEDIFF(CURDATE(), ir.due_date) AS 'Late Days',
                            (DATEDIFF(CURDATE(), ir.due_date) * 50) AS 'Estimated Fine',
                            ir.status AS 'Status'
                        FROM issue_records ir
                        INNER JOIN books b ON ir.book_id = b.book_id
                        INNER JOIN members m ON ir.member_id = m.member_id
                        WHERE 
                            ir.status = 'Issued'
                            AND ir.due_date < CURDATE()
                            AND
                            (
                                b.book_code LIKE @search OR
                                b.title LIKE @search OR
                                m.member_code LIKE @search OR
                                m.full_name LIKE @search
                            )
                            " + GetDateFilterSql("ir.due_date", useDateFilter) + @"
                        ORDER BY ir.due_date ASC;
                    ";

                case "Fine Report":
                    return @"
                        SELECT 
                            ir.issue_id AS 'Issue ID',
                            b.book_code AS 'Book Code',
                            b.title AS 'Book Title',
                            m.member_code AS 'Member Code',
                            m.full_name AS 'Member Name',
                            ir.issue_date AS 'Issue Date',
                            ir.due_date AS 'Due Date',
                            ir.return_date AS 'Return Date',
                            ir.fine_amount AS 'Fine Amount'
                        FROM issue_records ir
                        INNER JOIN books b ON ir.book_id = b.book_id
                        INNER JOIN members m ON ir.member_id = m.member_id
                        WHERE 
                            ir.status = 'Returned'
                            AND ir.fine_amount > 0
                            AND
                            (
                                b.book_code LIKE @search OR
                                b.title LIKE @search OR
                                m.member_code LIKE @search OR
                                m.full_name LIKE @search
                            )
                            " + GetDateFilterSql("ir.return_date", useDateFilter) + @"
                        ORDER BY ir.return_date DESC;
                    ";

                default:
                    return "SELECT 'No report selected' AS 'Message';";
            }
        }

        private string GetDateFilterSql(string columnName, bool useDateFilter)
        {
            if (!useDateFilter)
            {
                return "";
            }

            return " AND " + columnName + " BETWEEN @from_date AND @to_date ";
        }

        private void UpdateDateFilterState()
        {
            dtpFromDate.Enabled = chkUseDateFilter.Checked;
            dtpToDate.Enabled = chkUseDateFilter.Checked;
        }

        private void UpdateSummary(string reportType)
        {
            int recordCount = currentReportData == null ? 0 : currentReportData.Rows.Count;

            lblRecordCountValue.Text = recordCount.ToString();
            lblGeneratedValue.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm tt");
            lblReportTypeValue.Text = reportType;

            decimal totalFine = CalculateTotalFine();
            lblTotalFineValue.Text = "Rs. " + totalFine.ToString("N2");
        }

        private decimal CalculateTotalFine()
        {
            decimal total = 0.00m;

            if (currentReportData == null)
            {
                return total;
            }

            string fineColumn = "";

            if (currentReportData.Columns.Contains("Fine Amount"))
            {
                fineColumn = "Fine Amount";
            }
            else if (currentReportData.Columns.Contains("Estimated Fine"))
            {
                fineColumn = "Estimated Fine";
            }

            if (string.IsNullOrEmpty(fineColumn))
            {
                return total;
            }

            foreach (DataRow row in currentReportData.Rows)
            {
                if (row[fineColumn] != null && row[fineColumn] != DBNull.Value)
                {
                    decimal value;

                    if (decimal.TryParse(row[fineColumn].ToString(), out value))
                    {
                        total += value;
                    }
                }
            }

            return total;
        }

        private void FormatReportGrid()
        {
            if (dgvReports.Columns.Count == 0)
            {
                return;
            }

            dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReports.RowTemplate.Height = 34;
            dgvReports.ClearSelection();

            foreach (DataGridViewColumn column in dgvReports.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }

            FormatDateColumn("Issue Date");
            FormatDateColumn("Due Date");
            FormatDateColumn("Return Date");
            FormatDateColumn("Registered Date");

            FormatDecimalColumn("Fine Amount");
            FormatDecimalColumn("Estimated Fine");

            HideColumn("Issue ID");
        }

        private void FormatDateColumn(string columnName)
        {
            if (dgvReports.Columns.Contains(columnName))
            {
                dgvReports.Columns[columnName].DefaultCellStyle.Format = "yyyy-MM-dd";
            }
        }

        private void FormatDecimalColumn(string columnName)
        {
            if (dgvReports.Columns.Contains(columnName))
            {
                dgvReports.Columns[columnName].DefaultCellStyle.Format = "N2";
            }
        }

        private void HideColumn(string columnName)
        {
            if (dgvReports.Columns.Contains(columnName))
            {
                dgvReports.Columns[columnName].Visible = false;
            }
        }

        private void ExportReportToCsv()
        {
            if (dgvReports.Rows.Count == 0)
            {
                MessageBox.Show(
                    "No report data available to export.",
                    "Export",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV File (*.csv)|*.csv";
                saveFileDialog.Title = "Export Report";
                saveFileDialog.FileName = cmbReportType.Text.Replace(" ", "_") + "_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".csv";

                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                try
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName, false, new UTF8Encoding(true)))
                    {
                        List<string> headers = new List<string>();

                        foreach (DataGridViewColumn column in dgvReports.Columns)
                        {
                            if (column.Visible)
                            {
                                headers.Add(EscapeCsv(column.HeaderText));
                            }
                        }

                        writer.WriteLine(string.Join(",", headers));

                        foreach (DataGridViewRow row in dgvReports.Rows)
                        {
                            if (row.IsNewRow)
                            {
                                continue;
                            }

                            List<string> values = new List<string>();

                            foreach (DataGridViewColumn column in dgvReports.Columns)
                            {
                                if (column.Visible)
                                {
                                    object cellValue = row.Cells[column.Index].Value;
                                    values.Add(EscapeCsv(cellValue == null ? "" : cellValue.ToString()));
                                }
                            }

                            writer.WriteLine(string.Join(",", values));
                        }
                    }

                    MessageBox.Show(
                        "Report exported successfully.",
                        "Export Completed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Report export failed.\n\n" + ex.Message,
                        "Export Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private string EscapeCsv(string value)
        {
            if (value == null)
            {
                return "";
            }

            value = value.Replace("\"", "\"\"");

            if (value.Contains(",") || value.Contains("\"") || value.Contains("\n"))
            {
                value = "\"" + value + "\"";
            }

            return value;
        }

        private void ClearFilters()
        {
            cmbReportType.SelectedIndex = 0;
            txtSearch.Clear();
            chkUseDateFilter.Checked = false;
            dtpFromDate.Value = DateTime.Today.AddMonths(-1);
            dtpToDate.Value = DateTime.Today;

            LoadReport();
        }
    }
}