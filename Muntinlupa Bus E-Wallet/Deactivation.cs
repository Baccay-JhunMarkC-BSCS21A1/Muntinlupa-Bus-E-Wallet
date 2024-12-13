using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Muntinlupa_Bus_E_Wallet
{
    public class Deactivation
    {
        public int AccountID { get; set; }
        public string Reason { get; set; }

        public Deactivation(int accountID, string reason)
        {
            AccountID = accountID;
            Reason = reason;
        }

        public static bool DeactivateAccount(int accountID, string reason)
        {
            try
            {
                DatabaseConnection.Connect();

                DatabaseConnection.sql = "UPDATE Accounts SET Status = 'Inactive', DeactivationReason = ? WHERE AccountID = ?";
                DatabaseConnection.cmd = new OleDbCommand(DatabaseConnection.sql, DatabaseConnection.cn);

                DatabaseConnection.cmd.Parameters.Add("?", OleDbType.VarWChar).Value = reason;
                DatabaseConnection.cmd.Parameters.Add("?", OleDbType.Integer).Value = accountID;

                int rowsAffected = DatabaseConnection.cmd.ExecuteNonQuery();

                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deactivating account: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
