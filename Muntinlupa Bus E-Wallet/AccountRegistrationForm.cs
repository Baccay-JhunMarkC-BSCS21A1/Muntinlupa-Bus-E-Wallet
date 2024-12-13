using System;
using System.Windows.Forms;

namespace Muntinlupa_Bus_E_Wallet
{
    public partial class frmAccountRegistration : Form
    {
        public frmAccountRegistration()
        {
            InitializeComponent();
        }

        private void frmAccountRegistration_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            
            dtpExpirationDate.Value = DateTime.Now.AddYears(1);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
             // Check for empty fields
    if (txtCustomerName.TextLength==0 || txtContactInfo.TextLength == 0 || txtInitialBalance.TextLength == 0)
    {
        MessageBox.Show("Please fill in all fields correctly!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
    }

    decimal initialBalance;
    if (!decimal.TryParse(txtInitialBalance.Text, out initialBalance))
    {
        MessageBox.Show("Please enter a valid balance!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
    }

    // Create the account object
    var account = new Accounts(
        Accounts.GenerateAccountID(),
        txtCustomerName.Text,
        txtContactInfo.Text,
        initialBalance,
        dtpExpirationDate.Value
    );

            if (Accounts.AddNewAccount(account))
            {
                MessageBox.Show("Account successfully registered!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            else
            {
                MessageBox.Show("Failed to register account. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmAdminDashboard form = new frmAdminDashboard();
            form.Show();
            ClearFields();
            this.Hide();
            
        }

        private void ClearFields()
        {
            // Reset form fields
            txtCustomerName.Clear();
            txtContactInfo.Clear();
            txtInitialBalance.Clear();
            dtpExpirationDate.Value = DateTime.Now.AddYears(1);
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContactInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInitialBalance_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
