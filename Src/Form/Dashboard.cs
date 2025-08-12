using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanSystem
{
    public partial class Dashboard : Form
    {

        formDashboard formDashboards;
        formLoan formLoan;
        formLoanActive formLoanActive;
        public Dashboard()
        {
            InitializeComponent();

            this.MaximizeBox = false;
        }

        private void menuContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Dasboard_Load(object sender, EventArgs e)
        {
            dashboardLoad();
        }

        bool menuExpanded = false;
        bool sidebarExpanded = true;
        

        private void menuTransition_Tick(object sender, EventArgs e)
        {
           
        }

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
        }




        private void dashboardLoad()
        {
            if (formDashboards == null || formDashboards.IsDisposed)
            {
                formDashboards = new formDashboard();
                formDashboards.FormClosed += Dashboard_FormClosed;
                this.IsMdiContainer = true;
                formDashboards.MdiParent = this;
                formDashboards.Dock = DockStyle.Fill;
                formDashboards.Show();
            }
            else
            {
                formDashboards.Activate();
            }
        }



        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formDashboards == null || formDashboards.IsDisposed)
            {
                formDashboards = new formDashboard();
                formDashboards.FormClosed += Dashboard_FormClosed;
                this.IsMdiContainer = true;
                formDashboards.MdiParent = this;
                formDashboards.Dock = DockStyle.Fill;
                formDashboards.Show();
            }
            else
            {
                formDashboards.Activate();
            }

        }

        private void loanApplicationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (formLoan == null || formLoan.IsDisposed)
            {
                formLoan = new formLoan();
                formLoan.FormClosed += Loan_FormClosed;
                this.IsMdiContainer = true;
                formLoan.MdiParent = this;
                formLoan.Dock = DockStyle.Fill;
                formLoan.Show();
            }
            else
            {
                formLoan.Activate();
            }
        }

        private void loanActiveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (formLoanActive == null || formLoanActive.IsDisposed)
            {
                formLoanActive = new formLoanActive();
                formLoanActive.FormClosed += LoanActive_FormClosed;
                this.IsMdiContainer = true;
                formLoanActive.MdiParent = this;
                formLoanActive.Dock = DockStyle.Fill;
                formLoanActive.Show();
            }
            else
            {
                formLoanActive.Activate();
            }
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            formDashboards = null;
        }

        private void Loan_FormClosed(object sender, FormClosedEventArgs e)
        {
            formLoan = null;
        }

        private void LoanActive_FormClosed(object sender, FormClosedEventArgs e)
        {
            formLoanActive = null;
        }
    }
}
