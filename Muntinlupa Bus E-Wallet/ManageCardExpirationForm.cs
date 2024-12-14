using System;

using System.Data.OleDb;
using System.Windows.Forms;

namespace Muntinlupa_Bus_E_Wallet
{
    public partial class frmCardExpiration : Form
    {
        public frmCardExpiration()
        {
            InitializeComponent();
        }

       

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmAdminDashboard form = new frmAdminDashboard();
            form.Show();
            this.Hide();
        }
    

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void btnRenew_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtAccountID.Text))
            {
                MessageBox.Show("Please enter a valid Account ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                
                DatabaseConnection.Connect();

                DatabaseConnection.sql = "SELECT * FROM Accounts WHERE AccountID = @AccountID";
                DatabaseConnection.cmd = new OleDbCommand(DatabaseConnection.sql, DatabaseConnection.cn);

                DatabaseConnection.cmd.Parameters.AddWithValue("@AccountID", Convert.ToInt32(txtAccountID.Text));

                DatabaseConnection.dr = DatabaseConnection.cmd.ExecuteReader();

                if (DatabaseConnection.dr.Read())
                {
                    DateTime expirationDate = Convert.ToDateTime(DatabaseConnection.dr["ExpirationDate"]);
                    DateTime currentDate = DateTime.Now;

                    if (expirationDate <= currentDate)
                    {
                        lblStatus.Text = "Card expired. Renew to continue.";

                        DatabaseConnection.dr.Close();

                        DatabaseConnection.sql = "UPDATE Accounts SET ExpirationDate = @NewExpirationDate WHERE AccountID = @AccountID";
                        DatabaseConnection.cmd = new OleDbCommand(DatabaseConnection.sql, DatabaseConnection.cn);

                        DatabaseConnection.cmd.Parameters.AddWithValue("@NewExpirationDate", dtpNewExpirationDate.Value);
                        DatabaseConnection.cmd.Parameters.AddWithValue("@AccountID", Convert.ToInt32(txtAccountID.Text));

                        int rowsAffected = DatabaseConnection.cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Card successfully renewed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to renew the card.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        lblStatus.Text = "Card is still active. No renewal needed.";
                        MessageBox.Show("Card is still valid and does not need renewal.", "No Action", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
