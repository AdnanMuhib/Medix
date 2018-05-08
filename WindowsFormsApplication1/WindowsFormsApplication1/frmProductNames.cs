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

namespace InventoryManagementSystem
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
            fill_dd();
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

        private void button1_Click(object sender, EventArgs e)
          {
              SqlCommand cmd1 = con.CreateCommand();
              cmd1.CommandType = CommandType.Text;
              cmd1.CommandText = "insert into products values('" + txtOnlyNames + "')";
              cmd1.ExecuteNonQuery();
              //fill_dg();
              MessageBox.Show("Records Inserted Successfully");
          }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "insert into products values('" + txtOnlyNames + "')";
            cmd1.ExecuteNonQuery();
            //fill_dg();
            MessageBox.Show("Records Inserted Successfully");
        }

        private void addProducts_Load_1(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            //fill_dg();
            fill_dd();
        }

        public void fill_dg()
        {
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select * from products";
            cmd2.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

    }
}
