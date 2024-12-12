using System;
using System.Data.OleDb;

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
                if (cn.State != System.Data.ConnectionState.Closed)
                    cn.Close();

                cn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "MEWDB.accdb";
                cn.Open();
                Console.WriteLine("Database connected successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connecting to database: " + ex.Message);
            }
        }
    }
}
