using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muntinlupa_Bus_E_Wallet
{
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();
            
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {

        }
        private void LoadUserData()
        {
            try
            {
                DatabaseConnection.sql = "SELECT user_id, Firstname, Lastname, email, CardNo,Balance, CardExpDate, is_active FROM Users";

                DatabaseConnection.cmd = new OleDbCommand(DatabaseConnection.sql, DatabaseConnection.cn);
                OleDbDataAdapter adapter = new OleDbDataAdapter(DatabaseConnection.cmd);

                DataTable userTable = new DataTable();
                adapter.Fill(userTable);

                dataGridView1.DataSource = userTable;

                dataGridView1.Columns["user_id"].HeaderText = "User ID";
                dataGridView1.Columns["FirstName"+" "+"Lastname"].HeaderText = "Name";
                dataGridView1.Columns["email"].HeaderText = "Email";
                dataGridView1.Columns["CardNo"].HeaderText = "Card Number";
                dataGridView1.Columns["Balance"].HeaderText = "Balance";
                dataGridView1.Columns["CardExpDate"].HeaderText = "Expiration Date";
                dataGridView1.Columns["is_active"].HeaderText = "Active Status";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user data: " + ex.Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
