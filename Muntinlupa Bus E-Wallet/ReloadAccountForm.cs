using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Muntinlupa_Bus_E_Wallet
{
    public partial class frmReloadAccount : Form
    {
        public frmReloadAccount()
        {
            InitializeComponent();
        }



        private void btnReload_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAccountID.Text) || string.IsNullOrWhiteSpace(txtReloadAmount.Text))
            {
                MessageBox.Show("Please enter both the Account ID and Reload Amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            { 
                decimal reloadAmount = Convert.ToDecimal(txtReloadAmount.Text);

                DatabaseConnection.Connect();

                DatabaseConnection.sql = "SELECT * FROM Accounts WHERE AccountID = @AccountID";
                DatabaseConnection.cmd = new OleDbCommand(DatabaseConnection.sql, DatabaseConnection.cn);

                DatabaseConnection.cmd.Parameters.AddWithValue("@AccountID", Convert.ToInt32(txtAccountID.Text));
                
                DatabaseConnection.dr = DatabaseConnection.cmd.ExecuteReader();

                if (DatabaseConnection.dr.Read())
                {
                    decimal currentBalance = Convert.ToDecimal(DatabaseConnection.dr["Balance"]);
                    lblCurrentBalance.Text = "Current Balance: " + currentBalance.ToString("C2");

                    if (reloadAmount <= 0)
                    {
                        MessageBox.Show("Please enter a valid reload amount.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    
                    DatabaseConnection.dr.Close();

                    DatabaseConnection.sql = "UPDATE Accounts SET Balance = Balance + @ReloadAmount WHERE AccountID = @AccountID";
                    DatabaseConnection.cmd = new OleDbCommand(DatabaseConnection.sql, DatabaseConnection.cn);

                    DatabaseConnection.cmd.Parameters.AddWithValue("@ReloadAmount", reloadAmount);
                    DatabaseConnection.cmd.Parameters.AddWithValue("@AccountID", Convert.ToInt32(txtAccountID.Text));

                    int rowsAffected = DatabaseConnection.cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Account reloaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to reload the account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Account not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReloadCancel_Click(object sender, EventArgs e)
        {
            frmAdminDashboard form = new frmAdminDashboard();
            form.Show();
            this.Hide();
        }

        private void txtAccountID_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAccountID.Text)||txtAccountID.TextLength<6|| txtAccountID.TextLength > 6)
            {
                lblCurrentBalance.Text = "0.00";
                return; 
            }

            try
            {
                int accountId = Convert.ToInt32(txtAccountID.Text);

                DatabaseConnection.Connect();

                DatabaseConnection.sql = "SELECT * FROM Accounts WHERE AccountID = @AccountID";
                DatabaseConnection.cmd = new OleDbCommand(DatabaseConnection.sql, DatabaseConnection.cn);

                DatabaseConnection.cmd.Parameters.AddWithValue("@AccountID", accountId);

                DatabaseConnection.dr = DatabaseConnection.cmd.ExecuteReader();

                if (DatabaseConnection.dr.Read())
                {
                    decimal currentBalance = Convert.ToDecimal(DatabaseConnection.dr["Balance"]);
                    lblCurrentBalance.Text = "Current Balance: " + currentBalance.ToString("C2");
                }
                else
                {
                    lblCurrentBalance.Text = "0.00";
                }

                DatabaseConnection.dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
