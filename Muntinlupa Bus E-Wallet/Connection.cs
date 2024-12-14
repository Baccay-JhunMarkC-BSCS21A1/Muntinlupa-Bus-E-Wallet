using System;
using System.Data.OleDb;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace Muntinlupa_Bus_E_Wallet
{
    internal static class DatabaseConnection
    {
        public static OleDbConnection cn = new OleDbConnection();
        public static OleDbCommand cmd;
        public static OleDbDataReader dr;
        public static string sql;

        public static void Connect()
        {
            try
            {
                // Ensure the connection is closed before opening
                if (cn.State != System.Data.ConnectionState.Closed)
                    cn.Close();

                // Updated connection string for .accdb files
                cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "MEWDB.accdb";
                cn.Open();
                //MessageBox.Show("Database connected successfully.");
            }
            catch (OleDbException oleDbEx)
            {
                MessageBox.Show("Database error: " + oleDbEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("General error: " + ex.Message);
            }
        }


    }
}
