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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            populate();
        }

        DataAccess db = new DataAccess();

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void populate()
        {
            db.con.Open();
            string query = "select * from OrderTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, db.con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            orderGV.DataSource = ds.Tables[0];
            db.con.Close();
        }

        private void search()
        {
            db.con.Open();
            string query = "select * from OrderTbl where uname like '" + txtboxSearch.Text + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, db.con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            orderGV.DataSource = ds.Tables[0];
            db.con.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            Products obj = new Products();
            obj.Show();
            this.Hide();
        }

        private void btnSalesman_Click(object sender, EventArgs e)
        {
            Salesman obj = new Salesman();
            obj.Show();
            this.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            db.con.Open();

            SqlDataAdapter sda1 = new SqlDataAdapter("Select sum(amount) from OrderTbl", db.con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            lblAmount.Text = dt1.Rows[0][0].ToString() + " BDT";

            SqlDataAdapter sda2 = new SqlDataAdapter("Select count(*) from SalesmanTbl", db.con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            lblNumber.Text = dt2.Rows[0][0].ToString();

            db.con.Close();
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void txtboxSearch_Enter(object sender, EventArgs e)
        {
            if (txtboxSearch.Text == "Search by salesman")
            {
                txtboxSearch.Text = "";
            }

            txtboxSearch.ForeColor = Color.Black;
        }

        private void txtboxSearch_Leave(object sender, EventArgs e)
        {
            if (txtboxSearch.Text == "")
            {
                txtboxSearch.Text = "Search by salesman";
            }

            txtboxSearch.ForeColor = Color.Silver;
        }

        private void txtboxSearch_TextChanged(object sender, EventArgs e)
        {
            search();
        }
    }
}
