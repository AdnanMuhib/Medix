using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void btn_sw_login_Click(object sender, EventArgs e)
        {
            if (txt_App_inv.Text != "" && txt_app_mname.Text != "" && txt_app_price.Text != "" && txt_app_qty.Text != "")
            {
                if (txt_app_mname.Text == "" && txt_app_qty.Text == "")
                {
                    MessageBox.Show("Please Enter Medicine's Name and Quantity");
                }

                items temp = new items();
                temp.Invoice_nmber = txt_App_inv.Text;
                temp.Item_name = txt_app_mname.Text;
                temp.Item_qty = txt_app_qty.Text;
                temp.Item_price = txt_app_price.Text;
                logged_users.current_user.adding_items.Add(temp);
                txt_App_inv.Text = "";
                txt_app_mname.Text = "";
                txt_app_price.Text = "";
                txt_app_qty.Text = "";
                BindingSource source = new BindingSource();
                source.DataSource = logged_users.current_user.adding_items;
                dgv_app_create_invoice.DataSource = source;

          
                //cls_app_all_logged.current_user.adding_items.Where(q => q.Invoice_nmber == "1").ToList();


            }
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            BindingSource source = new BindingSource();
            source.DataSource = logged_users.current_user.adding_items;
            dgv_app_create_invoice.DataSource = source;

            dgv_app_create_invoice.Columns[0].HeaderCell.Value = "Invoice#";
            dgv_app_create_invoice.Columns[1].HeaderCell.Value = "Item Name";
            dgv_app_create_invoice.Columns[2].HeaderCell.Value = "Quantity";
            dgv_app_create_invoice.Columns[3].HeaderCell.Value = "Price";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int row_index = dgv_app_create_invoice.CurrentCell.RowIndex;
            dgv_app_create_invoice.Rows.RemoveAt(row_index);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dgv_app_create_invoice.Width, this.dgv_app_create_invoice.Height);
            dgv_app_create_invoice.DrawToBitmap(bm, new Rectangle(0, 0, this.dgv_app_create_invoice.Width, this.dgv_app_create_invoice.Height));
            e.Graphics.DrawImage(bm, 10, 10);
        }
    }
}
