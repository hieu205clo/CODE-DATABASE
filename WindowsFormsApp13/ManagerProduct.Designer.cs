namespace WindowsFormsApp13
{
    partial class ManagerProduct
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
            this.gbProductInformation = new System.Windows.Forms.GroupBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.txtProductImg = new System.Windows.Forms.TextBox();
            this.txtProductQuantity = new System.Windows.Forms.TextBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.lblProductImage = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblProductQuantity = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbProductData = new System.Windows.Forms.GroupBox();
            this.dtgProduct = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.gbProductInformation.SuspendLayout();
            this.gbProductData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // gbProductInformation
            // 
            this.gbProductInformation.Controls.Add(this.btnUpload);
            this.gbProductInformation.Controls.Add(this.cbCategory);
            this.gbProductInformation.Controls.Add(this.txtProductImg);
            this.gbProductInformation.Controls.Add(this.txtProductQuantity);
            this.gbProductInformation.Controls.Add(this.txtProductPrice);
            this.gbProductInformation.Controls.Add(this.txtProductName);
            this.gbProductInformation.Controls.Add(this.txtProductCode);
            this.gbProductInformation.Controls.Add(this.lblProductImage);
            this.gbProductInformation.Controls.Add(this.btnClear);
            this.gbProductInformation.Controls.Add(this.btnDelete);
            this.gbProductInformation.Controls.Add(this.btnUpdate);
            this.gbProductInformation.Controls.Add(this.btnAdd);
            this.gbProductInformation.Controls.Add(this.lblCategory);
            this.gbProductInformation.Controls.Add(this.lblProductQuantity);
            this.gbProductInformation.Controls.Add(this.lblProductPrice);
            this.gbProductInformation.Controls.Add(this.lblProductName);
            this.gbProductInformation.Controls.Add(this.lblProductCode);
            this.gbProductInformation.Location = new System.Drawing.Point(12, 25);
            this.gbProductInformation.Name = "gbProductInformation";
            this.gbProductInformation.Size = new System.Drawing.Size(438, 383);
            this.gbProductInformation.TabIndex = 0;
            this.gbProductInformation.TabStop = false;
            this.gbProductInformation.Text = "Product Information";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(327, 207);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(42, 23);
            this.btnUpload.TabIndex = 16;
            this.btnUpload.Text = "...";
            this.btnUpload.UseVisualStyleBackColor = true;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(174, 245);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(195, 24);
            this.cbCategory.TabIndex = 15;
            // 
            // txtProductImg
            // 
            this.txtProductImg.Enabled = false;
            this.txtProductImg.Location = new System.Drawing.Point(174, 207);
            this.txtProductImg.Name = "txtProductImg";
            this.txtProductImg.ReadOnly = true;
            this.txtProductImg.Size = new System.Drawing.Size(147, 22);
            this.txtProductImg.TabIndex = 14;
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.Location = new System.Drawing.Point(174, 154);
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.Size = new System.Drawing.Size(195, 22);
            this.txtProductQuantity.TabIndex = 13;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(174, 113);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(195, 22);
            this.txtProductPrice.TabIndex = 12;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(174, 73);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(195, 22);
            this.txtProductName.TabIndex = 11;
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(174, 35);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(195, 22);
            this.txtProductCode.TabIndex = 10;
            // 
            // lblProductImage
            // 
            this.lblProductImage.AutoSize = true;
            this.lblProductImage.Location = new System.Drawing.Point(18, 207);
            this.lblProductImage.Name = "lblProductImage";
            this.lblProductImage.Size = new System.Drawing.Size(94, 16);
            this.lblProductImage.TabIndex = 9;
            this.lblProductImage.Text = "Product Image";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(283, 341);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(39, 341);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(283, 285);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(39, 285);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(18, 248);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(62, 16);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Category";
            // 
            // lblProductQuantity
            // 
            this.lblProductQuantity.AutoSize = true;
            this.lblProductQuantity.Location = new System.Drawing.Point(18, 160);
            this.lblProductQuantity.Name = "lblProductQuantity";
            this.lblProductQuantity.Size = new System.Drawing.Size(104, 16);
            this.lblProductQuantity.TabIndex = 3;
            this.lblProductQuantity.Text = "Product Quantity";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(18, 116);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(87, 16);
            this.lblProductPrice.TabIndex = 2;
            this.lblProductPrice.Text = "Product Price";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(18, 73);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(93, 16);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product Name";
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Location = new System.Drawing.Point(18, 35);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(89, 16);
            this.lblProductCode.TabIndex = 0;
            this.lblProductCode.Text = "Product Code";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(40, 420);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gbProductData
            // 
            this.gbProductData.Controls.Add(this.dtgProduct);
            this.gbProductData.Controls.Add(this.txtSearch);
            this.gbProductData.Location = new System.Drawing.Point(456, 25);
            this.gbProductData.Name = "gbProductData";
            this.gbProductData.Size = new System.Drawing.Size(332, 383);
            this.gbProductData.TabIndex = 2;
            this.gbProductData.TabStop = false;
            this.gbProductData.Text = "Product Data";
            // 
            // dtgProduct
            // 
            this.dtgProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProduct.Location = new System.Drawing.Point(6, 49);
            this.dtgProduct.Name = "dtgProduct";
            this.dtgProduct.RowHeadersWidth = 51;
            this.dtgProduct.RowTemplate.Height = 24;
            this.dtgProduct.Size = new System.Drawing.Size(320, 328);
            this.dtgProduct.TabIndex = 1;
            this.dtgProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProduct_CellClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(177, 21);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(149, 22);
            this.txtSearch.TabIndex = 0;
            // 
            // ManagerProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbProductData);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbProductInformation);
            this.Name = "ManagerProduct";
            this.Text = "ManagerProduct";
            this.Load += new System.EventHandler(this.ManagerProduct_Load);
            this.gbProductInformation.ResumeLayout(false);
            this.gbProductInformation.PerformLayout();
            this.gbProductData.ResumeLayout(false);
            this.gbProductData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProductInformation;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblProductQuantity;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtProductQuantity;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label lblProductImage;
        private System.Windows.Forms.GroupBox gbProductData;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TextBox txtProductImg;
        private System.Windows.Forms.DataGridView dtgProduct;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnUpload;
    }
}