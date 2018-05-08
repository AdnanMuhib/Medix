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
    public partial class addProducts : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Project\Medix\WindowsFormsApplication1\WindowsFormsApplication1\inventory.mdf;Integrated Security=True");
        public addProducts()
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
            SqlCommand ss = new SqlCommand("Insert Into OnlyProducts(Name) Values('" + txtOlyNames.Text + "')", con);
            ss.ExecuteNonQuery();
            MessageBox.Show("Data Added");

            try
            {
                display();
            }
            catch
            {
                MessageBox.Show("Some Error");
            }

        }

        

        public void display()
        {
            SqlDataAdapter ss = new SqlDataAdapter("Select * from OnlyProducts", con);
            DataTable tbl = new DataTable();
            ss.Fill(tbl);
            dgvProductsames.DataSource = tbl;
        }
    }
}
