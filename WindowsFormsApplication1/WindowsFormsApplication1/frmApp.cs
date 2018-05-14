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
    public partial class frmApp : Form
    {
        public frmApp()
        {
            InitializeComponent();
        }

        private void frmApp_Load(object sender, EventArgs e)
        {
            this.Text = "Pharmacy Management System";
            pnlSlider.Height = btnDashboard.Height - 1;
            pnlSlider.Top = btnDashboard.Top;

            //Changing Text and Image
            lblChanger.Text = "DASHBOARD";
            pbChanger.Image = Image.FromFile("E:/Project/Medix/Dashboard.png");
            
            /*
            MyProject.Modules.Masters myMasters = new MyProject.Modules.Masters()
            panel1.Controls.Add(myMasters);
            This will only add a new control to panel1. 
            If you also want to clear everything out of the panel 
            before adding the control like you said 
            in the question, call this first:

            panel1.Controls.Clear();
            */
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            //Adding control to the Panel
            //ucViewer myMasters = new ucViewer();
            //pnlnevigator.Controls.Add(myMasters);
            //Changing Text
            // myMasters.lblchange.Text = "DASHBOARD";
            //myMasters.pbchange.Image = Image.FromFile("E:/Project/Medix/Dashboard.png");

            //Changing Text and Image
            lblChanger.Text = "DASHBOARD";
            pbChanger.Image = Image.FromFile("E:/Project/Medix/Dashboard.png");

            pnlSlider.Height = btnDashboard.Height - 1;
            pnlSlider.Top = btnDashboard.Top;
        }

        private void frmApp_Load_1(object sender, EventArgs e)
        {
            this.Text = "Pharmacy Management System - Admin";
            pnlSlider.Height = btnDashboard.Height - 1;
            pnlSlider.Top = btnDashboard.Top;

            //Changing Text and Image
            lblChanger.Text = "DASHBOARD";
            pbChanger.Image = Image.FromFile("E:/Project/Medix/Dashboard.png");
            /*
            MyProject.Modules.Masters myMasters = new MyProject.Modules.Masters()
            panel1.Controls.Add(myMasters);
            This will only add a new control to panel1. 
            If you also want to clear everything out of the panel 
            before adding the control like you said 
            in the question, call this first:

            panel1.Controls.Clear();
            */
        }

        private void btnProducts_Click_1(object sender, EventArgs e)
        {
            //Changing Text and Image
            lblChanger.Text = "PRODUCTS";
            pbChanger.Image = Image.FromFile("E:/Project/Medix/Products.png");

            pnlSlider.Height = btnProducts.Height - 1;
            pnlSlider.Top = btnProducts.Top;
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            //Changing Text and Image
            lblChanger.Text = "PURCHASES";
            pbChanger.Image = Image.FromFile("E:/Project/Medix/Purchases.png");

            pnlSlider.Height = btnPurchase.Height - 1;
            pnlSlider.Top = btnPurchase.Top;
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            //Changing Text and Image
            lblChanger.Text = "SALES";
            pbChanger.Image = Image.FromFile("E:/Project/Medix/Sales.ico");

            pnlSlider.Height = btnSales.Height - 1;
            pnlSlider.Top = btnSales.Top;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            //Changing Text and Image
            lblChanger.Text = "ADMIN";
            pbChanger.Image = Image.FromFile("E:/Project/Medix/Admin.png");

            pnlSlider.Height = btnAdmin.Height - 1;
            pnlSlider.Top = btnAdmin.Top;
        }
    }
}
