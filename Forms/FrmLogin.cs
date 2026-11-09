using LibraryManagementSystem.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagementSystem.Forms
{
    public partial class FrmLogin : Form
    {
        private readonly DbConnection db = new DbConnection();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
            lblError.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginUser();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginUser();
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void LoginUser()
        {
            lblError.Visible = false;

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username))
            {
                ShowError("Please enter username.");
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                ShowError("Please enter password.");
                txtPassword.Focus();
                return;
            }

            string query = @"
                SELECT user_id, full_name, username, role
                FROM users
                WHERE username = @username AND password = @password
                LIMIT 1;
            ";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@username", username),
                new MySqlParameter("@password", password)
            };

            DataTable dt = db.GetData(query, parameters);

            if (dt.Rows.Count == 1)
            {
                Session.UserId = Convert.ToInt32(dt.Rows[0]["user_id"]);
                Session.FullName = dt.Rows[0]["full_name"].ToString();
                Session.Username = dt.Rows[0]["username"].ToString();
                Session.Role = dt.Rows[0]["role"].ToString();

                FrmMain mainForm = new FrmMain();

                mainForm.FormClosed += (s, args) =>
                {
                    if (!this.IsDisposed)
                    {
                        this.Close();
                    }
                };

                this.Hide();
                mainForm.Show();
            }
            else
            {
                ShowError("Invalid username or password.");
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void ShowError(string message)
        {
            lblError.Text = message;
            lblError.Visible = true;
        }
    }
}