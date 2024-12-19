namespace WindowsFormsApp13
{
    partial class WarehouseManagerForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnManagerProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp13.Properties.Resources.asm_anhr;
            this.pictureBox1.Location = new System.Drawing.Point(97, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(642, 357);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnManagerProduct
            // 
            this.btnManagerProduct.Location = new System.Drawing.Point(97, 57);
            this.btnManagerProduct.Name = "btnManagerProduct";
            this.btnManagerProduct.Size = new System.Drawing.Size(298, 149);
            this.btnManagerProduct.TabIndex = 1;
            this.btnManagerProduct.Text = "Manager Product";
            this.btnManagerProduct.UseVisualStyleBackColor = true;
            this.btnManagerProduct.Click += new System.EventHandler(this.btnManagerProduct_Click);
            // 
            // WarehouseManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 481);
            this.Controls.Add(this.btnManagerProduct);
            this.Controls.Add(this.pictureBox1);
            this.Name = "WarehouseManagerForm";
            this.Text = "WarehouseManagerForm";
            this.Load += new System.EventHandler(this.WarehouseManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnManagerProduct;
    }
}