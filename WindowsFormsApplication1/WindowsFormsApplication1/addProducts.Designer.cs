namespace WindowsFormsApplication1
{
    partial class addProducts
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
            this.txtOlyNames = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProductsames = new System.Windows.Forms.DataGridView();
            this.btnAddNames = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsames)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOlyNames
            // 
            this.txtOlyNames.Location = new System.Drawing.Point(108, 30);
            this.txtOlyNames.Name = "txtOlyNames";
            this.txtOlyNames.Size = new System.Drawing.Size(100, 20);
            this.txtOlyNames.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Name";
            // 
            // dgvProductsames
            // 
            this.dgvProductsames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductsames.Location = new System.Drawing.Point(30, 57);
            this.dgvProductsames.Name = "dgvProductsames";
            this.dgvProductsames.Size = new System.Drawing.Size(257, 198);
            this.dgvProductsames.TabIndex = 2;
            // 
            // btnAddNames
            // 
            this.btnAddNames.Location = new System.Drawing.Point(231, 28);
            this.btnAddNames.Name = "btnAddNames";
            this.btnAddNames.Size = new System.Drawing.Size(56, 23);
            this.btnAddNames.TabIndex = 3;
            this.btnAddNames.Text = "Add";
            this.btnAddNames.UseVisualStyleBackColor = true;
            this.btnAddNames.Click += new System.EventHandler(this.btnAddNames_Click);
            // 
            // addProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 267);
            this.Controls.Add(this.btnAddNames);
            this.Controls.Add(this.dgvProductsames);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOlyNames);
            this.Name = "addProducts";
            this.Text = "addProducts";
            this.Load += new System.EventHandler(this.addProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOlyNames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProductsames;
        private System.Windows.Forms.Button btnAddNames;
    }
}