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
    public partial class Route_FareManagementForm : Form
    {
        public Route_FareManagementForm()
        {
            InitializeComponent();
        }

        private void btnSaveRoute_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbPickupPoint.Text) || string.IsNullOrWhiteSpace(cmbDropOffPoint.Text) || string.IsNullOrWhiteSpace(lblFare.Text))
            {
                MessageBox.Show("Please fill in all fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(lblFare.Text, out decimal fare))
            {
                MessageBox.Show("Please enter a valid fare.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Route newRoute = new Route(cmbPickupPoint.Text, cmbDropOffPoint.Text, fare);

            bool isSaved = newRoute.SaveRoute();

            if (isSaved)
            {
                MessageBox.Show("Route successfully saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            else
            {
                MessageBox.Show("Failed to save the route.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void ClearFields()
        {
            cmbPickupPoint.SelectedIndex = -1;
            cmbDropOffPoint.SelectedIndex = -1;
            lblFare.Text = string.Empty;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmAdminDashboard form = new frmAdminDashboard();
            form.Show();
            ClearFields();
            this.Close();
        }
    }
 

}
