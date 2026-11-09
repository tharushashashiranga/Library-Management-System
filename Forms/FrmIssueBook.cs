using LibraryManagementSystem.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagementSystem.Forms
{
    public partial class FrmIssueBook : Form
    {
        private readonly DbConnection db = new DbConnection();

        public FrmIssueBook()
        {
            InitializeComponent();
        }

        private void FrmIssueBook_Load(object sender, EventArgs e)
        {
            dtpIssueDate.Value = DateTime.Today;
            dtpDueDate.Value = DateTime.Today.AddDays(14);

            LoadMembers();
            LoadAvailableBooks();
            LoadIssuedRecords();
            ClearForm();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            IssueBook();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadMembers();
            LoadAvailableBooks();
            LoadIssuedRecords();
            ClearForm();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadIssuedRecords(txtSearch.Text.Trim());
        }

        private void cmbMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowSelectedMemberInfo();
        }

        private void cmbBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowSelectedBookInfo();
        }

        private void dtpIssueDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDueDate.Value.Date < dtpIssueDate.Value.Date)
            {
                dtpDueDate.Value = dtpIssueDate.Value.Date.AddDays(14);
            }
        }

        private void dgvIssuedRecords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvIssuedRecords.ClearSelection();

            if (e.RowIndex >= 0)
            {
                dgvIssuedRecords.Rows[e.RowIndex].Selected = true;
            }
        }

        private void LoadMembers()
        {
            string query = @"
                SELECT 
                    member_id,
                    CONCAT(member_code, ' - ', full_name) AS display_text,
                    member_code,
                    full_name,
                    contact_no
                FROM members
                WHERE status = 'Active'
                ORDER BY full_name ASC;
            ";

            DataTable dt = db.GetData(query);

            cmbMember.DisplayMember = "display_text";
            cmbMember.ValueMember = "member_id";
            cmbMember.DataSource = dt;
            cmbMember.SelectedIndex = -1;
        }

        private void LoadAvailableBooks()
        {
            string query = @"
                SELECT 
                    book_id,
                    CONCAT(book_code, ' - ', title) AS display_text,
                    book_code,
                    title,
                    author,
                    available_quantity
                FROM books
                WHERE available_quantity > 0
                ORDER BY title ASC;
            ";

            DataTable dt = db.GetData(query);

            cmbBook.DisplayMember = "display_text";
            cmbBook.ValueMember = "book_id";
            cmbBook.DataSource = dt;
            cmbBook.SelectedIndex = -1;
        }

        private void LoadIssuedRecords(string searchText = "")
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
                    DATEDIFF(CURDATE(), ir.due_date) AS 'Late Days',
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
            dgvIssuedRecords.DataSource = dt;

            FormatIssuedRecordsGrid();
        }

        private void IssueBook()
        {
            if (!ValidateIssueForm())
            {
                return;
            }

            int memberId = GetSelectedMemberId();
            int bookId = GetSelectedBookId();

            if (HasSameActiveBook(memberId, bookId))
            {
                MessageBox.Show(
                    "This member has already borrowed this book and has not returned it yet.",
                    "Duplicate Issue Not Allowed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to issue this book?",
                "Issue Confirmation",
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
                        string checkQuery = @"
                            SELECT available_quantity 
                            FROM books 
                            WHERE book_id = @book_id 
                            FOR UPDATE;
                        ";

                        int availableQty = 0;

                        using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection, transaction))
                        {
                            checkCommand.Parameters.AddWithValue("@book_id", bookId);
                            object qtyResult = checkCommand.ExecuteScalar();

                            if (qtyResult == null || qtyResult == DBNull.Value)
                            {
                                throw new Exception("Selected book was not found.");
                            }

                            availableQty = Convert.ToInt32(qtyResult);
                        }

                        if (availableQty <= 0)
                        {
                            throw new Exception("This book is not available now.");
                        }

                        string insertIssueQuery = @"
                            INSERT INTO issue_records
                            (book_id, member_id, issue_date, due_date, status)
                            VALUES
                            (@book_id, @member_id, @issue_date, @due_date, 'Issued');
                        ";

                        using (MySqlCommand issueCommand = new MySqlCommand(insertIssueQuery, connection, transaction))
                        {
                            issueCommand.Parameters.AddWithValue("@book_id", bookId);
                            issueCommand.Parameters.AddWithValue("@member_id", memberId);
                            issueCommand.Parameters.AddWithValue("@issue_date", dtpIssueDate.Value.Date);
                            issueCommand.Parameters.AddWithValue("@due_date", dtpDueDate.Value.Date);
                            issueCommand.ExecuteNonQuery();
                        }

                        string updateBookQuery = @"
                            UPDATE books
                            SET 
                                available_quantity = available_quantity - 1,
                                status = CASE 
                                            WHEN available_quantity - 1 > 0 THEN 'Available'
                                            ELSE 'Not Available'
                                         END
                            WHERE book_id = @book_id;
                        ";

                        using (MySqlCommand updateCommand = new MySqlCommand(updateBookQuery, connection, transaction))
                        {
                            updateCommand.Parameters.AddWithValue("@book_id", bookId);
                            updateCommand.ExecuteNonQuery();
                        }

                        transaction.Commit();

                        MessageBox.Show(
                            "Book issued successfully.",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        LoadAvailableBooks();
                        LoadIssuedRecords();
                        ClearForm();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();

                        MessageBox.Show(
                            "Book issue failed.\n\n" + ex.Message,
                            "Issue Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
            }
        }

        private bool ValidateIssueForm()
        {
            if (GetSelectedMemberId() == 0)
            {
                MessageBox.Show("Please select a member.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbMember.Focus();
                return false;
            }

            if (GetSelectedBookId() == 0)
            {
                MessageBox.Show("Please select an available book.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbBook.Focus();
                return false;
            }

            if (dtpIssueDate.Value.Date > DateTime.Today)
            {
                MessageBox.Show("Issue date cannot be a future date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpIssueDate.Focus();
                return false;
            }

            if (dtpDueDate.Value.Date <= dtpIssueDate.Value.Date)
            {
                MessageBox.Show("Due date must be after the issue date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDueDate.Focus();
                return false;
            }

            return true;
        }

        private bool HasSameActiveBook(int memberId, int bookId)
        {
            string query = @"
                SELECT COUNT(*)
                FROM issue_records
                WHERE member_id = @member_id
                  AND book_id = @book_id
                  AND status = 'Issued';
            ";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@member_id", memberId),
                new MySqlParameter("@book_id", bookId)
            };

            object result = db.ExecuteScalar(query, parameters);
            return Convert.ToInt32(result) > 0;
        }

        private int GetSelectedMemberId()
        {
            if (cmbMember.SelectedIndex < 0 || cmbMember.SelectedValue == null)
            {
                return 0;
            }

            int memberId;

            if (int.TryParse(cmbMember.SelectedValue.ToString(), out memberId))
            {
                return memberId;
            }

            return 0;
        }

        private int GetSelectedBookId()
        {
            if (cmbBook.SelectedIndex < 0 || cmbBook.SelectedValue == null)
            {
                return 0;
            }

            int bookId;

            if (int.TryParse(cmbBook.SelectedValue.ToString(), out bookId))
            {
                return bookId;
            }

            return 0;
        }

        private void ShowSelectedMemberInfo()
        {
            lblMemberInfo.Text = "No member selected.";

            if (cmbMember.SelectedIndex < 0)
            {
                return;
            }

            DataRowView row = cmbMember.SelectedItem as DataRowView;

            if (row == null)
            {
                return;
            }

            lblMemberInfo.Text =
                "Code: " + row["member_code"].ToString() +
                "   |   Name: " + row["full_name"].ToString() +
                "   |   Contact: " + row["contact_no"].ToString();
        }

        private void ShowSelectedBookInfo()
        {
            lblBookInfo.Text = "No book selected.";

            if (cmbBook.SelectedIndex < 0)
            {
                return;
            }

            DataRowView row = cmbBook.SelectedItem as DataRowView;

            if (row == null)
            {
                return;
            }

            lblBookInfo.Text =
                "Code: " + row["book_code"].ToString() +
                "   |   Title: " + row["title"].ToString() +
                "   |   Author: " + row["author"].ToString() +
                "   |   Available: " + row["available_quantity"].ToString();
        }

        private void ClearForm()
        {
            cmbMember.SelectedIndex = -1;
            cmbBook.SelectedIndex = -1;

            dtpIssueDate.Value = DateTime.Today;
            dtpDueDate.Value = DateTime.Today.AddDays(14);

            lblMemberInfo.Text = "No member selected.";
            lblBookInfo.Text = "No book selected.";

            dgvIssuedRecords.ClearSelection();
            cmbMember.Focus();
        }

        private void FormatIssuedRecordsGrid()
        {
            if (dgvIssuedRecords.Columns.Count == 0)
            {
                return;
            }

            dgvIssuedRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIssuedRecords.RowTemplate.Height = 34;

            if (dgvIssuedRecords.Columns.Contains("Issue ID"))
            {
                dgvIssuedRecords.Columns["Issue ID"].Visible = false;
            }

            if (dgvIssuedRecords.Columns.Contains("Book Code"))
            {
                dgvIssuedRecords.Columns["Book Code"].Width = 90;
            }

            if (dgvIssuedRecords.Columns.Contains("Book Title"))
            {
                dgvIssuedRecords.Columns["Book Title"].Width = 180;
            }

            if (dgvIssuedRecords.Columns.Contains("Member Code"))
            {
                dgvIssuedRecords.Columns["Member Code"].Width = 95;
            }

            if (dgvIssuedRecords.Columns.Contains("Member Name"))
            {
                dgvIssuedRecords.Columns["Member Name"].Width = 150;
            }

            if (dgvIssuedRecords.Columns.Contains("Issue Date"))
            {
                dgvIssuedRecords.Columns["Issue Date"].DefaultCellStyle.Format = "yyyy-MM-dd";
            }

            if (dgvIssuedRecords.Columns.Contains("Due Date"))
            {
                dgvIssuedRecords.Columns["Due Date"].DefaultCellStyle.Format = "yyyy-MM-dd";
            }

            if (dgvIssuedRecords.Columns.Contains("Late Days"))
            {
                dgvIssuedRecords.Columns["Late Days"].Width = 85;
            }

            dgvIssuedRecords.ClearSelection();
        }
    }
}