namespace WindowsFormsApplication1
{
    partial class frmEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv_app_create_invoice = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_sw_login = new System.Windows.Forms.Button();
            this.txt_app_price = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_app_qty = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_app_mname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_App_inv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_app_create_invoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Location = new System.Drawing.Point(271, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 31);
            this.button2.TabIndex = 45;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(642, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 31);
            this.button1.TabIndex = 44;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv_app_create_invoice
            // 
            this.dgv_app_create_invoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_app_create_invoice.Location = new System.Drawing.Point(271, 64);
            this.dgv_app_create_invoice.Name = "dgv_app_create_invoice";
            this.dgv_app_create_invoice.Size = new System.Drawing.Size(443, 158);
            this.dgv_app_create_invoice.TabIndex = 43;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(106, 189);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // btn_sw_login
            // 
            this.btn_sw_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_sw_login.Location = new System.Drawing.Point(160, 189);
            this.btn_sw_login.Name = "btn_sw_login";
            this.btn_sw_login.Size = new System.Drawing.Size(95, 31);
            this.btn_sw_login.TabIndex = 41;
            this.btn_sw_login.Text = "Add To Cart";
            this.btn_sw_login.UseVisualStyleBackColor = true;
            this.btn_sw_login.Click += new System.EventHandler(this.btn_sw_login_Click);
            // 
            // txt_app_price
            // 
            this.txt_app_price.Location = new System.Drawing.Point(106, 159);
            this.txt_app_price.Name = "txt_app_price";
            this.txt_app_price.Size = new System.Drawing.Size(149, 20);
            this.txt_app_price.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Price";
            // 
            // txt_app_qty
            // 
            this.txt_app_qty.Location = new System.Drawing.Point(106, 128);
            this.txt_app_qty.Name = "txt_app_qty";
            this.txt_app_qty.Size = new System.Drawing.Size(149, 20);
            this.txt_app_qty.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Quantity";
            // 
            // txt_app_mname
            // 
            this.txt_app_mname.Location = new System.Drawing.Point(106, 96);
            this.txt_app_mname.Name = "txt_app_mname";
            this.txt_app_mname.Size = new System.Drawing.Size(149, 20);
            this.txt_app_mname.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Medicine Name";
            // 
            // txt_App_inv
            // 
            this.txt_App_inv.Location = new System.Drawing.Point(106, 64);
            this.txt_App_inv.Name = "txt_App_inv";
            this.txt_App_inv.Size = new System.Drawing.Size(149, 20);
            this.txt_App_inv.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Invoice # ";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel12.Location = new System.Drawing.Point(13, 19);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(6, 25);
            this.panel12.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(24, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "Create Invoice";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 272);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_app_create_invoice);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_sw_login);
            this.Controls.Add(this.txt_app_price);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_app_qty);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_app_mname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_App_inv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.label5);
            this.Name = "frmEmployee";
            this.Text = "frmEmployee";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_app_create_invoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv_app_create_invoice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_sw_login;
        private System.Windows.Forms.TextBox txt_app_price;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_app_qty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_app_mname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_App_inv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label5;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}