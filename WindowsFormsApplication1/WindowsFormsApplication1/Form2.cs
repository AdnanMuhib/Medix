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
            bool isval;
            bool isvalpass;
            localhost.Service1 ser = new localhost.Service1();
            ser.isvaliduser(textBox1.Text, textBox2.Text, out isval, out isvalpass);
            if(isval)
            {
                MessageBox.Show("Valid User");
                frmEmployee emp = new frmEmployee();
                emp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid User");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
