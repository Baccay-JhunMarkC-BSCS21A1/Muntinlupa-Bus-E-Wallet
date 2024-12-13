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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text) || string.IsNullOrWhiteSpace(txtContactInfo.Text) ||
               string.IsNullOrWhiteSpace(txtInitialBalance.Text) || !decimal.TryParse(txtInitialBalance.Text, out decimal initialBalance))
            {
                MessageBox.Show("Please fill in all fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime expirationDate = dtpExpirationDate.Value;

            CustomerAccount newAccount = new CustomerAccount(txtCustomerName.Text, txtContactInfo.Text, initialBalance, expirationDate);

            bool isSaved = newAccount.SaveAccount();

            if (isSaved)
            {
                MessageBox.Show("Account successfully registered!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            else
            {
                MessageBox.Show("Failed to register the account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

  

        private void ClearFields()
        {
            txtCustomerName.Clear();
            txtContactInfo.Clear();
            txtInitialBalance.Clear();
            dtpExpirationDate.Value = DateTime.Now;
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            frmAdminDashboard form = new frmAdminDashboard();
            ClearFields();
            form.Show();
            this.Close();
        }
    }
}
