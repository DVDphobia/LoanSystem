using LoanSystem.Src.Helper;
using Microsoft.VisualBasic.ApplicationServices;
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

        private void Submitbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string CustomerName = textBoxCustomerName.Text;
                string LoanType = comboBoxLoanType.Text;
                string Officer = textBoxLoanOfficer.Text;
                int amount = int.Parse(textBoxAmount.Text);
                string witnessType = textBoxWitnessType.Text;
                string withnessName = textBoxWitnessName.Text;
                string country = textBoxCountry.Text;
                string city = textBoxCity.Text;
                string nationalID = textBoxNationalid.Text;
                long phone = long.Parse(textBoxPhone.Text);
                string email = textBoxEmail.Text;
                string postalCode = textBoxPostalCode.Text;
                string residentialAddress = textBoxResidentialAddress.Text;
                //; Database = UserDB
                DatabaseHelper databaseHelper = new DatabaseHelper("DESKTOP-QIOPQ2G\\SQLEXPRESS", "Testing");
                databaseHelper.InsertLoanApplication(CustomerName, LoanType, Officer, amount, witnessType, withnessName, country, city, nationalID, phone, email, postalCode, residentialAddress);

                // Refresh the active list if it's open (use the displayed instance)
                var formLoanActive = Application.OpenForms.OfType<formLoanActive>().FirstOrDefault();
                if (formLoanActive != null && !formLoanActive.IsDisposed)
                {
                    formLoanActive.LoadLoanData();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please fill in all required fields!");

            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


    }
}
