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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Server=DESKTOP-QIOPQ2G\SQLEXPRESS;Database=UserDB;Integrated Security=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string regCommand = "INSERT INTO Users (Username,Password, FullName, Email) VALUES (@Username,@Password, @FullName, @Email)";
                    using (SqlCommand command = new SqlCommand(regCommand, connection))
                    {
                        
                        command.Parameters.AddWithValue("@Username", textBox2.Text);
                        command.Parameters.AddWithValue("@FullName", textBox1.Text);
                        command.Parameters.AddWithValue("@Password", textBox3.Text);
                        command.Parameters.AddWithValue("@Email", textBox4.Text);

                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Registration successful!");
                        }
                        else
                        {
                            MessageBox.Show("Registration failed.");
                        }
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}
