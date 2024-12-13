using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Muntinlupa_Bus_E_Wallet
{
    public class Route
    {
        public string PickupPoint { get; set; }
        public string DropOffPoint { get; set; }
        public decimal Fare { get; set; }

        public Route(string pickupPoint, string dropOffPoint, decimal fare)
        {
            PickupPoint = pickupPoint;
            DropOffPoint = dropOffPoint;
            Fare = fare;
        }

        public bool SaveRoute()
        {
            try
            {
                DatabaseConnection.Connect();
                string sql = "INSERT INTO Routes (PickupPoint, DropOffPoint, Fare) VALUES (@PickupPoint, @DropOffPoint, @Fare)";
                OleDbCommand cmd = new OleDbCommand(sql, DatabaseConnection.cn);
                cmd.Parameters.AddWithValue("@PickupPoint", PickupPoint);
                cmd.Parameters.AddWithValue("@DropOffPoint", DropOffPoint);
                cmd.Parameters.AddWithValue("@Fare", Fare);
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
