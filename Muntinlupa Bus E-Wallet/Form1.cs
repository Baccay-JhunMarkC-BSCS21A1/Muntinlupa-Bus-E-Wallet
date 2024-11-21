using Muntinlupa_Bus_E_Wallet;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            DatabaseConnection.Connect();
            InitializeComponent();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value++;
            }
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                Login secondform = new Login();
                secondform.Show();
                this.Hide();   
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Timer_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value > 100)
            {
                progressBar1.Value += 1;

                label3.Text = progressBar1.Value.ToString() + "%";
            }

            else
            {
                timer1.Stop();

                MessageBox.Show("Complete!!");
            }
        }

    }
}
