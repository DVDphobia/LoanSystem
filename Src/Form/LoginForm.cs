using System.Data;
using System.Data.SqlClient;

namespace LoanSystem
{
    public partial class LoginForm : Form
    {


        private string connectionString = @"Server=DESKTOP-QIOPQ2G\SQLEXPRESS;Database=UserDB;Integrated Security=True;";
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

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // First check if the credentials are valid
                    string loginQuery = "SELECT FullName, Username FROM Users WHERE Username=@username AND Password=@password";

                    SqlCommand command = new SqlCommand(loginQuery, connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string fullName = reader["FullName"].ToString();
                            string userType = reader["Username"].ToString().ToLower() == "admin" ? "Admin" : "User";

                            // Different behavior for admin vs regular users
                            if (userType == "Admin")
                            {
                                MessageBox.Show($"Welcome ADMINISTRATOR, {fullName}!\nYou have special privileges.");
                                // Open admin dashboard or enable admin features

                                // Open regular user dashboard
                                Dashboard dashboard = new Dashboard();
                                dashboard.UserInfo(fullName, fullName);
                                dashboard.Show();
                            }
                            else
                            {
                                this.Hide();
                                MessageBox.Show($"Welcome, {fullName}!");

                                




                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }



        }
    }
}
