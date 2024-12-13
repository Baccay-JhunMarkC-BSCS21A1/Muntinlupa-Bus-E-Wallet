using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

            // Parse Account ID
            int accountID;
            if (!int.TryParse(txtAccountID.Text, out accountID))
            {
                MessageBox.Show("Invalid Account ID. Please enter a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create Deactivation object
            var deactivation = new Deactivation(accountID, txtReason.Text);

            // Deactivate account
            if (Deactivation.DeactivateAccount(accountID, txtReason.Text))
            {
                MessageBox.Show("Account successfully deactivated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            else
            {
                MessageBox.Show("Failed to deactivate account. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearFields()
        {
            // Reset form fields
            txtAccountID.Clear();
            txtReason.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmAdminDashboard form = new frmAdminDashboard();
            form.Show();
            this.Hide();
        }
    }
}
