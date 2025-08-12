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
            const string query = "SELECT 1 FROM Users WHERE Username = @Username AND Password = @Password";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    connection.Open();
                    object result = command.ExecuteScalar();

                    return result != null ? "success" : "failed";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login error: {ex.Message}");
                return "failed";
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
            try
            {
                dgv.Rows.Clear();

                string query;
                using var conn = new SqlConnection(connectionString);
                using var cmd = new SqlCommand();
                cmd.Connection = conn;

                if (string.IsNullOrWhiteSpace(keyword))
                {
                    // Load all loans
                    query = @"SELECT [date], [loanNumber], [officer], [amount], [amount] AS [PrincipalAmount], 
                             [name], [loanType]
                      FROM LoanApplicationInfo
                      ORDER BY [date] DESC";
                }
                else if (long.TryParse(keyword, out long num))
                {
                    // Search numeric safely — works even if columns are varchar
                    query = @"SELECT [date], [loanNumber], [officer], [amount], [amount] AS [PrincipalAmount], 
                             [name], [loanType]
                      FROM LoanApplicationInfo
                      WHERE TRY_CAST(loanNumber AS bigint) = @loanNumber 
                         OR TRY_CAST(amount AS bigint) = @amount
                      ORDER BY [date] DESC";

                    cmd.Parameters.AddWithValue("@loanNumber", num);
                    cmd.Parameters.AddWithValue("@amount", num);
                }
                else
                {
                    // Search text
                    query = @"SELECT [date], [loanNumber], [officer], [amount], [amount] AS [PrincipalAmount], 
                             [name], [loanType]
                      FROM LoanApplicationInfo
                      WHERE name LIKE @name
                      ORDER BY [date] DESC";

                    cmd.Parameters.AddWithValue("@name", "%" + keyword + "%");
                }

                cmd.CommandText = query;
                conn.Open();

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dgv.Rows.Add(
                        reader["date"] == DBNull.Value ? "" : Convert.ToDateTime(reader["date"]).ToString("yyyy-MM-dd"),
                        reader["loanNumber"] == DBNull.Value ? "" : reader["loanNumber"],
                        reader["officer"] == DBNull.Value ? "" : reader["officer"],
                        reader["amount"] == DBNull.Value ? "" : reader["amount"],
                        reader["PrincipalAmount"] == DBNull.Value ? "" : reader["PrincipalAmount"],
                        reader["name"] == DBNull.Value ? "" : reader["name"],
                        reader["loanType"] == DBNull.Value ? "" : reader["loanType"]
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Search error: {ex.Message}");
            }
        }


    }
}
