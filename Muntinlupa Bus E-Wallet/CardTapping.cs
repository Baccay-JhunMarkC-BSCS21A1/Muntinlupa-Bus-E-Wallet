using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Muntinlupa_Bus_E_Wallet
{
    public class CardTapping
    {
        public int CardID { get; set; }
        public string ActionType { get; set; }
        public string Location { get; set; }
        public decimal FareDeduction { get; set; }

        public CardTapping(int cardID, string actionType, string location)
        {
            CardID = cardID;
            ActionType = actionType;
            Location = location;

            FareDeduction = ActionType == "Pickup" ? 50.00m : 30.00m; 
        }

        public bool ProcessTap()
        {
            try
            {
                DatabaseConnection.Connect();

                string sql = "SELECT AccountID FROM Accounts WHERE CardID = @CardID";
                OleDbCommand cmd = new OleDbCommand(sql, DatabaseConnection.cn);
                cmd.Parameters.AddWithValue("@CardID", CardID);
                OleDbDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    int accountID = dr.GetInt32(0);
                    dr.Close();  
                    sql = "INSERT INTO TripHistory (AccountID, ActionType, Location, TripDateTime, FareDeducted) " +
                          "VALUES (@AccountID, @ActionType, @Location, @TripDateTime, @FareDeduction)";
                    cmd = new OleDbCommand(sql, DatabaseConnection.cn);
                    cmd.Parameters.AddWithValue("@AccountID", accountID);
                    cmd.Parameters.AddWithValue("@ActionType", ActionType);
                    cmd.Parameters.AddWithValue("@Location", Location);
                    cmd.Parameters.AddWithValue("@TripDateTime", DateTime.Now);
                    cmd.Parameters.AddWithValue("@FareDeduction", FareDeduction);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                else
                {
                    MessageBox.Show("Card ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dr.Close();  
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
