using LoanSystem.Src.Helper;
using System.Data;
using System.Data.SqlClient;

namespace LoanSystem
{
    public partial class LoginForm : Form
    {


        
        public LoginForm()
        { 
            InitializeComponent();
        }

        private void Username_TextChanged(object sender, EventArgs e){}
        private void textBox1_TextChanged(object sender, EventArgs e){}

        private void Register_Click(object sender, EventArgs e)
        {
            this.Hide(); // Just hide the login form
            using (RegisterForm registerForm = new RegisterForm())
            {
                registerForm.ShowDialog();
            }
            this.Show(); // Show login form again after register form is closed
        }


        private void Login_Click(object sender, EventArgs e)
        {
            string username = Username.Text.Trim();
            string password = Password.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password");
                return;
            }
            DatabaseHelper databaseHelper = new DatabaseHelper("DESKTOP-QIOPQ2G\\SQLEXPRESS", "Testing");
            try
            {

                string role = databaseHelper.login(username, password);
                if (!string.IsNullOrEmpty(role))
                {
                    MessageBox.Show("Login SUS");
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "SQL ERROR");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Login Error");
            }



        }
    }
}
