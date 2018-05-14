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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearching = new System.Windows.Forms.TextBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsames)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOlyNames
            // 
            this.txtOlyNames.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOlyNames.Location = new System.Drawing.Point(138, 54);
            this.txtOlyNames.Name = "txtOlyNames";
            this.txtOlyNames.Size = new System.Drawing.Size(150, 26);
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
            this.dgvProductsames.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductsames.Size = new System.Drawing.Size(240, 182);
            this.dgvProductsames.TabIndex = 2;
            // 
            // btnAddNames
            // 
            this.btnAddNames.Location = new System.Drawing.Point(294, 50);
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
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(254, 94);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 35);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(176, 94);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(62, 35);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearching
            // 
            this.txtSearching.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearching.Location = new System.Drawing.Point(13, 98);
            this.txtSearching.Name = "txtSearching";
            this.txtSearching.Size = new System.Drawing.Size(141, 26);
            this.txtSearching.TabIndex = 7;
            this.txtSearching.Text = "Search Product Here";
            this.txtSearching.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSearching_MouseClick);
            this.txtSearching.TextChanged += new System.EventHandler(this.txtSearching_TextChanged);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(259, 135);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(89, 35);
            this.btnShowAll.TabIndex = 8;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // frm_AddNames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 329);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.txtSearching);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
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
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearching;
        private System.Windows.Forms.Button btnShowAll;
    }
}