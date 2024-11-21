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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }
        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult i = MessageBox.Show("Are you sure you want to Close the Application?", "Information.", MessageBoxButtons.YesNo);
            if (i == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void UserUi_Click(object sender, EventArgs e)
        {

        }

        private void AdminLogin_Click(object sender, EventArgs e)
        {
            LoginTabs form = new LoginTabs();
            form.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
