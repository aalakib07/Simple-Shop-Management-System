using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleShopManagementSystem
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtboxPassword.Text == "admin")
            {
                Dashboard obj = new Dashboard();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Password!!");
            }
        }

        private void lblSalesmanLogin_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtboxPassword.Text = "";
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
