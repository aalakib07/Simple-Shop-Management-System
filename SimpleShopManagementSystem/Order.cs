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
    public partial class Order : Form
    {
        public Order()
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
            string query = "select * from ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, db.con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            productGV.DataSource = ds.Tables[0];
            db.con.Close();
        }

        private void clear()
        {
            txtboxPname.Text = "";
            txtboxPprice.Text = "";
            txtboxPquantity.Text = "";
            txtboxCustomerName.Text ="";            
        }

        private void search()
        {
            db.con.Open();
            string query = "select * from ProductTbl where pName like '" + txtboxSearch.Text + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, db.con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            productGV.DataSource = ds.Tables[0];
            db.con.Close();
        }

        int key = 0, stock = 0;

        private void productGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtboxPname.Text = productGV.SelectedRows[0].Cells[1].Value.ToString();
            txtboxPprice.Text = productGV.SelectedRows[0].Cells[4].Value.ToString();

            if (txtboxPname.Text == "")
            {
                key = 0;
                stock = 0;
            }

            else
            {
                key = Convert.ToInt32(productGV.SelectedRows[0].Cells[0].Value.ToString());
                stock = Convert.ToInt32(productGV.SelectedRows[0].Cells[3].Value.ToString());
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void UpdateProduct()
        {
            int newQty = stock - Convert.ToInt32(txtboxPquantity.Text);
            try
            {
                db.con.Open();
                string query = "update ProductTbl set pQty = " + newQty + " where pid = " + key + ";  ";
                SqlCommand cmd = new SqlCommand(query, db.con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Added to Cart Successfully");

                db.con.Close();
                txtboxSearch.Text = "Search by name";
                txtboxSearch.ForeColor = Color.Silver;
                populate();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        int n = 0, GrandTotal = 0;    

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtboxCustomerName.Text))
            {
                MessageBox.Show("Please Insert Customer Name");
            }

            else
            {
                try
                {
                    db.con.Open();
                    string query = "insert into OrderTbl values('" + lblUsername.Text + "', '" + txtboxCustomerName.Text + "','" + GrandTotal + "') ";
                    SqlCommand cmd = new SqlCommand(query, db.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Confirmed!!\nOrder Saved Successfully.");

                    db.con.Close();

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                cartGV.Rows.Clear();
                cartGV.Refresh();
                clear();
                lblTotal.Text = "Total:";
            }
        }

        private void txtboxSearch_Enter(object sender, EventArgs e)
        {
            if (txtboxSearch.Text == "Search by name")
            {
                txtboxSearch.Text = "";
            }

            txtboxSearch.ForeColor = Color.Black;
        }

        private void txtboxSearch_Leave(object sender, EventArgs e)
        {
            if (txtboxSearch.Text == "")
            {
                txtboxSearch.Text = "Search by name";
            }

            txtboxSearch.ForeColor = Color.Silver;
        }

        private void txtboxSearch_TextChanged(object sender, EventArgs e)
        {
            search();           
        }

        private void Order_Load(object sender, EventArgs e)
        {
            lblUsername.Text = Login.Username;
        }            

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {           
            if (txtboxPquantity.Text == "" || Convert.ToInt32(txtboxPquantity.Text) > stock)
            {
                MessageBox.Show("Stock not available");
            }
            else
            {
                int total = Convert.ToInt32(txtboxPquantity.Text) * Convert.ToInt32(txtboxPprice.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(cartGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = txtboxPname.Text;
                newRow.Cells[2].Value = txtboxPprice.Text;
                newRow.Cells[3].Value = txtboxPquantity.Text;
                newRow.Cells[4].Value = total;
                cartGV.Rows.Add(newRow);
                n++;
                UpdateProduct();
                GrandTotal = GrandTotal + total;
                lblTotal.Text = "Total: \nBDT " + GrandTotal;
                clear();
            }

        }
    }
}
