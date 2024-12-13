using System;
using System.Windows.Forms;

namespace Muntinlupa_Bus_E_Wallet
{
    public class Accounts
    {
        public int AccountID { get; set; }
        public string CustomerName { get; set; }
        public string ContactInfo { get; set; }
        public decimal InitialBalance { get; set; }
        public DateTime Expiration { get; set; }
        public string Status { get; set; }

        
        public Accounts(int accountId, string customerName, string contactInfo, decimal initialBalance, DateTime expiration, string status = "Active")
        {
            AccountID = accountId;
            CustomerName = customerName;
            ContactInfo = contactInfo;
            InitialBalance = initialBalance;
            Expiration = expiration;
            Status = status;
        }

        
        public static bool AddNewAccount(Accounts account)
        {
            try
            {
                using (var cn = new System.Data.OleDb.OleDbConnection(DatabaseConnection.cn.ConnectionString))
                {
                    cn.Open();
                    string sql = "INSERT INTO Accounts (AccountID, CustomerName, ContactInfo, Balance, ExpirationDate, Status) VALUES (@AccountID, @CustomerName, @ContactInfo, @Balance, @ExpirationDate, @Status)";
                    using (var cmd = new System.Data.OleDb.OleDbCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@AccountID", account.AccountID);
                        cmd.Parameters.AddWithValue("@CustomerName", account.CustomerName);
                        cmd.Parameters.AddWithValue("@ContactInfo", account.ContactInfo);
                        cmd.Parameters.AddWithValue("@Balance", account.InitialBalance);
                        cmd.Parameters.AddWithValue("@ExpirationDate", account.Expiration.ToString("dd/MM/yyyy"));
                        cmd.Parameters.AddWithValue("@Status", account.Status);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving account: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static int GenerateAccountID()
        {
            int accountId;
            bool isUnique;

            do
            {
                Random rnd = new Random();
                accountId = rnd.Next(100000, 999999);

                isUnique = CheckIfAccountIDIsUnique(accountId);
            } while (!isUnique);

            return accountId;
        }

        private static bool CheckIfAccountIDIsUnique(int accountId)
        {
            try
            {
                using (var cn = new System.Data.OleDb.OleDbConnection(DatabaseConnection.cn.ConnectionString))
                {
                    cn.Open();
                    string sql = "SELECT COUNT(*) FROM Accounts WHERE AccountID = @AccountID";
                    using (var cmd = new System.Data.OleDb.OleDbCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@AccountID", accountId);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count == 0; 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error validating AccountID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public static DateTime CalculateExpiration()
        {
            return DateTime.Now.AddYears(1);
        }
    }
}
