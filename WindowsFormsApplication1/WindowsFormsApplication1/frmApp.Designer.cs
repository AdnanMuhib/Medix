namespace WindowsFormsApplication1
{
    partial class frmApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmApp));
            this.pnlnevigator = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlSlider = new System.Windows.Forms.Panel();
            this.pnlLine = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnAdmin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDashboard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSales = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPurchase = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnProducts = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pbChanger = new System.Windows.Forms.PictureBox();
            this.lblChanger = new System.Windows.Forms.Label();
            this.pnlWorking = new System.Windows.Forms.Panel();
            this.pnlnevigator.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbChanger)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlnevigator
            // 
            this.pnlnevigator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlnevigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.pnlnevigator.Controls.Add(this.pbChanger);
            this.pnlnevigator.Controls.Add(this.lblChanger);
            this.pnlnevigator.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlnevigator.ForeColor = System.Drawing.Color.White;
            this.pnlnevigator.Location = new System.Drawing.Point(183, 1);
            this.pnlnevigator.Name = "pnlnevigator";
            this.pnlnevigator.Size = new System.Drawing.Size(712, 50);
            this.pnlnevigator.TabIndex = 6;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.pnlMenu.Controls.Add(this.pnlSlider);
            this.pnlMenu.Controls.Add(this.btnAdmin);
            this.pnlMenu.Controls.Add(this.btnDashboard);
            this.pnlMenu.Controls.Add(this.btnSales);
            this.pnlMenu.Controls.Add(this.btnPurchase);
            this.pnlMenu.Controls.Add(this.btnProducts);
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(167, 525);
            this.pnlMenu.TabIndex = 5;
            // 
            // pnlSlider
            // 
            this.pnlSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(113)))), ((int)(((byte)(153)))));
            this.pnlSlider.Location = new System.Drawing.Point(3, 3);
            this.pnlSlider.Name = "pnlSlider";
            this.pnlSlider.Size = new System.Drawing.Size(6, 48);
            this.pnlSlider.TabIndex = 6;
            // 
            // pnlLine
            // 
            this.pnlLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.pnlLine.Location = new System.Drawing.Point(173, -2);
            this.pnlLine.Name = "pnlLine";
            this.pnlLine.Size = new System.Drawing.Size(4, 526);
            this.pnlLine.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 517);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(896, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(156, 17);
            this.toolStripStatusLabel1.Text = "Copyright @PowerSolutions";
            // 
            // btnAdmin
            // 
            this.btnAdmin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdmin.BorderRadius = 0;
            this.btnAdmin.ButtonText = " ADMIN";
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdmin.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdmin.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAdmin.Iconimage")));
            this.btnAdmin.Iconimage_right = null;
            this.btnAdmin.Iconimage_right_Selected = null;
            this.btnAdmin.Iconimage_Selected = null;
            this.btnAdmin.IconMarginLeft = 0;
            this.btnAdmin.IconMarginRight = 0;
            this.btnAdmin.IconRightVisible = true;
            this.btnAdmin.IconRightZoom = 0D;
            this.btnAdmin.IconVisible = true;
            this.btnAdmin.IconZoom = 70D;
            this.btnAdmin.IsTab = false;
            this.btnAdmin.Location = new System.Drawing.Point(3, 195);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.btnAdmin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnAdmin.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAdmin.selected = false;
            this.btnAdmin.Size = new System.Drawing.Size(161, 48);
            this.btnAdmin.TabIndex = 5;
            this.btnAdmin.Text = " ADMIN";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Textcolor = System.Drawing.Color.White;
            this.btnAdmin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDashboard.BorderRadius = 0;
            this.btnDashboard.ButtonText = "  DASHBOARD";
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.DisabledColor = System.Drawing.Color.Gray;
            this.btnDashboard.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDashboard.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Iconimage")));
            this.btnDashboard.Iconimage_right = null;
            this.btnDashboard.Iconimage_right_Selected = null;
            this.btnDashboard.Iconimage_Selected = null;
            this.btnDashboard.IconMarginLeft = 0;
            this.btnDashboard.IconMarginRight = 0;
            this.btnDashboard.IconRightVisible = true;
            this.btnDashboard.IconRightZoom = 0D;
            this.btnDashboard.IconVisible = true;
            this.btnDashboard.IconZoom = 50D;
            this.btnDashboard.IsTab = false;
            this.btnDashboard.Location = new System.Drawing.Point(3, 3);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.btnDashboard.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnDashboard.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDashboard.selected = false;
            this.btnDashboard.Size = new System.Drawing.Size(161, 48);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "  DASHBOARD";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Textcolor = System.Drawing.Color.White;
            this.btnDashboard.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnSales
            // 
            this.btnSales.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.btnSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSales.BorderRadius = 0;
            this.btnSales.ButtonText = "  SALES";
            this.btnSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSales.DisabledColor = System.Drawing.Color.Gray;
            this.btnSales.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSales.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSales.Iconimage")));
            this.btnSales.Iconimage_right = null;
            this.btnSales.Iconimage_right_Selected = null;
            this.btnSales.Iconimage_Selected = null;
            this.btnSales.IconMarginLeft = 0;
            this.btnSales.IconMarginRight = 0;
            this.btnSales.IconRightVisible = true;
            this.btnSales.IconRightZoom = 0D;
            this.btnSales.IconVisible = true;
            this.btnSales.IconZoom = 50D;
            this.btnSales.IsTab = false;
            this.btnSales.Location = new System.Drawing.Point(3, 148);
            this.btnSales.Name = "btnSales";
            this.btnSales.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.btnSales.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnSales.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSales.selected = false;
            this.btnSales.Size = new System.Drawing.Size(161, 49);
            this.btnSales.TabIndex = 4;
            this.btnSales.Text = "  SALES";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.Textcolor = System.Drawing.Color.White;
            this.btnSales.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnPurchase
            // 
            this.btnPurchase.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnPurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.btnPurchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPurchase.BorderRadius = 0;
            this.btnPurchase.ButtonText = "  PURCHASE";
            this.btnPurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPurchase.DisabledColor = System.Drawing.Color.Gray;
            this.btnPurchase.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPurchase.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPurchase.Iconimage")));
            this.btnPurchase.Iconimage_right = null;
            this.btnPurchase.Iconimage_right_Selected = null;
            this.btnPurchase.Iconimage_Selected = null;
            this.btnPurchase.IconMarginLeft = 0;
            this.btnPurchase.IconMarginRight = 0;
            this.btnPurchase.IconRightVisible = true;
            this.btnPurchase.IconRightZoom = 0D;
            this.btnPurchase.IconVisible = true;
            this.btnPurchase.IconZoom = 50D;
            this.btnPurchase.IsTab = false;
            this.btnPurchase.Location = new System.Drawing.Point(3, 101);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.btnPurchase.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnPurchase.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPurchase.selected = false;
            this.btnPurchase.Size = new System.Drawing.Size(161, 48);
            this.btnPurchase.TabIndex = 3;
            this.btnPurchase.Text = "  PURCHASE";
            this.btnPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchase.Textcolor = System.Drawing.Color.White;
            this.btnPurchase.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.btnProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProducts.BorderRadius = 0;
            this.btnProducts.ButtonText = "  PRODUCTS";
            this.btnProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProducts.DisabledColor = System.Drawing.Color.Gray;
            this.btnProducts.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProducts.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnProducts.Iconimage")));
            this.btnProducts.Iconimage_right = null;
            this.btnProducts.Iconimage_right_Selected = null;
            this.btnProducts.Iconimage_Selected = null;
            this.btnProducts.IconMarginLeft = 0;
            this.btnProducts.IconMarginRight = 0;
            this.btnProducts.IconRightVisible = true;
            this.btnProducts.IconRightZoom = 0D;
            this.btnProducts.IconVisible = true;
            this.btnProducts.IconZoom = 50D;
            this.btnProducts.IsTab = false;
            this.btnProducts.Location = new System.Drawing.Point(3, 53);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.btnProducts.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnProducts.OnHoverTextColor = System.Drawing.Color.White;
            this.btnProducts.selected = false;
            this.btnProducts.Size = new System.Drawing.Size(161, 48);
            this.btnProducts.TabIndex = 2;
            this.btnProducts.Text = "  PRODUCTS";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.Textcolor = System.Drawing.Color.White;
            this.btnProducts.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click_1);
            // 
            // pbChanger
            // 
            this.pbChanger.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbChanger.Image = global::WindowsFormsApplication1.Properties.Resources._71_1436214917;
            this.pbChanger.InitialImage = null;
            this.pbChanger.Location = new System.Drawing.Point(308, 6);
            this.pbChanger.Name = "pbChanger";
            this.pbChanger.Size = new System.Drawing.Size(38, 40);
            this.pbChanger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChanger.TabIndex = 3;
            this.pbChanger.TabStop = false;
            // 
            // lblChanger
            // 
            this.lblChanger.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblChanger.AutoSize = true;
            this.lblChanger.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChanger.Location = new System.Drawing.Point(348, 14);
            this.lblChanger.Name = "lblChanger";
            this.lblChanger.Size = new System.Drawing.Size(56, 23);
            this.lblChanger.TabIndex = 2;
            this.lblChanger.Text = "label1";
            // 
            // pnlWorking
            // 
            this.pnlWorking.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlWorking.BackColor = System.Drawing.SystemColors.Control;
            this.pnlWorking.Location = new System.Drawing.Point(183, 57);
            this.pnlWorking.Name = "pnlWorking";
            this.pnlWorking.Size = new System.Drawing.Size(712, 457);
            this.pnlWorking.TabIndex = 8;
            // 
            // frmApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 539);
            this.Controls.Add(this.pnlWorking);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlnevigator);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlLine);
            this.Name = "frmApp";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmApp";
            this.Load += new System.EventHandler(this.frmApp_Load_1);
            this.pnlnevigator.ResumeLayout(false);
            this.pnlnevigator.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbChanger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlnevigator;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlSlider;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdmin;
        private Bunifu.Framework.UI.BunifuFlatButton btnDashboard;
        private Bunifu.Framework.UI.BunifuFlatButton btnSales;
        private Bunifu.Framework.UI.BunifuFlatButton btnPurchase;
        private Bunifu.Framework.UI.BunifuFlatButton btnProducts;
        private System.Windows.Forms.Panel pnlLine;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.PictureBox pbChanger;
        public System.Windows.Forms.Label lblChanger;
        private System.Windows.Forms.Panel pnlWorking;
    }
}