namespace WindowsFormsApp13
{
    partial class AdminForm
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
            this.btnManageOrder = new System.Windows.Forms.Button();
            this.btnManageProduct = new System.Windows.Forms.Button();
            this.btnViewStatistic = new System.Windows.Forms.Button();
            this.btnManageImport = new System.Windows.Forms.Button();
            this.btnManageCategory = new System.Windows.Forms.Button();
            this.btnManageEmployee = new System.Windows.Forms.Button();
            this.gbAdminFeature.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAdminFeature
            // 
            this.gbAdminFeature.Controls.Add(this.btnManageOrder);
            this.gbAdminFeature.Controls.Add(this.btnManageProduct);
            this.gbAdminFeature.Controls.Add(this.btnViewStatistic);
            this.gbAdminFeature.Controls.Add(this.btnManageImport);
            this.gbAdminFeature.Controls.Add(this.btnManageCategory);
            this.gbAdminFeature.Controls.Add(this.btnManageEmployee);
            this.gbAdminFeature.Location = new System.Drawing.Point(12, 12);
            this.gbAdminFeature.Name = "gbAdminFeature";
            this.gbAdminFeature.Size = new System.Drawing.Size(776, 426);
            this.gbAdminFeature.TabIndex = 0;
            this.gbAdminFeature.TabStop = false;
            this.gbAdminFeature.Text = "Admin feature";
            this.gbAdminFeature.Enter += new System.EventHandler(this.gbAdminFeature_Enter);
            // 
            // btnManageOrder
            // 
            this.btnManageOrder.Location = new System.Drawing.Point(459, 155);
            this.btnManageOrder.Name = "btnManageOrder";
            this.btnManageOrder.Size = new System.Drawing.Size(199, 44);
            this.btnManageOrder.TabIndex = 5;
            this.btnManageOrder.Text = "Manage Order";
            this.btnManageOrder.UseVisualStyleBackColor = true;
            this.btnManageOrder.Click += new System.EventHandler(this.btnManageOrder_Click);
            // 
            // btnManageProduct
            // 
            this.btnManageProduct.Location = new System.Drawing.Point(459, 61);
            this.btnManageProduct.Name = "btnManageProduct";
            this.btnManageProduct.Size = new System.Drawing.Size(199, 51);
            this.btnManageProduct.TabIndex = 4;
            this.btnManageProduct.Text = "Manage Product";
            this.btnManageProduct.UseVisualStyleBackColor = true;
            this.btnManageProduct.Click += new System.EventHandler(this.btnManageProduct_Click);
            // 
            // btnViewStatistic
            // 
            this.btnViewStatistic.Location = new System.Drawing.Point(76, 324);
            this.btnViewStatistic.Name = "btnViewStatistic";
            this.btnViewStatistic.Size = new System.Drawing.Size(582, 61);
            this.btnViewStatistic.TabIndex = 3;
            this.btnViewStatistic.Text = "View statistic";
            this.btnViewStatistic.UseVisualStyleBackColor = true;
            this.btnViewStatistic.Click += new System.EventHandler(this.btnViewStatistic_Click);
            // 
            // btnManageImport
            // 
            this.btnManageImport.Location = new System.Drawing.Point(76, 246);
            this.btnManageImport.Name = "btnManageImport";
            this.btnManageImport.Size = new System.Drawing.Size(204, 43);
            this.btnManageImport.TabIndex = 2;
            this.btnManageImport.Text = "Manage Import";
            this.btnManageImport.UseVisualStyleBackColor = true;
            this.btnManageImport.Click += new System.EventHandler(this.btnManageImport_Click);
            // 
            // btnManageCategory
            // 
            this.btnManageCategory.Location = new System.Drawing.Point(76, 155);
            this.btnManageCategory.Name = "btnManageCategory";
            this.btnManageCategory.Size = new System.Drawing.Size(204, 44);
            this.btnManageCategory.TabIndex = 1;
            this.btnManageCategory.Text = "Manage Category";
            this.btnManageCategory.UseVisualStyleBackColor = true;
            this.btnManageCategory.Click += new System.EventHandler(this.btnManageCategory_Click);
            // 
            // btnManageEmployee
            // 
            this.btnManageEmployee.Location = new System.Drawing.Point(76, 61);
            this.btnManageEmployee.Name = "btnManageEmployee";
            this.btnManageEmployee.Size = new System.Drawing.Size(204, 51);
            this.btnManageEmployee.TabIndex = 0;
            this.btnManageEmployee.Text = "Manage Employee";
            this.btnManageEmployee.UseVisualStyleBackColor = true;
            this.btnManageEmployee.Click += new System.EventHandler(this.btnManageEmployee_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbAdminFeature);
            this.Name = "AdminForm";
            this.Text = "admin";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.gbAdminFeature.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAdminFeature;
        private System.Windows.Forms.Button btnManageOrder;
        private System.Windows.Forms.Button btnManageProduct;
        private System.Windows.Forms.Button btnViewStatistic;
        private System.Windows.Forms.Button btnManageImport;
        private System.Windows.Forms.Button btnManageCategory;
        private System.Windows.Forms.Button btnManageEmployee;
    }
}