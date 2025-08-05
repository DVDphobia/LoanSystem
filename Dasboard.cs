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
    public partial class Dasboard : Form
    {
        public Dasboard()
        {
            InitializeComponent();
        }

        private void Dasboard_Load(object sender, EventArgs e)
        {

        }

        bool menuExpanded = false;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (!menuExpanded)
            {
                // Expand
                menuContiner.Height += 10;
                if (menuContiner.Height >= 171)
                {
                    menuTransition.Stop();
                    menuExpanded = true;
                }
            }
            else
            {
                // Collapse
                menuContiner.Height -= 10;
                if (menuContiner.Height <= 51)
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
    }
}
