using LoanSystem.Src.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanSystem
{
    public partial class formLoanActive : Form
    {


        // Hard Code UI - DataGridView for Loan Active List Dony Toch 
        // Define relative button sizes inside the Actions cell
        private readonly Size _actionBtnSize = new Size(48, 22);
        private readonly int _actionBtnSpacing = 6;

        // Draw three buttons inside the Actions cell
        private void dataGridViewLoanActive_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var actionCol = dataGridViewLoanActive.Columns["ActionCol"]; // safe lookup
            if (actionCol == null) return;
            if (e.ColumnIndex != actionCol.Index) return;
            if (dataGridViewLoanActive.Rows[e.RowIndex].IsNewRow) return;

            e.PaintBackground(e.ClipBounds, true);
            e.PaintContent(e.ClipBounds);

            var cellBounds = e.CellBounds;
            int totalButtonsWidth = (_actionBtnSize.Width * 3) + (_actionBtnSpacing * 2);
            int startX = cellBounds.Left + Math.Max(4, (cellBounds.Width - totalButtonsWidth) / 2);
            int centerY = cellBounds.Top + (cellBounds.Height - _actionBtnSize.Height) / 2;

            System.Drawing.Rectangle btnView = new System.Drawing.Rectangle(startX, centerY, _actionBtnSize.Width, _actionBtnSize.Height);
            System.Drawing.Rectangle btnEdit = new System.Drawing.Rectangle(btnView.Right + _actionBtnSpacing, centerY, _actionBtnSize.Width, _actionBtnSize.Height);
            System.Drawing.Rectangle btnDel = new System.Drawing.Rectangle(btnEdit.Right + _actionBtnSpacing, centerY, _actionBtnSize.Width, _actionBtnSize.Height);

            DrawCellButton(e.Graphics, btnView, "View", Color.SteelBlue);
            DrawCellButton(e.Graphics, btnEdit, "Edit", Color.SeaGreen);
            DrawCellButton(e.Graphics, btnDel, "Del", Color.IndianRed);

            e.Handled = true;
        }

        private void DrawCellButton(Graphics g, System.Drawing.Rectangle bounds, string text, Color backColor)
        {
            using (var b = new SolidBrush(backColor))
            using (var p = new Pen(Color.Transparent))
            using (var fmt = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
            using (var textBrush = new SolidBrush(Color.White))
            {
                var radius = 4;
                using (GraphicsPath path = RoundedRect(bounds, radius))
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    g.FillPath(b, path);
                }
                g.DrawRectangle(Pens.Transparent, bounds);
                g.DrawString(text, new Font("Segoe UI", 8F, FontStyle.Bold), textBrush, bounds, fmt);
            }
        }

        private GraphicsPath RoundedRect(System.Drawing.Rectangle bounds, int radius)
        {
            int d = radius * 2;
            var path = new GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, d, d, 180, 90);
            path.AddArc(bounds.Right - d, bounds.Y, d, d, 270, 90);
            path.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        // Handle clicks on the drawn buttons
        private void dataGridViewLoanActive_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var actionCol = dataGridViewLoanActive.Columns["ActionCol"]; // safe lookup
            if (actionCol == null) return;
            if (e.ColumnIndex != actionCol.Index) return;
            if (dataGridViewLoanActive.Rows[e.RowIndex].IsNewRow) return;

            var cellRect = dataGridViewLoanActive.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

            int totalButtonsWidth = (_actionBtnSize.Width * 3) + (_actionBtnSpacing * 2);
            int startX = cellRect.Left + Math.Max(4, (cellRect.Width - totalButtonsWidth) / 2);
            int centerY = cellRect.Top + (cellRect.Height - _actionBtnSize.Height) / 2;

            System.Drawing.Rectangle btnView = new System.Drawing.Rectangle(startX, centerY, _actionBtnSize.Width, _actionBtnSize.Height);
            System.Drawing.Rectangle btnEdit = new System.Drawing.Rectangle(btnView.Right + _actionBtnSpacing, centerY, _actionBtnSize.Width, _actionBtnSize.Height);
            System.Drawing.Rectangle btnDel = new System.Drawing.Rectangle(btnEdit.Right + _actionBtnSpacing, centerY, _actionBtnSize.Width, _actionBtnSize.Height);

            var clickPoint = dataGridViewLoanActive.PointToClient(Cursor.Position);
            if (btnView.Contains(clickPoint))
            {
                HandleAction(e.RowIndex, "view");
            }
            else if (btnEdit.Contains(clickPoint))
            {
                HandleAction(e.RowIndex, "edit");
            }
            else if (btnDel.Contains(clickPoint))
            {
                HandleAction(e.RowIndex, "delete");
            }
        }

        // Prevent editing in the Actions column (and generally we're in EditProgrammatically)
        private void dataGridViewLoanActive_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            var actionCol = dataGridViewLoanActive.Columns["ActionCol"];
            if (actionCol != null && e.ColumnIndex == actionCol.Index)
            {
                e.Cancel = true;
            }
        }

        // End of Hard Code UI 
        public formLoanActive()
        {
            InitializeComponent();
        }
        // Use a correct SQL Server instance name: in a verbatim string (prefixed with @), a single backslash is correct
        string connectionString = @"Server=DESKTOP-QIOPQ2G\SQLEXPRESS;Database=Testing;Integrated Security=True;";
        exportHelper pdfHelper = new exportHelper();
        private void formLoanActive_Load(object sender, EventArgs e)
        {
            this.ControlBox = false; // Disable the close button
            LoadLoanData();
        }

        public void LoadLoanData()
        {
            try
            {
                dataGridViewLoanActive.Rows.Clear();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
               SELECT [date], [loanNumber], [officer], [amount],
                   [amount] AS [PrincipalAmount], [name], [loanType]
               FROM LoanApplicationInfo";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int rowIndex = dataGridViewLoanActive.Rows.Add();
                            DataGridViewRow row = dataGridViewLoanActive.Rows[rowIndex];

                            row.Cells["DateCol"].Value = Convert.ToDateTime(reader["date"]).ToString("yyyy-MM-dd");
                            row.Cells["LoanNumberCol"].Value = reader["loanNumber"];
                            row.Cells["OfficerCol"].Value = reader["officer"];
                            row.Cells["AmountCol"].Value = reader["amount"];
                            row.Cells["PrincipalAmountCol"].Value = reader["PrincipalAmount"];
                            row.Cells["NameLoanerCol"].Value = reader["name"];
                            row.Cells["LoanTypeCol"].Value = reader["loanType"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }


        private void HandleAction(int rowIndex, string action)
        {
            var row = dataGridViewLoanActive.Rows[rowIndex];
            string loanNumber = Convert.ToString(row.Cells["LoanNumberCol"].Value);
            string name = Convert.ToString(row.Cells["NameLoanerCol"].Value);
            string amount = Convert.ToString(row.Cells["AmountCol"].Value);
            string loanType = Convert.ToString(row.Cells["LoanTypeCol"].Value);

            if (action == "view")
            {
                formViewLoan formViewLoan = new formViewLoan();
                formViewLoan.StartPosition = FormStartPosition.CenterScreen;
                // Populate the schedule BEFORE showing the dialog
                formViewLoan.showLoneList(loanNumber, loanType, name, amount, loanNumber);
                formViewLoan.ShowDialog();
                MessageBox.Show($"Loan Number: {loanNumber}\nName: {name}\nAmount: {amount}\nType: {loanType}", "Loan Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (action == "edit")
            {
                //DatabaseHelper databaseHelper = new DatabaseHelper("DESKTOP-QIOPQ2G\\SQLEXPRESS", "Testing");
                //databaseHelper.LoanType(loanNumber);
                MessageBox.Show($"Edit placeholder for {loanNumber}", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (action == "delete")
            {
                var confirm = MessageBox.Show($"Delete loan {loanNumber}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM LoanApplicationInfo WHERE loanNumber = @loanNumber", conn))
                        {
                            cmd.Parameters.AddWithValue("@loanNumber", loanNumber);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                        LoadLoanData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting record: " + ex.Message);
                    }
                }
            }
        }



        // Simple search/filter across key columns using the text in the search box
        private void searchLoanbtn_Click(object sender, EventArgs e)
        {
            try
            {
                var keyword = textBox1.Text.Trim();
            DatabaseHelper helper = new DatabaseHelper("DESKTOP-QIOPQ2G\\SQLEXPRESS", "Testing");
                helper.SearchLoan(keyword, dataGridViewLoanActive);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed: " + ex.Message);
            }
        }
    }
}
