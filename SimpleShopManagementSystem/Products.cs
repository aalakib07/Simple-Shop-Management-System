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
    public partial class Products : Form
    {
        public Products()
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

        private void search()
        {
            db.con.Open();
            string query = "select * from ProductTbl where pName like '"+txtboxSearch.Text+"%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, db.con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            productGV.DataSource = ds.Tables[0];
            db.con.Close();
        }

        private void filter()
        {
            db.con.Open();
            string query = "select * from ProductTbl where pCat = '" + comboBoxSearchCategory.SelectedItem.ToString() + "'";
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
            comboBoxCategory.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtboxPname.Text) || string.IsNullOrEmpty(txtboxPquantity.Text) || string.IsNullOrEmpty(txtboxPprice.Text) || comboBoxCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all the fields");
            }

            else
            {
                try
                {
                    db.con.Open();
                    string query = "insert into ProductTbl values('" + txtboxPname.Text + "', '" + comboBoxCategory.SelectedItem.ToString() + "', '" + txtboxPquantity.Text + "', '" + txtboxPprice.Text + "') ";
                    SqlCommand cmd = new SqlCommand(query, db.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Saved Successfully");

                    db.con.Close();
                    populate();
                    clear();
                }

                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void comboBoxSearchCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filter();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            populate();          
            comboBoxSearchCategory.SelectedIndex = -1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        int key = 0;

        private void productGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtboxPname.Text = productGV.SelectedRows[0].Cells[1].Value.ToString();
            comboBoxCategory.SelectedItem = productGV.SelectedRows[0].Cells[2].Value.ToString();
            txtboxPquantity.Text = productGV.SelectedRows[0].Cells[3].Value.ToString();
            txtboxPprice.Text = productGV.SelectedRows[0].Cells[4].Value.ToString();

            if (txtboxPname.Text == "")
            {
                key = 0;
            }

            else
            {
                key = Convert.ToInt32(productGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Information Missing");
            }

            else
            {
                try
                {
                    db.con.Open(); 
                    string query = "delete from ProductTbl where pid=" + key + "; ";
                    SqlCommand cmd = new SqlCommand(query, db.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted Successfully");

                    db.con.Close();
                    populate();
                    clear();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtboxPname.Text) || string.IsNullOrEmpty(txtboxPquantity.Text) || string.IsNullOrEmpty(txtboxPprice.Text) || comboBoxCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all the fields");
            }

            else
            {
                try
                {
                    db.con.Open();
                    string query = "update ProductTbl set pName = '"+ txtboxPname.Text+"', pCat = '"+ comboBoxCategory.SelectedItem.ToString() +"' , pQty = '"+txtboxPquantity.Text+"' , pPrice = '"+txtboxPprice.Text+"' where pid = "+key+"; ";
                    SqlCommand cmd = new SqlCommand(query, db.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Updated Successfully");

                    db.con.Close();
                    populate();
                    clear();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Hide();
        }

        private void btnSalesman_Click(object sender, EventArgs e)
        {
            Salesman obj = new Salesman();
            obj.Show();
            this.Hide();
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void comboBoxSearchCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtboxSearch_TextChanged(object sender, EventArgs e)
        {
            search();
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
    }
}
