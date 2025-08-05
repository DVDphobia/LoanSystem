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
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dasboard_Load(object sender, EventArgs e)
        {

        }

        bool menuExpanded = false;
        bool sidebarExpanded = true;
        public string UserInfo(string Uname, string Utype)
        {
            labelUserType.Text = Utype;
            return labelUserType.Text;
        }

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (!menuExpanded)
            {
                // Expand
                menuContainer.Height += 10;
                if (menuContainer.Height >= 171)
                {
                    menuTransition.Stop();
                    menuExpanded = true;

                }
            }
            else
            {
                // Collapse
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 56)
                {
                    menuTransition.Stop();
                    menuExpanded = false;

                }
            }
        }


        private void ClientBtn_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpanded)
            {
                // Collapse
                sidebar.Width -= 10;
                if (sidebar.Width <= 68)
                {
                    sidebarExpanded = false;
                    sidebarTransition.Stop();

                    pnDashboard.Width = 58;
                    pnReport.Width = 58;
                    pnClient.Width = 58;


                }
            }
            else
            {
                // Expand
                sidebar.Width += 10;
                if (sidebar.Width >= 231)
                {
                    sidebarExpanded = true;
                    sidebarTransition.Stop();
                    pnDashboard.Width = 221;
                    pnReport.Width = 221;
                    pnRepayAndPay.Width = 219;
                    pnClient.Width = 219;
                    
                    
                }
            }
        }


        private void humberger_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }



        private void dashboardBtn_Click(object sender, EventArgs e)
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

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            formDashboards = null;
        }

        private void menuContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
