using LibraryManagementSystem.Classes;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagementSystem.Forms
{
    public partial class FrmBooks : Form
    {
        private readonly DbConnection db = new DbConnection();
        private int selectedBookId = 0;

        public FrmBooks()
        {
            InitializeComponent();
        }

        private void FrmBooks_Load(object sender, EventArgs e)
        {
            LoadBooks();
            ClearForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddBook();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateBook();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteBook();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadBooks();
            ClearForm();
        }

        private void btnGenerateCode_Click(object sender, EventArgs e)
        {
            txtBookCode.Text = GenerateNextBookCode();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadBooks(txtSearch.Text.Trim());
        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvBooks.Rows[e.RowIndex].Cells["Book ID"].Value != null)
            {
                DataGridViewRow row = dgvBooks.Rows[e.RowIndex];

                selectedBookId = Convert.ToInt32(row.Cells["Book ID"].Value);
                txtBookCode.Text = row.Cells["Book Code"].Value.ToString();
                txtTitle.Text = row.Cells["Title"].Value.ToString();
                txtAuthor.Text = row.Cells["Author"].Value.ToString();
                cmbCategory.Text = row.Cells["Category"].Value.ToString();
                txtPublisher.Text = row.Cells["Publisher"].Value.ToString();
                txtISBN.Text = row.Cells["ISBN"].Value.ToString();
                txtShelfLocation.Text = row.Cells["Shelf"].Value.ToString();

                nudTotalQty.Value = Convert.ToDecimal(row.Cells["Total Qty"].Value);
                nudAvailableQty.Value = Convert.ToDecimal(row.Cells["Available Qty"].Value);

                cmbStatus.Text = row.Cells["Status"].Value.ToString();

                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void nudTotalQty_ValueChanged(object sender, EventArgs e)
        {
            if (nudAvailableQty.Value > nudTotalQty.Value)
            {
                nudAvailableQty.Value = nudTotalQty.Value;
            }

            UpdateStatusByQuantity();
        }

        private void nudAvailableQty_ValueChanged(object sender, EventArgs e)
        {
            if (nudAvailableQty.Value > nudTotalQty.Value)
            {
                nudAvailableQty.Value = nudTotalQty.Value;
            }

            UpdateStatusByQuantity();
        }

        private void LoadBooks(string searchText = "")
        {
            string query = @"
                SELECT 
                    book_id AS 'Book ID',
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
                    isbn LIKE @search
                ORDER BY book_id DESC;
            ";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@search", "%" + searchText + "%")
            };

            DataTable dt = db.GetData(query, parameters);
            dgvBooks.DataSource = dt;

            FormatBooksGrid();
        }

        private void AddBook()
        {
            if (!ValidateForm())
            {
                return;
            }

            if (IsBookCodeExists(txtBookCode.Text.Trim(), 0))
            {
                MessageBox.Show(
                    "This book code already exists. Please use another code.",
                    "Duplicate Book Code",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txtBookCode.Focus();
                return;
            }

            int totalQty = Convert.ToInt32(nudTotalQty.Value);
            int availableQty = Convert.ToInt32(nudAvailableQty.Value);
            string status = availableQty > 0 ? "Available" : "Not Available";

            string query = @"
                INSERT INTO books
                (book_code, title, author, category, publisher, isbn, shelf_location, total_quantity, available_quantity, status)
                VALUES
                (@book_code, @title, @author, @category, @publisher, @isbn, @shelf_location, @total_quantity, @available_quantity, @status);
            ";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@book_code", txtBookCode.Text.Trim()),
                new MySqlParameter("@title", txtTitle.Text.Trim()),
                new MySqlParameter("@author", txtAuthor.Text.Trim()),
                new MySqlParameter("@category", cmbCategory.Text.Trim()),
                new MySqlParameter("@publisher", txtPublisher.Text.Trim()),
                new MySqlParameter("@isbn", txtISBN.Text.Trim()),
                new MySqlParameter("@shelf_location", txtShelfLocation.Text.Trim()),
                new MySqlParameter("@total_quantity", totalQty),
                new MySqlParameter("@available_quantity", availableQty),
                new MySqlParameter("@status", status)
            };

            int rows = db.ExecuteQuery(query, parameters);

            if (rows > 0)
            {
                MessageBox.Show(
                    "Book added successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadBooks();
                ClearForm();
            }
        }

        private void UpdateBook()
        {
            if (selectedBookId == 0)
            {
                MessageBox.Show(
                    "Please select a book to update.",
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

            if (IsBookCodeExists(txtBookCode.Text.Trim(), selectedBookId))
            {
                MessageBox.Show(
                    "This book code already belongs to another book.",
                    "Duplicate Book Code",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txtBookCode.Focus();
                return;
            }

            int totalQty = Convert.ToInt32(nudTotalQty.Value);
            int availableQty = Convert.ToInt32(nudAvailableQty.Value);
            string status = availableQty > 0 ? "Available" : "Not Available";

            string query = @"
                UPDATE books
                SET 
                    book_code = @book_code,
                    title = @title,
                    author = @author,
                    category = @category,
                    publisher = @publisher,
                    isbn = @isbn,
                    shelf_location = @shelf_location,
                    total_quantity = @total_quantity,
                    available_quantity = @available_quantity,
                    status = @status
                WHERE book_id = @book_id;
            ";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@book_code", txtBookCode.Text.Trim()),
                new MySqlParameter("@title", txtTitle.Text.Trim()),
                new MySqlParameter("@author", txtAuthor.Text.Trim()),
                new MySqlParameter("@category", cmbCategory.Text.Trim()),
                new MySqlParameter("@publisher", txtPublisher.Text.Trim()),
                new MySqlParameter("@isbn", txtISBN.Text.Trim()),
                new MySqlParameter("@shelf_location", txtShelfLocation.Text.Trim()),
                new MySqlParameter("@total_quantity", totalQty),
                new MySqlParameter("@available_quantity", availableQty),
                new MySqlParameter("@status", status),
                new MySqlParameter("@book_id", selectedBookId)
            };

            int rows = db.ExecuteQuery(query, parameters);

            if (rows > 0)
            {
                MessageBox.Show(
                    "Book updated successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadBooks();
                ClearForm();
            }
        }

        private void DeleteBook()
        {
            if (selectedBookId == 0)
            {
                MessageBox.Show(
                    "Please select a book to delete.",
                    "Selection Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (BookHasIssueRecords(selectedBookId))
            {
                MessageBox.Show(
                    "This book cannot be deleted because it has issue/return history records.",
                    "Delete Not Allowed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this book?",
                "Delete Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result != DialogResult.Yes)
            {
                return;
            }

            string query = "DELETE FROM books WHERE book_id = @book_id;";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@book_id", selectedBookId)
            };

            int rows = db.ExecuteQuery(query, parameters);

            if (rows > 0)
            {
                MessageBox.Show(
                    "Book deleted successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadBooks();
                ClearForm();
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtBookCode.Text))
            {
                MessageBox.Show("Please enter book code.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBookCode.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Please enter book title.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitle.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAuthor.Text))
            {
                MessageBox.Show("Please enter author name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAuthor.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbCategory.Text))
            {
                MessageBox.Show("Please enter or select category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCategory.Focus();
                return false;
            }

            if (nudTotalQty.Value < 1)
            {
                MessageBox.Show("Total quantity must be at least 1.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudTotalQty.Focus();
                return false;
            }

            if (nudAvailableQty.Value < 0)
            {
                MessageBox.Show("Available quantity cannot be negative.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudAvailableQty.Focus();
                return false;
            }

            if (nudAvailableQty.Value > nudTotalQty.Value)
            {
                MessageBox.Show("Available quantity cannot be greater than total quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudAvailableQty.Focus();
                return false;
            }

            return true;
        }

        private bool IsBookCodeExists(string bookCode, int currentBookId)
        {
            string query = @"
                SELECT COUNT(*) 
                FROM books 
                WHERE book_code = @book_code AND book_id <> @book_id;
            ";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@book_code", bookCode),
                new MySqlParameter("@book_id", currentBookId)
            };

            object result = db.ExecuteScalar(query, parameters);
            return Convert.ToInt32(result) > 0;
        }

        private bool BookHasIssueRecords(int bookId)
        {
            string query = "SELECT COUNT(*) FROM issue_records WHERE book_id = @book_id;";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@book_id", bookId)
            };

            object result = db.ExecuteScalar(query, parameters);
            return Convert.ToInt32(result) > 0;
        }

        private string GenerateNextBookCode()
        {
            string query = "SELECT IFNULL(MAX(book_id), 0) + 1 FROM books;";
            object result = db.ExecuteScalar(query);

            int nextNumber = 1;

            if (result != null && result != DBNull.Value)
            {
                nextNumber = Convert.ToInt32(result);
            }

            return "B" + nextNumber.ToString("D3");
        }

        private void UpdateStatusByQuantity()
        {
            cmbStatus.Text = nudAvailableQty.Value > 0 ? "Available" : "Not Available";
        }

        private void ClearForm()
        {
            selectedBookId = 0;

            txtBookCode.Text = GenerateNextBookCode();
            txtTitle.Clear();
            txtAuthor.Clear();
            cmbCategory.SelectedIndex = -1;
            cmbCategory.Text = "";
            txtPublisher.Clear();
            txtISBN.Clear();
            txtShelfLocation.Clear();

            nudTotalQty.Value = 1;
            nudAvailableQty.Value = 1;
            cmbStatus.Text = "Available";

            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            dgvBooks.ClearSelection();
            txtTitle.Focus();
        }

        private void FormatBooksGrid()
        {
            if (dgvBooks.Columns.Count == 0)
            {
                return;
            }

            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.RowTemplate.Height = 34;

            if (dgvBooks.Columns.Contains("Book ID"))
            {
                dgvBooks.Columns["Book ID"].Visible = false;
            }

            if (dgvBooks.Columns.Contains("Book Code"))
            {
                dgvBooks.Columns["Book Code"].Width = 90;
            }

            if (dgvBooks.Columns.Contains("Title"))
            {
                dgvBooks.Columns["Title"].Width = 180;
            }

            if (dgvBooks.Columns.Contains("Author"))
            {
                dgvBooks.Columns["Author"].Width = 130;
            }

            if (dgvBooks.Columns.Contains("Total Qty"))
            {
                dgvBooks.Columns["Total Qty"].Width = 80;
            }

            if (dgvBooks.Columns.Contains("Available Qty"))
            {
                dgvBooks.Columns["Available Qty"].Width = 95;
            }

            dgvBooks.ClearSelection();
        }
    }
}