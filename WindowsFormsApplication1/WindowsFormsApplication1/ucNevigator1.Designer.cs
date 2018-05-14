namespace WindowsFormsApplication1
{
    partial class ucNevigator1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblChanger = new System.Windows.Forms.Label();
            this.pbChanger = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbChanger)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChanger
            // 
            this.lblChanger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChanger.AutoSize = true;
            this.lblChanger.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChanger.Location = new System.Drawing.Point(307, 9);
            this.lblChanger.Name = "lblChanger";
            this.lblChanger.Size = new System.Drawing.Size(56, 23);
            this.lblChanger.TabIndex = 0;
            this.lblChanger.Text = "label1";
            // 
            // pbChanger
            // 
            this.pbChanger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbChanger.Image = global::WindowsFormsApplication1.Properties.Resources._71_1436214917;
            this.pbChanger.InitialImage = null;
            this.pbChanger.Location = new System.Drawing.Point(268, 2);
            this.pbChanger.Name = "pbChanger";
            this.pbChanger.Size = new System.Drawing.Size(32, 37);
            this.pbChanger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChanger.TabIndex = 1;
            this.pbChanger.TabStop = false;
            // 
            // ucNevigator1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.pbChanger);
            this.Controls.Add(this.lblChanger);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ucNevigator1";
            this.Size = new System.Drawing.Size(625, 42);
            ((System.ComponentModel.ISupportInitialize)(this.pbChanger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblChanger;
        private System.Windows.Forms.PictureBox pbChanger;
    }
}
