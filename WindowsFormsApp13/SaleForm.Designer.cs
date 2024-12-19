namespace WindowsFormsApp13
{
    partial class SaleForm
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
            this.gbAdminFeature = new System.Windows.Forms.GroupBox();
            this.btnManageCustomer = new System.Windows.Forms.Button();
            this.btnManageOrder = new System.Windows.Forms.Button();
            this.gbAdminFeature.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAdminFeature
            // 
            this.gbAdminFeature.Controls.Add(this.btnManageOrder);
            this.gbAdminFeature.Controls.Add(this.btnManageCustomer);
            this.gbAdminFeature.Location = new System.Drawing.Point(12, 12);
            this.gbAdminFeature.Name = "gbAdminFeature";
            this.gbAdminFeature.Size = new System.Drawing.Size(491, 144);
            this.gbAdminFeature.TabIndex = 1;
            this.gbAdminFeature.TabStop = false;
            this.gbAdminFeature.Text = "Sale feature";
            // 
            // btnManageCustomer
            // 
            this.btnManageCustomer.Location = new System.Drawing.Point(33, 42);
            this.btnManageCustomer.Name = "btnManageCustomer";
            this.btnManageCustomer.Size = new System.Drawing.Size(199, 44);
            this.btnManageCustomer.TabIndex = 5;
            this.btnManageCustomer.Text = "Manage Customer";
            this.btnManageCustomer.UseVisualStyleBackColor = true;
            this.btnManageCustomer.Click += new System.EventHandler(this.btnManageCustomer_Click);
            // 
            // btnManageOrder
            // 
            this.btnManageOrder.Location = new System.Drawing.Point(255, 42);
            this.btnManageOrder.Name = "btnManageOrder";
            this.btnManageOrder.Size = new System.Drawing.Size(199, 44);
            this.btnManageOrder.TabIndex = 5;
            this.btnManageOrder.Text = "Manage Order";
            this.btnManageOrder.UseVisualStyleBackColor = true;
            this.btnManageOrder.Click += new System.EventHandler(this.btnManageOrder_Click);
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 216);
            this.Controls.Add(this.gbAdminFeature);
            this.Name = "SaleForm";
            this.Text = "SaleForm";
            this.gbAdminFeature.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAdminFeature;
        private System.Windows.Forms.Button btnManageCustomer;
        private System.Windows.Forms.Button btnManageOrder;
    }
}