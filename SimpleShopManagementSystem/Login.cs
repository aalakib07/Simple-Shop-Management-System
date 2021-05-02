using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SimpleShopManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
     
        DataAccess db = new DataAccess();

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static string Username = "";

        private void txtboxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            db.con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(" select count(*) from SalesmanTbl where uname = '"+ txtboxUsername.Text +"' and upass = '"+ txtboxPassword.Text +"'", db.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Username = txtboxUsername.Text;
                Order obj = new Order();
                obj.Show();
                this.Hide();
                db.con.Close();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password. Try Again!");
            }
            db.con.Close();
        }

        private void lblAdminLogin_Click(object sender, EventArgs e)
        {
            Admin obj = new SimpleShopManagementSystem.Admin();
            obj.Show();
            this.Hide();
        }
    }
}
