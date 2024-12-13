using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Muntinlupa_Bus_E_Wallet
{
    public class CustomerAccount
    {
        public int AccountID { get; set; }
        public string CustomerName { get; set; }
        public string ContactInfo { get; set; }
        public decimal InitialBalance { get; set; }
        public DateTime ExpirationDate { get; set; }

        public CustomerAccount(string customerName, string contactInfo, decimal initialBalance, DateTime expirationDate)
        {
            CustomerName = customerName;
            ContactInfo = contactInfo;
            InitialBalance = initialBalance;
            ExpirationDate = expirationDate;
        }

        public int GenerateAccountID()
        {
            try
            {
                DatabaseConnection.Connect();
                string sql = "SELECT MAX(AccountID) FROM Accounts";
                OleDbCommand cmd = new OleDbCommand(sql, DatabaseConnection.cn);
                object result = cmd.ExecuteScalar();
                if (result == DBNull.Value)
                    return 1;
                return Convert.ToInt32(result) + 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating AccountID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        public bool AccountExists()
        {
            try
            {
                DatabaseConnection.Connect();
                string sql = "SELECT COUNT(*) FROM Accounts WHERE AccountID = @AccountID";
                OleDbCommand cmd = new OleDbCommand(sql, DatabaseConnection.cn);
                cmd.Parameters.AddWithValue("@AccountID", AccountID);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking if AccountID exists: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool SaveAccount()
        {
            try
            {
                AccountID = GenerateAccountID();
                if (AccountExists())
                {
                    MessageBox.Show("This Account ID already exists. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                DatabaseConnection.Connect();
                string sql = "INSERT INTO Accounts (AccountID, CustomerName, ContactInfo, Balance, ExpirationDate) " +
                             "VALUES (@AccountID, @CustomerName, @ContactInfo, @Balance, @ExpirationDate)";
                OleDbCommand cmd = new OleDbCommand(sql, DatabaseConnection.cn);
                cmd.Parameters.AddWithValue("@AccountID", AccountID);
                cmd.Parameters.AddWithValue("@CustomerName", CustomerName);
                cmd.Parameters.AddWithValue("@ContactInfo", ContactInfo);
                cmd.Parameters.AddWithValue("@Balance", InitialBalance);
                cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationDate.ToString("dd/MM/yyyy"));
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
