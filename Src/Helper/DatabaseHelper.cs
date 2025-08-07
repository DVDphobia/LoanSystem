using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LoanSystem.Src.Helper
{
    internal class DatabaseHelper
    {
        string connectionString = @"Server=DESKTOP-QIOPQ2G\SQLEXPRESS;Database=UserDB;Integrated Security=True;";
        public void ConnectToDatabase(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Connection to database established successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while connecting to the database: {ex.Message}");
            }
        }
    }
}
