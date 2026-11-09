using LibraryManagementSystem.Classes;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LibraryManagementSystem.Forms
{
    public partial class FrmMain : Form
    {
        private Form activeForm = null;
        private Button activeButton = null;
        private bool isLoggingOut = false;

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lblUserName.Text = string.IsNullOrEmpty(Session.FullName) ? "System Administrator" : Session.FullName;
            lblUserRole.Text = string.IsNullOrEmpty(Session.Role) ? "Admin" : Session.Role;
            lblDateTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");

            OpenChildForm(new FrmDashboard());
            ActivateMenuButton(btnDashboard);
            lblPageTitle.Text = "Dashboard";
        }

        private void pnlTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDashboard());
            ActivateMenuButton(btnDashboard);
            lblPageTitle.Text = "Dashboard";
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmBooks());
            ActivateMenuButton(btnBooks);
            lblPageTitle.Text = "Book Management";
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmMembers());
            ActivateMenuButton(btnMembers);
            lblPageTitle.Text = "Member Management";
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmIssueBook());
            ActivateMenuButton(btnIssueBook);
            lblPageTitle.Text = "Issue Book";
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmReturnBook());
            ActivateMenuButton(btnReturnBook);
            lblPageTitle.Text = "Return Book";
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmReports());
            ActivateMenuButton(btnReports);
            lblPageTitle.Text = "Reports";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                isLoggingOut = true;
                Session.Clear();

                FrmLogin loginForm = new FrmLogin();
                loginForm.Show();

                this.Close();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit the system?",
                "Exit Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isLoggingOut)
            {
                return;
            }

            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to exit the system?",
                    "Exit Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }

                Application.Exit();
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm.Dispose();
            }

            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(childForm);
            pnlContent.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

        private void ActivateMenuButton(Button selectedButton)
        {
            if (activeButton != null)
            {
                ResetMenuButton(activeButton);
            }

            activeButton = selectedButton;

            selectedButton.BackColor = Color.FromArgb(37, 99, 235);
            selectedButton.ForeColor = Color.White;
            selectedButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        }

        private void ResetMenuButton(Button button)
        {
            button.BackColor = Color.FromArgb(15, 23, 42);
            button.ForeColor = Color.FromArgb(203, 213, 225);
            button.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
        }
    }
}