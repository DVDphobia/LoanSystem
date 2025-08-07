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
    public partial class formLoan : Form
    {
        public formLoan()
        {
            InitializeComponent();
        }

        private void formLoan_Load(object sender, EventArgs e)
        {
            this.ControlBox = false; // Disable the close button
            
        }
    }
}
