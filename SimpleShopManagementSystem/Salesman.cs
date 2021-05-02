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
    public partial class Salesman : Form
    {
        public Salesman()
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
            string query = "select * from SalesmanTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, db.con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            salesmanGV.DataSource = ds.Tables[0];
            db.con.Close();
        }

        private void clear()
        {
            txtboxUsername.Text = "";
            txtboxPhone.Text = "";
            txtboxAddress.Text = "";
            txtboxPassword.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtboxUsername.Text) || string.IsNullOrEmpty(txtboxPassword.Text) || string.IsNullOrEmpty(txtboxAddress.Text) || string.IsNullOrEmpty(txtboxPhone.Text))
            {
                MessageBox.Show("Please fill all the fields");
            }

            else
            {
                try
                {
                    db.con.Open();
                    string query = "insert into SalesmanTbl values('" + txtboxUsername.Text + "', '" + txtboxPhone.Text + "', '" + txtboxAddress.Text + "', '" + txtboxPassword.Text + "') ";
                    SqlCommand cmd = new SqlCommand(query, db.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Salesman Added Successfully");

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        int key = 0;

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
                    string query = "delete from SalesmanTbl where uid=" + key + "; ";
                    SqlCommand cmd = new SqlCommand(query, db.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Salesman Removed Successfully");

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

        private void salesmanGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtboxUsername.Text = salesmanGV.SelectedRows[0].Cells[1].Value.ToString();
            txtboxPhone.Text = salesmanGV.SelectedRows[0].Cells[2].Value.ToString();
            txtboxAddress.Text = salesmanGV.SelectedRows[0].Cells[3].Value.ToString();
            txtboxPassword.Text = salesmanGV.SelectedRows[0].Cells[4].Value.ToString();

            if (txtboxUsername.Text == "")
            {
                key = 0;
            }

            else
            {
                key = Convert.ToInt32(salesmanGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtboxUsername.Text) || string.IsNullOrEmpty(txtboxPassword.Text) || string.IsNullOrEmpty(txtboxAddress.Text) || string.IsNullOrEmpty(txtboxPhone.Text))
            {
                MessageBox.Show("Please fill all the fields");
            }

            else
            {
                try
                {
                    db.con.Open();
                    string query = "update SalesmanTbl set uname = '" + txtboxUsername.Text + "', uphone = '" + txtboxPhone.Text + "' , uadd = '" + txtboxAddress.Text + "' , upass = '" + txtboxPassword.Text + "' where uid = " + key + "; ";
                    SqlCommand cmd = new SqlCommand(query, db.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Salesman Information Updated Successfully");

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

        private void btnProducts_Click(object sender, EventArgs e)
        {
            Products obj = new Products();
            obj.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Hide();
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
