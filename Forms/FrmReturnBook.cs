using LibraryManagementSystem.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagementSystem.Forms
{
    public partial class FrmReturnBook : Form
    {
        private readonly DbConnection db = new DbConnection();

        private int selectedIssueId = 0;
        private int selectedBookId = 0;
        private DateTime selectedDueDate = DateTime.Today;

        private const decimal FinePerDay = 50.00m;

        public FrmReturnBook()
        {
            InitializeComponent();
        }

        private void FrmReturnBook_Load(object sender, EventArgs e)
        {
            dtpReturnDate.Value = DateTime.Today;
            LoadActiveIssueRecords();
            ClearForm();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ReturnBook();
        }

        private void btnCalculateFine_Click(object sender, EventArgs e)
        {
            CalculateAndDisplayFine();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadActiveIssueRecords();
            ClearForm();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadActiveIssueRecords(txtSearch.Text.Trim());
        }

        private void dtpReturnDate_ValueChanged(object sender, EventArgs e)
        {
            if (selectedIssueId != 0)
            {
                CalculateAndDisplayFine();
            }
        }

        private void dgvActiveIssues_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvActiveIssues.Rows[e.RowIndex].Cells["Issue ID"].Value != null)
            {
                LoadSelectedIssueRecord(e.RowIndex);
            }
        }

        private void LoadActiveIssueRecords(string searchText = "")
        {
            string query = @"
                SELECT 
                    ir.issue_id AS 'Issue ID',
                    b.book_id AS 'Book ID',
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
                ORDER BY ir.issue_id DESC;
            ";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@search", "%" + searchText + "%")
            };

            DataTable dt = db.GetData(query, parameters);
            dgvActiveIssues.DataSource = dt;

            FormatActiveIssuesGrid();
        }

        private void LoadSelectedIssueRecord(int rowIndex)
        {
            DataGridViewRow row = dgvActiveIssues.Rows[rowIndex];

            selectedIssueId = Convert.ToInt32(row.Cells["Issue ID"].Value);
            selectedBookId = Convert.ToInt32(row.Cells["Book ID"].Value);
            selectedDueDate = Convert.ToDateTime(row.Cells["Due Date"].Value);

            lblSelectedIssueValue.Text = selectedIssueId.ToString();
            lblBookValue.Text = row.Cells["Book Code"].Value.ToString() + " - " + row.Cells["Book Title"].Value.ToString();
            lblMemberValue.Text = row.Cells["Member Code"].Value.ToString() + " - " + row.Cells["Member Name"].Value.ToString();
            lblIssueDateValue.Text = Convert.ToDateTime(row.Cells["Issue Date"].Value).ToString("yyyy-MM-dd");
            lblDueDateValue.Text = selectedDueDate.ToString("yyyy-MM-dd");

            dtpReturnDate.Value = DateTime.Today;

            CalculateAndDisplayFine();

            btnReturn.Enabled = true;
        }

        private void CalculateAndDisplayFine()
        {
            if (selectedIssueId == 0)
            {
                lblLateDaysValue.Text = "0";
                lblFineValue.Text = "Rs. 0.00";
                return;
            }

            int lateDays = CalculateLateDays(selectedDueDate, dtpReturnDate.Value.Date);
            decimal fineAmount = lateDays * FinePerDay;

            lblLateDaysValue.Text = lateDays.ToString();
            lblFineValue.Text = "Rs. " + fineAmount.ToString("N2");
        }

        private int CalculateLateDays(DateTime dueDate, DateTime returnDate)
        {
            if (returnDate.Date <= dueDate.Date)
            {
                return 0;
            }

            return Convert.ToInt32((returnDate.Date - dueDate.Date).TotalDays);
        }

        private decimal CalculateFineAmount()
        {
            int lateDays = CalculateLateDays(selectedDueDate, dtpReturnDate.Value.Date);
            return lateDays * FinePerDay;
        }

        private void ReturnBook()
        {
            if (selectedIssueId == 0 || selectedBookId == 0)
            {
                MessageBox.Show(
                    "Please select an issued book record to return.",
                    "Selection Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (dtpReturnDate.Value.Date < Convert.ToDateTime(lblIssueDateValue.Text).Date)
            {
                MessageBox.Show(
                    "Return date cannot be before the issue date.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                dtpReturnDate.Focus();
                return;
            }

            decimal fineAmount = CalculateFineAmount();
            int lateDays = CalculateLateDays(selectedDueDate, dtpReturnDate.Value.Date);

            DialogResult result = MessageBox.Show(
                "Confirm book return?\n\nLate Days: " + lateDays + "\nFine Amount: Rs. " + fineAmount.ToString("N2"),
                "Return Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result != DialogResult.Yes)
            {
                return;
            }

            using (MySqlConnection connection = db.GetConnection())
            {
                connection.Open();

                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string updateIssueQuery = @"
                            UPDATE issue_records
                            SET 
                                return_date = @return_date,
                                fine_amount = @fine_amount,
                                status = 'Returned'
                            WHERE issue_id = @issue_id AND status = 'Issued';
                        ";

                        using (MySqlCommand issueCommand = new MySqlCommand(updateIssueQuery, connection, transaction))
                        {
                            issueCommand.Parameters.AddWithValue("@return_date", dtpReturnDate.Value.Date);
                            issueCommand.Parameters.AddWithValue("@fine_amount", fineAmount);
                            issueCommand.Parameters.AddWithValue("@issue_id", selectedIssueId);

                            int affectedRows = issueCommand.ExecuteNonQuery();

                            if (affectedRows == 0)
                            {
                                throw new Exception("This issue record is already returned or not available.");
                            }
                        }

                        string updateBookQuery = @"
                            UPDATE books
                            SET 
                                available_quantity = CASE
                                    WHEN available_quantity + 1 <= total_quantity THEN available_quantity + 1
                                    ELSE total_quantity
                                END,
                                status = 'Available'
                            WHERE book_id = @book_id;
                        ";

                        using (MySqlCommand bookCommand = new MySqlCommand(updateBookQuery, connection, transaction))
                        {
                            bookCommand.Parameters.AddWithValue("@book_id", selectedBookId);
                            bookCommand.ExecuteNonQuery();
                        }

                        transaction.Commit();

                        MessageBox.Show(
                            "Book returned successfully.\n\nFine Amount: Rs. " + fineAmount.ToString("N2"),
                            "Return Completed",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        LoadActiveIssueRecords();
                        ClearForm();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();

                        MessageBox.Show(
                            "Book return failed.\n\n" + ex.Message,
                            "Return Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
            }
        }

        private void ClearForm()
        {
            selectedIssueId = 0;
            selectedBookId = 0;
            selectedDueDate = DateTime.Today;

            lblSelectedIssueValue.Text = "-";
            lblBookValue.Text = "No book selected.";
            lblMemberValue.Text = "No member selected.";
            lblIssueDateValue.Text = "-";
            lblDueDateValue.Text = "-";
            lblLateDaysValue.Text = "0";
            lblFineValue.Text = "Rs. 0.00";

            dtpReturnDate.Value = DateTime.Today;

            btnReturn.Enabled = false;

            dgvActiveIssues.ClearSelection();
        }

        private void FormatActiveIssuesGrid()
        {
            if (dgvActiveIssues.Columns.Count == 0)
            {
                return;
            }

            dgvActiveIssues.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvActiveIssues.RowTemplate.Height = 34;

            if (dgvActiveIssues.Columns.Contains("Issue ID"))
            {
                dgvActiveIssues.Columns["Issue ID"].Visible = false;
            }

            if (dgvActiveIssues.Columns.Contains("Book ID"))
            {
                dgvActiveIssues.Columns["Book ID"].Visible = false;
            }

            if (dgvActiveIssues.Columns.Contains("Book Code"))
            {
                dgvActiveIssues.Columns["Book Code"].Width = 90;
            }

            if (dgvActiveIssues.Columns.Contains("Book Title"))
            {
                dgvActiveIssues.Columns["Book Title"].Width = 170;
            }

            if (dgvActiveIssues.Columns.Contains("Member Code"))
            {
                dgvActiveIssues.Columns["Member Code"].Width = 95;
            }

            if (dgvActiveIssues.Columns.Contains("Member Name"))
            {
                dgvActiveIssues.Columns["Member Name"].Width = 150;
            }

            if (dgvActiveIssues.Columns.Contains("Issue Date"))
            {
                dgvActiveIssues.Columns["Issue Date"].DefaultCellStyle.Format = "yyyy-MM-dd";
            }

            if (dgvActiveIssues.Columns.Contains("Due Date"))
            {
                dgvActiveIssues.Columns["Due Date"].DefaultCellStyle.Format = "yyyy-MM-dd";
            }

            if (dgvActiveIssues.Columns.Contains("Late Days"))
            {
                dgvActiveIssues.Columns["Late Days"].Width = 80;
            }

            dgvActiveIssues.ClearSelection();
        }
    }
}