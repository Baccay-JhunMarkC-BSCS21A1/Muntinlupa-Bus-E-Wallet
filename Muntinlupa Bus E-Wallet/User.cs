using System;
using System.Data.OleDb;

namespace Muntinlupa_Bus_E_Wallet
{
    internal class User
    {
        public string Username { get; set; }
        public string Password { get; set; }


        public bool Login(string username, string password)
        {
            try
            {
                
                DatabaseConnection.Connect();

                DatabaseConnection.sql = "SELECT * FROM Admins WHERE Username = @username AND Password = @password";
                DatabaseConnection.cmd = new OleDbCommand(DatabaseConnection.sql, DatabaseConnection.cn);

                DatabaseConnection.cmd.Parameters.AddWithValue("@username", username);
                DatabaseConnection.cmd.Parameters.AddWithValue("@password", password);

                DatabaseConnection.dr = DatabaseConnection.cmd.ExecuteReader();

                if (DatabaseConnection.dr.HasRows)
                {
                    
                    return true;
                }
                else
                {
                    Console.WriteLine("Invalid username or password.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error during login: " + ex.Message);
                return false;
            }
            finally
            {
                if (DatabaseConnection.dr != null && !DatabaseConnection.dr.IsClosed)
                {
                    DatabaseConnection.dr.Close();
                }

                if (DatabaseConnection.cn.State == System.Data.ConnectionState.Open)
                {
                    DatabaseConnection.cn.Close();
                }
            }
        }
    }
}
