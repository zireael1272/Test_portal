using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace test_portal.classes
{
    public class DataBaseOperation 
    {
        private readonly OleDbConnection _dbConnection;
        public DataBaseOperation()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/User/Desktop/Test_portal/Test_portal/DB_test.accdb";
            _dbConnection = new OleDbConnection(connectionString);

            try
            {
                _dbConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open database connection: {ex.Message}", "Error");
            }
        }

        public Account GetAccountByUsername(LoginInput input)
        {
            if (_dbConnection.State != System.Data.ConnectionState.Open)
            {
                MessageBox.Show("Database connection is not open.", "Error");
                return null;
            }

            string query = "SELECT UserID, Username, Password, Role FROM Users WHERE Username = ? AND Password = ?";
            try
            {
                using (OleDbCommand dbCommand = new OleDbCommand(query, _dbConnection))
                {
                    dbCommand.Parameters.AddWithValue("Username", input.Username);
                    dbCommand.Parameters.AddWithValue("Password", input.Password);
                    using (OleDbDataReader dbDataReader = dbCommand.ExecuteReader())
                    {
                        if (dbDataReader.Read())
                        {
                            int id = Convert.ToInt32(dbDataReader["UserID"]);
                            string dbUsername = dbDataReader["Username"].ToString();
                            string dbPassword = dbDataReader["Password"].ToString();
                            string dbRole = dbDataReader["Role"].ToString();
                            string dbFirstName = dbDataReader["FirstName"].ToString();
                            string dbLastName = dbDataReader["LastName"].ToString();
                            return new Account(id, dbUsername, dbPassword, dbRole, dbFirstName, dbLastName);
                        }
                        else
                        {
                            MessageBox.Show("User not found!", "Error");
                            return null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to execute query: {ex.Message}", "Error");
                return null;
            }
        }

        public bool RegisterNewAccount(Account newAccount)
        {
            if (_dbConnection.State != System.Data.ConnectionState.Open)
            {
                MessageBox.Show("Database connection is not open.", "Error");
                return false;
            }

            string query = "INSERT INTO Users (Username, [Password], [Role], FirstName, LastName) VALUES (?, ?, ?, ?, ?)";
            try
            {
                using (OleDbCommand dbCommand = new OleDbCommand(query, _dbConnection))
                {
                    dbCommand.Parameters.AddWithValue("Username", newAccount.Username);
                    dbCommand.Parameters.AddWithValue("Password", newAccount.Password);
                    dbCommand.Parameters.AddWithValue("Role", newAccount.Role);
                    dbCommand.Parameters.AddWithValue("FirstName", newAccount.FirstName);
                    dbCommand.Parameters.AddWithValue("LastName", newAccount.LastName);

                    int rowsAffected = dbCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Account registered successfully.", "Success");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Failed to register account.", "Error");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to execute query: {ex.Message}", "Error");
                return false;
            }
        }


    }
}
