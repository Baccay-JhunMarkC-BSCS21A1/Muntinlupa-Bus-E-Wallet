using System;
using System.Windows.Forms;

namespace Muntinlupa_Bus_E_Wallet
{
    public partial class frmLogin : Form
    {
        private User _user;

        public frmLogin()
        {
            InitializeComponent();
            _user = new User();
            lblPrompt.Visible= false;
            
        }


        private void btnLogIn_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (_user.Login(username, password))
            {
                //MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmAdminDashboard forms = new frmAdminDashboard();
                forms.Show();
                txtUsername.Text = "";
                txtPassword.Text = "";
                lblPrompt.Visible = false;
                this.Hide();
            }
            else
            {
                lblPrompt.Text = "Incorrect User or Password.";
                lblPrompt.Visible = true;
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
