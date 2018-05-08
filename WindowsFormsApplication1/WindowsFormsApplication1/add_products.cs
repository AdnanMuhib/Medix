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
    public partial class frmPurchaseProducts : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Project\Medix\WindowsFormsApplication1\WindowsFormsApplication1\inventory.mdf;Integrated Security=True");
        public frmPurchaseProducts()
        {
            InitializeComponent();
        }

        private void txtQty_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            fill_product_name();
        }

        public void fill_product_name()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from OnlyProducts";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                cbShowProducts.Items.Add(dr["Name"].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int i = 0;
            SqlCommand cmd1 = new SqlCommand("select * from stock where product_name = '"+cbShowProducts.Text+"' ",con);
            cmd1.ExecuteNonQuery();

            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);

            i = Convert.ToInt32(dt1.Rows.Count.ToString());

            if(i == 0)
            {
                SqlCommand ss1 = new SqlCommand("insert into Products(product_name,product_qty,product_price,product_total,purchase_date,expiry_date,profit) values('" + cbShowProducts.Text + "','" + txtQty.Text + "','" + txtPrice.Text + "','" + txttotal.Text + "','" + dateTimePicker1.Value.ToString() + "','" + dateTimePicker2.Value.ToString() + "','" + txtProfit.Text + "')", con);
                ss1.ExecuteNonQuery();

                SqlCommand ss2 = new SqlCommand("insert into stock(product_name,product_qty) values('" + cbShowProducts.Text + "','" + txtQty.Text + "')", con);
                ss2.ExecuteNonQuery();
            }
            else
            {
                SqlCommand ss3 = new SqlCommand("insert into Products(product_name,product_qty,product_price,product_total,purchase_date,expiry_date,profit) values('" + cbShowProducts.Text + "','" + txtQty.Text + "','" + txtPrice.Text + "','" + txttotal.Text + "','" + dateTimePicker1.Value.ToString() + "','" + dateTimePicker2.Value.ToString() + "','" + txtProfit.Text + "')", con);
                ss3.ExecuteNonQuery();

                SqlCommand ss4 = new SqlCommand("update stock set product_qty = product_qty + '"+txtQty.Text+"' where product_name = '"+cbShowProducts.Text+"'", con);
                ss4.ExecuteNonQuery();

            }

            
            MessageBox.Show("Records Inserted");
        }

        public void display()
        {
            /*SqlDataAdapter ss = new SqlDataAdapter("Select * from OnlyProducts", con);
            DataTable tbl = new DataTable();
            ss.Fill(tbl);
            dgvProductsames.DataSource = tbl;*/
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            txttotal.Text = Convert.ToString(Convert.ToInt32(txtQty.Text) * Convert.ToInt32(txtPrice.Text));
        }
    }
}
