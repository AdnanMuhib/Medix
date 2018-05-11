namespace WindowsFormsApplication1
{
    partial class frm_AddNames
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
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsames)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOlyNames
            // 
            this.txtOlyNames.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOlyNames.Location = new System.Drawing.Point(138, 54);
            this.txtOlyNames.Name = "txtOlyNames";
            this.txtOlyNames.Size = new System.Drawing.Size(115, 26);
            this.txtOlyNames.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Name";
            // 
            // dgvProductsames
            // 
            this.dgvProductsames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductsames.Location = new System.Drawing.Point(13, 135);
            this.dgvProductsames.Name = "dgvProductsames";
            this.dgvProductsames.Size = new System.Drawing.Size(325, 182);
            this.dgvProductsames.TabIndex = 2;
            // 
            // btnAddNames
            // 
            this.btnAddNames.Location = new System.Drawing.Point(286, 50);
            this.btnAddNames.Name = "btnAddNames";
            this.btnAddNames.Size = new System.Drawing.Size(54, 35);
            this.btnAddNames.TabIndex = 2;
            this.btnAddNames.Text = "Add";
            this.btnAddNames.UseVisualStyleBackColor = true;
            this.btnAddNames.Click += new System.EventHandler(this.btnAddNames_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Product Name Here";
            // 
            // frm_AddNames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 329);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddNames);
            this.Controls.Add(this.dgvProductsames);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOlyNames);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_AddNames";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Products";
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
        private System.Windows.Forms.Label label2;
    }
}