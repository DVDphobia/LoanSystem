using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoanSystem.Src.Helper
{
    internal class LoanServiceHelper
    {
        string connStr;
        string loanNumber;

        public LoanServiceHelper(string server, string db, string loanNumber)
        {
            connStr = $"Server={server};Database={db};Integrated Security=True;";
            this.loanNumber = loanNumber;
        }

        // Returns loanType or null if not found
        private string GetLoanType()
        {
            using var conn = new SqlConnection(connStr);
            conn.Open();

            using var cmd = new SqlCommand("SELECT loanType FROM LoanApplicationInfo WHERE loanNumber = @ln", conn);
            cmd.Parameters.AddWithValue("@ln", loanNumber);

            var result = cmd.ExecuteScalar();
            return result?.ToString();
        }

        // Returns amount or 0 if not found
        private double GetLoanAmount()
        {
            using var conn = new SqlConnection(connStr);
            conn.Open();

            using var cmd = new SqlCommand("SELECT amount FROM LoanApplicationInfo WHERE loanNumber = @ln", conn);
            cmd.Parameters.AddWithValue("@ln", loanNumber);

            var result = cmd.ExecuteScalar();
            return result != null ? Convert.ToDouble(result) : 0;
        }

        public void CalculateAndFillSchedule(ListView lv)
        {
            lv.Items.Clear();

            string loanType = GetLoanType();
            if (loanType == null)
            {
                MessageBox.Show("Loan not found!");
                return;
            }

            // Hardcoded interest rate and term per loan type (adjust as you want)
            double annualRate = 0;
            int years = 0;

            switch (loanType.ToLower())
            {
                case "personal loan":
                    annualRate = 5.0;
                    years = 3;
                    break;
                case "home loan":
                    annualRate = 3.5;
                    years = 15;
                    break;
                case "car loan":
                    annualRate = 4.0;
                    years = 5;
                    break;
                default:
                    annualRate = 6.0;
                    years = 2;
                    break;
            }

            double principal = GetLoanAmount();
            if (principal <= 0)
            {
                MessageBox.Show("Invalid loan amount!");
                return;
            }

            double monthlyRate = annualRate / 100 / 12;
            int totalMonths = years * 12;
            double monthlyPayment = principal * monthlyRate / (1 - Math.Pow(1 + monthlyRate, -totalMonths));
            double balance = principal;
            DateTime date = DateTime.Now;

            for (int i = 1; i <= totalMonths; i++)
            {
                if (date.DayOfWeek == DayOfWeek.Saturday) date = date.AddDays(2);
                else if (date.DayOfWeek == DayOfWeek.Sunday) date = date.AddDays(1);

                double interest = Math.Round(balance * monthlyRate, 2);
                double principalPaid = Math.Round(monthlyPayment - interest, 2);
                balance = Math.Round(balance - principalPaid, 2);

                var item = new ListViewItem(i.ToString());
                item.SubItems.Add(date.ToString("dd-MM-yyyy"));
                item.SubItems.Add(interest.ToString("0.00"));
                item.SubItems.Add(principalPaid.ToString("0.00"));
                item.SubItems.Add(monthlyPayment.ToString("0.00"));
                item.SubItems.Add(balance.ToString("0.00"));

                lv.Items.Add(item);
                date = date.AddMonths(1);
            }
        }



    }
}