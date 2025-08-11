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

namespace LoanSystem
{
    public partial class formViewLoan : Form
    {
        public formViewLoan()
        {
            InitializeComponent();
        }

        private void formViewLoan_Load(object sender, EventArgs e)
        {


        }


        public void showLoneList(string LoanNumber, string loanType, string name , string amount, string nID)
        {
            var loanServiceHelper = new LoanServiceHelper("DESKTOP-QIOPQ2G\\SQLEXPRESS", "Testing", LoanNumber);
            labelName.Text = name;
            labelLoanType.Text = loanType;
            labelNationalID.Text = nID;
            labelLoanAmount.Text = amount;
            loanServiceHelper.CalculateAndFillSchedule(listView1);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
