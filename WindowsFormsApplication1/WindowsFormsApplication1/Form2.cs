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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "")
            {
                if (textBox2.Text != "")
                {
                    if((textBox1.Text == "admin" || textBox1.Text == "Admin" || textBox1.Text == "ADMIN") && textBox2.Text == "admin786")
                    {
                        frmAdminPanel admin = new frmAdminPanel();
                        this.Hide();
                        admin.Show();
                    }
                    else
                    {
                        bool isval;
                        bool isvalpass;
                        localhost.Service1 ser = new localhost.Service1();
                        ser.isvaliduser(textBox1.Text, textBox2.Text, out isval, out isvalpass);
                        if (isval)
                        {
                            //frmEmployee emp = new frmEmployee();
                            frmGenerateBill gb = new frmGenerateBill();
                            gb.Show();
                           
                            //emp.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid User");
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Please Enter Password");
                }
            }
            else
            {
                MessageBox.Show("Please Enter User Name");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
