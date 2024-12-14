using System;
using System.Windows.Forms;

namespace Muntinlupa_Bus_E_Wallet
{
    public partial class frmCardTap : Form
    {
        public frmCardTap()
        {
            InitializeComponent();
        }

        private void btnTap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCardID.Text) || string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("Please fill in both the Card ID and Location.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string actionType = lblActionType.Text;
          

            CardTapping cardTap = new CardTapping(Convert.ToInt32(txtCardID.Text), actionType, txtLocation.Text);

            bool isProcessed = cardTap.ProcessTap();

            if (isProcessed)
            {
                MessageBox.Show("Card tap successfully processed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Failed to process the card tap.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearFields()
        {
            txtCardID.Clear();
            txtLocation.SelectedIndex =0;
            lblActionType.SelectedIndex = 0;
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click_2(object sender, EventArgs e)
        {
            ClearFields();
            frmLogin form = new frmLogin();
            form.Show();
            this.Close();
        }
    }
    /*
     using System;
using System.Windows.Forms;

namespace Muntinlupa_Bus_E_Wallet
{
    public partial class frmCardTap : Form
    {
        public frmCardTap()
        {
            InitializeComponent();
        }

        private void btnTap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCardID.Text) || string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("Please fill in both the Card ID and Location.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Automatically determine ActionType based on the location
            string actionType = txtLocation.Text.Contains("PickUp") ? "Pickup" : "Drop-off";
            lblActionType.Text = actionType;

            CardTap cardTap = new CardTap(txtCardID.Text, actionType, txtLocation.Text);

            bool isProcessed = cardTap.ProcessTap();

            if (isProcessed)
            {
                MessageBox.Show("Card tap successfully processed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            else
            {
                MessageBox.Show("Failed to process the card tap.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearFields()
        {
            txtCardID.Clear();
            txtLocation.Clear();
            lblActionType.Text = string.Empty;
        }
    }
}

     */
}
