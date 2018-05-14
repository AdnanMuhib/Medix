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

namespace WindowsFormsApplication1
{
    public partial class frm_AddNames : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Project\Medix\WindowsFormsApplication1\WindowsFormsApplication1\inventory.mdf;Integrated Security=True");
        public frm_AddNames()
        {
            InitializeComponent();
        }

        private void addProducts_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            //fill_dg();
            display();
            //fill_dd();
        }

        public void fill_dd()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from units";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
        }

        private void btnAddNames_Click(object sender, EventArgs e)
        {
            if(txtOlyNames.Text != "")
            {
                SqlCommand ss = new SqlCommand("Insert Into OnlyProducts(Name) Values('" + txtOlyNames.Text + "')", con);
                ss.ExecuteNonQuery();
                txtOlyNames.Text = ""; 
                MessageBox.Show("Data Added");

                try
                {
                    display();
                }
                catch
                {
                    MessageBox.Show("Some Error has Occured");
                }
            }
            else
            {
                MessageBox.Show("Enter Product Name");
            }
        }

        

        public void display()
        {
            SqlDataAdapter ss = new SqlDataAdapter("Select * from OnlyProducts", con);
            DataTable tbl = new DataTable();
            ss.Fill(tbl);
            dgvProductsames.DataSource = tbl;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtOlyNames.Text != "")
            {
                int id = 0;
                id = Convert.ToInt32(dgvProductsames.SelectedCells[0].Value.ToString());
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from OnlyProducts where id = " + id + "";
                cmd.ExecuteNonQuery();

                display();
            }
            else
            {
                MessageBox.Show("Enter Product Name");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
                DataTable dt = new DataTable();
                SqlDataAdapter ss = new SqlDataAdapter("SELECT * FROM OnlyProducts where Name like '%" + txtSearching.Text.Trim() + "%' ", con);
                ss.Fill(dt);
                dgvProductsames.DataSource = dt;
            txtSearching.Text = "";
            
        }

        private void txtSearching_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearching.Text = "";
        }

        private void txtSearching_TextChanged(object sender, EventArgs e)
        {
            /*DataView dv = new DataView(dt);
            dv.RowFilter = "SELECT * FROM OnlyProducts where Name like '%"+ txtSearching.Text.Trim() +"%' ";
            dgvProductsames.DataSource = dv;*/
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            display();
        }
    }
}
