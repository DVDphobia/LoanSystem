using LoanSystem.Src.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoanSystem
{
    public partial class formViewLoan : Form
    {
        private string _loanNumber;
    private LoanServiceHelper _loanServiceHelper; // schedule helper
    private bool _loading = false; // to avoid re-saving while marking paid

        public formViewLoan()
        {
            InitializeComponent();
        }

        private void formViewLoan_Load(object sender, EventArgs e)
        {


        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        public void showLoneList(string LoanNumber, string loanType, string name , string amount, string nID)
        {
            _loanServiceHelper = new LoanServiceHelper("DESKTOP-QIOPQ2G\\SQLEXPRESS", "Testing", LoanNumber);
            _loanNumber = LoanNumber;
            labelName.Text = name;
            labelLoanType.Text = loanType;
            labelNationalID.Text = nID;
            labelLoanAmount.Text = amount;
            _loading = true;
            _loanServiceHelper.CalculateAndFillSchedule(listView1);
            MarkAlreadyPaid();
            _loading = false;
        }

        // Very simple: when a row is checked we insert a payment. No auto-load, no duplicate check.
        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (_loading) return; // ignore programmatic changes
            if (e.Item == null || string.IsNullOrWhiteSpace(_loanNumber)) return;
            if (!e.Item.Checked) return; // ignore uncheck for simplicity
            string amountStr = e.Item.SubItems.Count > 4 ? e.Item.SubItems[4].Text : "0";
            if (!decimal.TryParse(amountStr, out var amt)) return;
            string dateStr = e.Item.SubItems.Count > 1 ? e.Item.SubItems[1].Text : DateTime.Now.ToString("yyyy-MM-dd");
            if (!DateTime.TryParse(dateStr, out var payDate)) payDate = DateTime.Now;
            try
            {
                using var conn = new System.Data.SqlClient.SqlConnection("Server=DESKTOP-QIOPQ2G\\SQLEXPRESS;Database=Testing;Integrated Security=True;");
                conn.Open();
                // Ensure table
                var createSql = @"IF OBJECT_ID('dbo.PaymentHistory','U') IS NULL
BEGIN
    CREATE TABLE dbo.PaymentHistory(
        id INT IDENTITY PRIMARY KEY,
        loanNumber NVARCHAR(50) NOT NULL,
        [date] DATETIME NOT NULL,
        amount DECIMAL(18,2) NOT NULL
    );
END";
                using (var createCmd = new SqlCommand(createSql, conn))
                    createCmd.ExecuteNonQuery();
                // Check duplicate (same loan + date)
                using (var dupCmd = new SqlCommand("SELECT COUNT(*) FROM dbo.PaymentHistory WHERE loanNumber=@ln AND CONVERT(date,[date])=CONVERT(date,@d)", conn))
                {
                    dupCmd.Parameters.AddWithValue("@ln", _loanNumber);
                    dupCmd.Parameters.AddWithValue("@d", payDate);
                    int count = Convert.ToInt32(dupCmd.ExecuteScalar());
                    if (count > 0) return; // already saved
                }
                using (var ins = new SqlCommand("INSERT INTO dbo.PaymentHistory(loanNumber,[date],amount) VALUES(@ln,@d,@a)", conn))
                {
                    ins.Parameters.AddWithValue("@ln", _loanNumber);
                    ins.Parameters.AddWithValue("@d", payDate);
                    ins.Parameters.AddWithValue("@a", amt);
                    ins.ExecuteNonQuery();
                }
            }
            catch { /* keep silent for simple demo */ }
        }

        private void MarkAlreadyPaid()
        {
            if (string.IsNullOrWhiteSpace(_loanNumber)) return;
            try
            {
                using var conn = new SqlConnection("Server=DESKTOP-QIOPQ2G\\SQLEXPRESS;Database=Testing;Integrated Security=True;");
                string sql = @"IF OBJECT_ID('dbo.PaymentHistory','U') IS NULL SELECT CAST(NULL AS datetime) AS [date] WHERE 1=0 ELSE SELECT [date] FROM dbo.PaymentHistory WHERE loanNumber=@ln";
                using var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ln", _loanNumber);
                conn.Open();
                var paidDates = new HashSet<DateTime>();
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        if (rdr.IsDBNull(0)) break;
                        paidDates.Add(Convert.ToDateTime(rdr[0]).Date);
                    }
                }
                if (paidDates.Count == 0) return;
                foreach (ListViewItem it in listView1.Items)
                {
                    if (it.SubItems.Count > 1 && DateTime.TryParse(it.SubItems[1].Text, out var d))
                    {
                        if (paidDates.Contains(d.Date)) it.Checked = true; // _loading true so no save
                    }
                }
            }
            catch { }
        }
        private void btnViewHistory_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_loanNumber)) { MessageBox.Show("No loan."); return; }
            var sb = new StringBuilder();
            sb.AppendLine("Payment History");
            sb.AppendLine("Date\tAmount");
            try
            {
                using var conn = new SqlConnection("Server=DESKTOP-QIOPQ2G\\SQLEXPRESS;Database=Testing;Integrated Security=True;");
                string sql = "IF OBJECT_ID('dbo.PaymentHistory','U') IS NULL SELECT CAST(NULL AS datetime) AS [date],CAST(NULL AS decimal(18,2)) AS amount WHERE 1=0 ELSE SELECT [date],[amount] FROM dbo.PaymentHistory WHERE loanNumber=@ln ORDER BY [date]";
                using var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ln", _loanNumber);
                conn.Open();
                using var rdr = cmd.ExecuteReader();
                int c = 0;
                while (rdr.Read())
                {
                    if (rdr.IsDBNull(0)) break;
                    var d = Convert.ToDateTime(rdr[0]);
                    string a = rdr[1]?.ToString() ?? "";
                    sb.AppendLine(d.ToString("yyyy-MM-dd") + "\t" + a);
                    c++;
                }
                if (c == 0) sb.AppendLine("(none)");
            }
            catch { sb.AppendLine("(error)"); }
            MessageBox.Show(sb.ToString(), "History");
        }



        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            var exporter = new exportHelper();
            exporter.ExportListViewToPdf(
                listView1,
                $"{labelName.Text} Schedule",
                $"Name: {labelName.Text}",
                $"Loan ID: {_loanNumber}",
                $"Loan Type: {labelLoanType.Text}",
                $"National ID: {labelNationalID.Text}",
                $"Loan Amount: {labelLoanAmount.Text}"
            );
        }


    }
}
