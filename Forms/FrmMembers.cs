using LibraryManagementSystem.Classes;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagementSystem.Forms
{
    public partial class FrmMembers : Form
    {
        private readonly DbConnection db = new DbConnection();
        private int selectedMemberId = 0;

        public FrmMembers()
        {
            InitializeComponent();
        }

        private void FrmMembers_Load(object sender, EventArgs e)
        {
            LoadMembers();
            ClearForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddMember();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateMember();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteMember();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadMembers();
            ClearForm();
        }

        private void btnGenerateCode_Click(object sender, EventArgs e)
        {
            txtMemberCode.Text = GenerateNextMemberCode();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadMembers(txtSearch.Text.Trim());
        }

        private void dgvMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvMembers.Rows[e.RowIndex].Cells["Member ID"].Value != null)
            {
                DataGridViewRow row = dgvMembers.Rows[e.RowIndex];

                selectedMemberId = Convert.ToInt32(row.Cells["Member ID"].Value);
                txtMemberCode.Text = row.Cells["Member Code"].Value.ToString();
                txtFullName.Text = row.Cells["Full Name"].Value.ToString();
                txtContactNo.Text = row.Cells["Contact No"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
                dtpRegisteredDate.Value = Convert.ToDateTime(row.Cells["Registered Date"].Value);
                cmbStatus.Text = row.Cells["Status"].Value.ToString();

                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void LoadMembers(string searchText = "")
        {
            string query = @"
                SELECT 
                    member_id AS 'Member ID',
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

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@search", "%" + searchText + "%")
            };

            DataTable dt = db.GetData(query, parameters);
            dgvMembers.DataSource = dt;

            FormatMembersGrid();
        }

        private void AddMember()
        {
            if (!ValidateForm())
            {
                return;
            }

            if (IsMemberCodeExists(txtMemberCode.Text.Trim(), 0))
            {
                MessageBox.Show(
                    "This member code already exists. Please use another code.",
                    "Duplicate Member Code",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtMemberCode.Focus();
                return;
            }

            string query = @"
                INSERT INTO members
                (member_code, full_name, contact_no, email, address, registered_date, status)
                VALUES
                (@member_code, @full_name, @contact_no, @email, @address, @registered_date, @status);
            ";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@member_code", txtMemberCode.Text.Trim()),
                new MySqlParameter("@full_name", txtFullName.Text.Trim()),
                new MySqlParameter("@contact_no", txtContactNo.Text.Trim()),
                new MySqlParameter("@email", txtEmail.Text.Trim()),
                new MySqlParameter("@address", txtAddress.Text.Trim()),
                new MySqlParameter("@registered_date", dtpRegisteredDate.Value.Date),
                new MySqlParameter("@status", cmbStatus.Text.Trim())
            };

            int rows = db.ExecuteQuery(query, parameters);

            if (rows > 0)
            {
                MessageBox.Show(
                    "Member registered successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadMembers();
                ClearForm();
            }
        }

        private void UpdateMember()
        {
            if (selectedMemberId == 0)
            {
                MessageBox.Show(
                    "Please select a member to update.",
                    "Selection Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (!ValidateForm())
            {
                return;
            }

            if (IsMemberCodeExists(txtMemberCode.Text.Trim(), selectedMemberId))
            {
                MessageBox.Show(
                    "This member code already belongs to another member.",
                    "Duplicate Member Code",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtMemberCode.Focus();
                return;
            }

            string query = @"
                UPDATE members
                SET
                    member_code = @member_code,
                    full_name = @full_name,
                    contact_no = @contact_no,
                    email = @email,
                    address = @address,
                    registered_date = @registered_date,
                    status = @status
                WHERE member_id = @member_id;
            ";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@member_code", txtMemberCode.Text.Trim()),
                new MySqlParameter("@full_name", txtFullName.Text.Trim()),
                new MySqlParameter("@contact_no", txtContactNo.Text.Trim()),
                new MySqlParameter("@email", txtEmail.Text.Trim()),
                new MySqlParameter("@address", txtAddress.Text.Trim()),
                new MySqlParameter("@registered_date", dtpRegisteredDate.Value.Date),
                new MySqlParameter("@status", cmbStatus.Text.Trim()),
                new MySqlParameter("@member_id", selectedMemberId)
            };

            int rows = db.ExecuteQuery(query, parameters);

            if (rows > 0)
            {
                MessageBox.Show(
                    "Member updated successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadMembers();
                ClearForm();
            }
        }

        private void DeleteMember()
        {
            if (selectedMemberId == 0)
            {
                MessageBox.Show(
                    "Please select a member to delete.",
                    "Selection Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (MemberHasIssueRecords(selectedMemberId))
            {
                MessageBox.Show(
                    "This member cannot be deleted because this member has book issue/return history records.",
                    "Delete Not Allowed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this member?",
                "Delete Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result != DialogResult.Yes)
            {
                return;
            }

            string query = "DELETE FROM members WHERE member_id = @member_id;";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@member_id", selectedMemberId)
            };

            int rows = db.ExecuteQuery(query, parameters);

            if (rows > 0)
            {
                MessageBox.Show(
                    "Member deleted successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadMembers();
                ClearForm();
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtMemberCode.Text))
            {
                MessageBox.Show("Please enter member code.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMemberCode.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Please enter full name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtContactNo.Text))
            {
                MessageBox.Show("Please enter contact number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContactNo.Focus();
                return false;
            }

            if (txtContactNo.Text.Trim().Length < 10)
            {
                MessageBox.Show("Please enter a valid contact number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContactNo.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
                {
                    MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return false;
                }
            }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please enter address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbStatus.Text))
            {
                MessageBox.Show("Please select member status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbStatus.Focus();
                return false;
            }

            return true;
        }

        private bool IsMemberCodeExists(string memberCode, int currentMemberId)
        {
            string query = @"
                SELECT COUNT(*)
                FROM members
                WHERE member_code = @member_code AND member_id <> @member_id;
            ";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@member_code", memberCode),
                new MySqlParameter("@member_id", currentMemberId)
            };

            object result = db.ExecuteScalar(query, parameters);
            return Convert.ToInt32(result) > 0;
        }

        private bool MemberHasIssueRecords(int memberId)
        {
            string query = "SELECT COUNT(*) FROM issue_records WHERE member_id = @member_id;";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@member_id", memberId)
            };

            object result = db.ExecuteScalar(query, parameters);
            return Convert.ToInt32(result) > 0;
        }

        private string GenerateNextMemberCode()
        {
            string query = "SELECT IFNULL(MAX(member_id), 0) + 1 FROM members;";
            object result = db.ExecuteScalar(query);

            int nextNumber = 1;

            if (result != null && result != DBNull.Value)
            {
                nextNumber = Convert.ToInt32(result);
            }

            return "M" + nextNumber.ToString("D3");
        }

        private void ClearForm()
        {
            selectedMemberId = 0;

            txtMemberCode.Text = GenerateNextMemberCode();
            txtFullName.Clear();
            txtContactNo.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            dtpRegisteredDate.Value = DateTime.Today;
            cmbStatus.Text = "Active";

            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            dgvMembers.ClearSelection();
            txtFullName.Focus();
        }

        private void FormatMembersGrid()
        {
            if (dgvMembers.Columns.Count == 0)
            {
                return;
            }

            dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMembers.RowTemplate.Height = 34;

            if (dgvMembers.Columns.Contains("Member ID"))
            {
                dgvMembers.Columns["Member ID"].Visible = false;
            }

            if (dgvMembers.Columns.Contains("Member Code"))
            {
                dgvMembers.Columns["Member Code"].Width = 95;
            }

            if (dgvMembers.Columns.Contains("Full Name"))
            {
                dgvMembers.Columns["Full Name"].Width = 160;
            }

            if (dgvMembers.Columns.Contains("Contact No"))
            {
                dgvMembers.Columns["Contact No"].Width = 110;
            }

            if (dgvMembers.Columns.Contains("Registered Date"))
            {
                dgvMembers.Columns["Registered Date"].Width = 115;
                dgvMembers.Columns["Registered Date"].DefaultCellStyle.Format = "yyyy-MM-dd";
            }

            if (dgvMembers.Columns.Contains("Status"))
            {
                dgvMembers.Columns["Status"].Width = 85;
            }

            dgvMembers.ClearSelection();
        }
    }
}