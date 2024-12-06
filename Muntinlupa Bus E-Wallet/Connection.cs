using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Muntinlupa_Bus_E_Wallet
{
    internal class Connection
    {
        public Connection() {
            OleDbCommand cmd = new OleDbCommand();
            OleDbConnection cn = new OleDbConnection();
            
            cn.Open();
        } 
    }
}
