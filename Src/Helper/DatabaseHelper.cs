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

        private string connectionString;

        public DatabaseHelper(string server, string db)
        {

            connectionString = $@"Server={server};Database={db};Integrated Security=True;";
        }

        public void InsertLoanApplication(string name,string loanType,string officer,int amount,string witnessType,string witnessName,string country,string city,string nationalID,long phone,string email,string postalCode,string residentialAddress)
        {
            //string connectionString = "Server=DESKTOP-QIOPQ2G\\SQLEXPRESS ;Database=Testing;Trusted_Connection=True;"; // <-- change to your DB info

            string query = @"
        INSERT INTO LoanApplicationInfo 
        (name, loanType, officer, amount, witnessType, witnessName, country, city, nationalID, phone, email, postalCode, ResidentialAddress)
        VALUES 
        (@name, @loanType, @officer, @amount, @witnessType, @witnessName, @country, @city, @nationalID, @phone, @email, @postalCode, @residentialAddress)";

            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@loanType", loanType);
                cmd.Parameters.AddWithValue("@officer", officer);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@witnessType", witnessType);
                cmd.Parameters.AddWithValue("@witnessName", witnessName);
                cmd.Parameters.AddWithValue("@country", country);
                cmd.Parameters.AddWithValue("@city", city);
                cmd.Parameters.AddWithValue("@nationalID", nationalID);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@postalCode", postalCode);
                cmd.Parameters.AddWithValue("@residentialAddress", residentialAddress);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }


        public string login(string username, string password)
        {
            string query = $"SELECT Role FROM Users WHERE Username = @Username AND Password = @Password";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    connection.Open();
                    object result = command.ExecuteScalar();

                    return result?.ToString(); // Returns role or null if not found
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login error: {ex.Message}");
                return null;
            }

           
        }
        public bool register(string username, string password, string email)
        {
            string query = @"INSERT INTO Users (username, password, email) 
                     VALUES (@Username, @Password, @Email)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Email", email);
                    

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0; // true if inserted
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"SQL Error: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }
        }


        public void SearchLoan(string keyword, DataGridView dgv)
        {
            string query = @"
        SELECT [date], [loanNumber], [officer], [amount], 
               [amount] AS [PrincipalAmount], [name], [loanType], 
               'N/A' AS [repayment] 
        FROM LoanApplicationInfo 
        WHERE loanNumber LIKE @keyword
           OR name LIKE @keyword
           OR officer LIKE @keyword";

            try
            {
                dgv.Rows.Clear();

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int rowIndex = dgv.Rows.Add();
                            DataGridViewRow row = dgv.Rows[rowIndex];

                            row.Cells["DateCol"].Value = reader["date"] == DBNull.Value
                                ? ""
                                : Convert.ToDateTime(reader["date"]).ToString("yyyy-MM-dd");

                            row.Cells["LoanNumberCol"].Value = reader["loanNumber"] == DBNull.Value ? "" : reader["loanNumber"];
                            row.Cells["OfficerCol"].Value = reader["officer"] == DBNull.Value ? "" : reader["officer"];
                            row.Cells["AmountCol"].Value = reader["amount"] == DBNull.Value ? "" : reader["amount"];
                            row.Cells["PrincipalAmountCol"].Value = reader["PrincipalAmount"] == DBNull.Value ? "" : reader["PrincipalAmount"];
                            row.Cells["NameLoanerCol"].Value = reader["name"] == DBNull.Value ? "" : reader["name"];
                            row.Cells["LoanTypeCol"].Value = reader["loanType"] == DBNull.Value ? "" : reader["loanType"];
                            row.Cells["RepaymentCol"].Value = reader["repayment"] == DBNull.Value ? "" : reader["repayment"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Search error: {ex.Message}\n\n{ex.StackTrace}");
            }
        }

        



    }
}
