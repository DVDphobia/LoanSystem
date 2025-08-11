using LoanSystem.Src.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LoanSystem
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e){}


        private void textBox3_TextChanged(object sender, EventArgs e){}

        private void textBox4_TextChanged(object sender, EventArgs e){}

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseHelper databaseHelper = new DatabaseHelper("DESKTOP-QIOPQ2G\\SQLEXPRESS", "Testing");

            try
            {
                databaseHelper.register(textBox1.Text, textBox3.Text, textBox4.Text);
                MessageBox.Show("Register Account Succesfully");
                this.Hide();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "SQL Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Register Error");
            }



        }

    }
}
