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
    public partial class frmDeactivateAccount : Form
    {
        public frmDeactivateAccount()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAccountID.Text) || string.IsNullOrWhiteSpace(txtReason.Text))
            {
                MessageBox.Show("Please fill in both the Account ID and Reason for Deactivation.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    DatabaseConnection.dr.Close(); 

                    DatabaseConnection.sql = "UPDATE Accounts SET Status = 'Inactive' WHERE AccountID = @AccountID";
                    DatabaseConnection.cmd = new OleDbCommand(DatabaseConnection.sql, DatabaseConnection.cn);

                    DatabaseConnection.cmd.Parameters.AddWithValue("@AccountID", Convert.ToInt32(txtAccountID.Text));

                    int rowsAffected = DatabaseConnection.cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        DatabaseConnection.sql = "INSERT INTO Deactivations (AccountID, AdminID, Reason, DeactivationTime) VALUES (@AccountID, @AdminID, @Reason, @DeactivationTime)";
                        DatabaseConnection.cmd = new OleDbCommand(DatabaseConnection.sql, DatabaseConnection.cn);

                        int adminID = 1; 

                        DatabaseConnection.cmd.Parameters.AddWithValue("@AccountID", Convert.ToInt32(txtAccountID.Text));
                        DatabaseConnection.cmd.Parameters.AddWithValue("@AdminID", adminID); 
                        DatabaseConnection.cmd.Parameters.AddWithValue("@Reason", txtReason.Text);
                        DatabaseConnection.cmd.Parameters.AddWithValue("@DeactivationTime", DateTime.Now);

                        DatabaseConnection.cmd.ExecuteNonQuery();

                        MessageBox.Show("Account successfully deactivated and logged!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Failed to deactivate the account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void ClearFields()
        {
            
            txtAccountID.Clear();
            txtReason.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmAdminDashboard form = new frmAdminDashboard();
            form.Show();
            ClearFields();
            this.Hide();
        }

        private void btnDeactivate_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAccountID.Text) || string.IsNullOrWhiteSpace(txtReason.Text))
            {
                MessageBox.Show("Please fill in both the Account ID and Reason for Deactivation.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    DatabaseConnection.dr.Close();

                    DatabaseConnection.sql = "UPDATE Accounts SET Status = 'Inactive' WHERE AccountID = @AccountID";
                    DatabaseConnection.cmd = new OleDbCommand(DatabaseConnection.sql, DatabaseConnection.cn);

                    DatabaseConnection.cmd.Parameters.AddWithValue("@AccountID", Convert.ToInt32(txtAccountID.Text));

                    int rowsAffected = DatabaseConnection.cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        DatabaseConnection.sql = "INSERT INTO Deactivations (AccountID, AdminID, Reason, DeactivationTime) VALUES (@AccountID, @AdminID, @Reason, @DeactivationTime)";
                        DatabaseConnection.cmd = new OleDbCommand(DatabaseConnection.sql, DatabaseConnection.cn);

                        int adminID = 1;

                        DatabaseConnection.cmd.Parameters.AddWithValue("@AccountID", Convert.ToInt32(txtAccountID.Text));
                        DatabaseConnection.cmd.Parameters.AddWithValue("@AdminID", adminID);
                        DatabaseConnection.cmd.Parameters.AddWithValue("@Reason", txtReason.Text);
                        DatabaseConnection.cmd.Parameters.AddWithValue("@DeactivationTime", DateTime.Now);

                        DatabaseConnection.cmd.ExecuteNonQuery();

                        MessageBox.Show("Account successfully deactivated and logged!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Failed to deactivate the account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            frmAdminDashboard form = new frmAdminDashboard();
            form.Show();
            ClearFields();
            this.Hide();
        }
    }
}
