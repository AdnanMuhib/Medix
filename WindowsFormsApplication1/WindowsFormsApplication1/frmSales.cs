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
    public partial class frmSales : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Project\Medix\WindowsFormsApplication1\WindowsFormsApplication1\inventory.mdf;Integrated Security=True");
        DataTable dt = new DataTable();
        int tot = 0;

        public frmSales()
        {
            InitializeComponent();
        }

        private void frmSales_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            fill_product_name();

            dt.Clear();
            dt.Columns.Add("Product");
            dt.Columns.Add("Price");
            dt.Columns.Add("Qty");
            dt.Columns.Add("Total");

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
            foreach (DataRow dr in dt.Rows)
            {
                cbShowProducts.Items.Add(dr["Name"].ToString());
            }
        }

        private void txtPrice_MouseClick(object sender, MouseEventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select top 1 * from Products where product_name = '"+cbShowProducts.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtPrice.Text = dr["product_price"].ToString();
            }
        }

        private void txtQty_Leave(object sender, EventArgs e)
        {
            try
            {
                txtTotal.Text = Convert.ToString(Convert.ToInt32(txtPrice.Text) * Convert.ToInt32(txtQty.Text)); 
            }
            catch (Exception ex)
            {

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int stock = 0;
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from stock where product_name = '"+cbShowProducts.Text+"'";
            cmd1.ExecuteNonQuery();

            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);

            foreach(DataRow dr1 in dt1.Rows)
            {
                stock = Convert.ToInt32(dr1["product_qty"].ToString());
            }

            if(Convert.ToInt32(txtQty.Text) > stock)
            {
                MessageBox.Show("This Quantity is Not Available");
            }
            else
            {
                DataRow dr = dt.NewRow();
                dr["Product"] = cbShowProducts.Text;
                dr["Price"] = txtPrice.Text;
                dr["Qty"] = txtQty.Text;
                dr["Total"] = txtTotal.Text;
                dt.Rows.Add(dr);
                dgvShowAll.DataSource = dt;

                tot = tot + Convert.ToInt32(dr["Total"].ToString());
                lblShowPrice.Text = tot.ToString();

            }

            
            txtPrice.Text = "";
            txtQty.Text = "";
            txtTotal.Text = "";
            cbShowProducts.Text = "";
            


        }

        private void dgvShowAll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
         
            try
            {
                tot = 0;
                dt.Rows.RemoveAt(Convert.ToInt32(dgvShowAll.CurrentCell.RowIndex.ToString()));
                foreach(DataRow dr1 in dt.Rows)
                {
                    tot = tot + Convert.ToInt32(dr1["Total"].ToString());
                    lblShowPrice.Text = tot.ToString();
                }
                lblShowPrice.Text = tot.ToString();
            }   
            catch (Exception ex)
            {

            }        
        }

        private void btnSaveBill_Click(object sender, EventArgs e)
        {
            string orderid = "";

            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "insert into orderUser values('" + txtFirstName.Text + "','" + txtLastName.Text + "','" + cbbillType.Text + "','" + dtpBillDate.Value.ToString("dd/mm/yyyy") + "')";
            cmd1.ExecuteNonQuery();

            // To Make order to the corresponding ID
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select top 1 * from orderUser order by id desc";
            cmd2.ExecuteNonQuery();

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);
            foreach (DataRow dr2 in dt2.Rows)
            {
                orderid = dr2["id"].ToString();
            }

            foreach (DataRow dr in dt.Rows)
            {
                int qty = 0;
                string pname = "";

                SqlCommand cmd3 = new SqlCommand("insert into items(order_id,product,price,qty,total) values('" + orderid.ToString() + "', '" + dr["Product"].ToString() + "' , '" + dr["Price"].ToString() + "' , '" + dr["Qty"].ToString() + "', '" + dr["Total"].ToString() + "')", con);
                cmd3.ExecuteNonQuery();

                qty = Convert.ToInt32(dr["Qty"].ToString());
                pname = dr["Product"].ToString();

                SqlCommand cmd4 = new SqlCommand("update stock set product_qty = product_qty - "+qty+" where product_name = '"+pname+"' ", con);
                cmd4.ExecuteNonQuery();
            }

            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPrice.Text = "";
            txtQty.Text = "";
            txtTotal.Text = "";
            cbShowProducts.Text = "";
            cbbillType.Text = "";

            dt.Clear();
            dgvShowAll.DataSource = dt;
            MessageBox.Show("Records Inserted Successfully");


        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            string orderid = "";

            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "insert into orderUser values('" + txtFirstName.Text + "','" + txtLastName.Text + "','" + cbbillType.Text + "','" + dtpBillDate.Value.ToString("dd/mm/yyyy") + "')";
            cmd1.ExecuteNonQuery();

            // To Make order to the corresponding ID
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select top 1 * from orderUser order by id desc";
            cmd2.ExecuteNonQuery();

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);
            foreach (DataRow dr2 in dt2.Rows)
            {
                orderid = dr2["id"].ToString();
            }

            foreach (DataRow dr in dt.Rows)
            {
                int qty = 0;
                string pname = "";

                SqlCommand cmd3 = new SqlCommand("insert into items(order_id,product,price,qty,total) values('" + orderid.ToString() + "', '" + dr["Product"].ToString() + "' , '" + dr["Price"].ToString() + "' , '" + dr["Qty"].ToString() + "', '" + dr["Total"].ToString() + "')", con);
                cmd3.ExecuteNonQuery();

                qty = Convert.ToInt32(dr["Qty"].ToString());
                pname = dr["Product"].ToString();

                SqlCommand cmd4 = new SqlCommand("update stock set product_qty = product_qty - " + qty + " where product_name = '" + pname + "' ", con);
                cmd4.ExecuteNonQuery();
            }

            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPrice.Text = "";
            txtQty.Text = "";
            txtTotal.Text = "";
            cbShowProducts.Text = "";
            cbbillType.Text = "";

            dt.Clear();
            dgvShowAll.DataSource = dt;
            MessageBox.Show("Records Inserted Successfully");

            frmGenerateBill gbl = new frmGenerateBill();
            gbl.get_value(Convert.ToInt32(orderid.ToString()));
            gbl.Show();


        }
    }
}
