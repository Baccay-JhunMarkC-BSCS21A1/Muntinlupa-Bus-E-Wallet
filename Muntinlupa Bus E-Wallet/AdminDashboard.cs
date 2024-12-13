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
    public partial class frmAdminDashboard : Form
    {
        public frmAdminDashboard()
        {
            InitializeComponent();
        }

        private void lblAccountManagement_Click(object sender, EventArgs e)
        {
             
        }

        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {
        }

        private void lblCardExpirationHistory_Click(object sender, EventArgs e)
        {

        }

        private void lblReloadAccount_Click(object sender, EventArgs e)
        {
            frmReloadAccount form = new frmReloadAccount();
            form.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var dr = MessageBox.Show("Are you sure you want to log out?", "Notice!", MessageBoxButtons.YesNo);
            if (dr==DialogResult.Yes)
            {
                frmLogin form = new frmLogin();
                form.Show();
                this.Hide();
            }
        }

        private void lblRouteManagement_Click(object sender, EventArgs e)
        {
            Route_FareManagementForm form = new Route_FareManagementForm(); 
            form.Show();
            this.Hide();
        }

        private void lblHistory_Click(object sender, EventArgs e)
        {

        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            frmAccountRegistration form = new frmAccountRegistration();
            form.Show();
            this.Hide();
        }

        private void lblDeactivate_Click(object sender, EventArgs e)
        {
            frmDeactivateAccount form = new frmDeactivateAccount();
            form.Show();
            this.Hide();
        }

        private void lblCardManagement_Click(object sender, EventArgs e)
        {
            frmCardExpiration form = new frmCardExpiration();
            form.Show();
            this.Hide();
        }
    }
}
