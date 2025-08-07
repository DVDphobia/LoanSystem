using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanSystem
{
    public partial class formDashboard : Form
    {
        public formDashboard()
        {
            InitializeComponent();
        }

        private void formDashboard_Load(object sender, EventArgs e)
        {
            this.ControlBox = false; // Disable the close button
            ResizePanels();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            ResizePanels();
        }

        private void ResizePanels()
        {
            if (dashboardContainer != null)
            {
                int containerWidth = dashboardContainer.Width - 12; // Account for margins
                int panelWidth = (containerWidth - 30) / 4; // 4 panels with spacing
                int spacing = 6;

                pnBranches.Size = new Size(panelWidth, 77);
                pnBranches.Location = new Point(6, 28);

                pnEmployee.Size = new Size(panelWidth, 77);
                pnEmployee.Location = new Point(pnBranches.Right + spacing, 28);

                pnPendingApplication.Size = new Size(panelWidth, 77);
                pnPendingApplication.Location = new Point(pnEmployee.Right + spacing, 28);

                pnActiveLoan.Size = new Size(panelWidth, 77);
                pnActiveLoan.Location = new Point(pnPendingApplication.Right + spacing, 28);
            }
        }
    }
}