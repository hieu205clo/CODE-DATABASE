namespace WindowsFormsApp13
{
    partial class ManagerCustomer
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
            this.gbCustomerManager = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dtgCustomer = new System.Windows.Forms.DataGridView();
            this.lblCustomerList = new System.Windows.Forms.Label();
            this.gbCustomerInformation = new System.Windows.Forms.GroupBox();
            this.btnClearr = new System.Windows.Forms.Button();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.txtPhonenumber = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerCode = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerCode = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbCustomerManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomer)).BeginInit();
            this.gbCustomerInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCustomerManager
            // 
            this.gbCustomerManager.Controls.Add(this.txtSearch);
            this.gbCustomerManager.Controls.Add(this.dtgCustomer);
            this.gbCustomerManager.Controls.Add(this.lblCustomerList);
            this.gbCustomerManager.Controls.Add(this.gbCustomerInformation);
            this.gbCustomerManager.Location = new System.Drawing.Point(12, 12);
            this.gbCustomerManager.Name = "gbCustomerManager";
            this.gbCustomerManager.Size = new System.Drawing.Size(776, 426);
            this.gbCustomerManager.TabIndex = 0;
            this.gbCustomerManager.TabStop = false;
            this.gbCustomerManager.Text = "Customer manager";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(620, 45);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(135, 22);
            this.txtSearch.TabIndex = 4;
            // 
            // dtgCustomer
            // 
            this.dtgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCustomer.Location = new System.Drawing.Point(435, 81);
            this.dtgCustomer.Name = "dtgCustomer";
            this.dtgCustomer.RowHeadersWidth = 51;
            this.dtgCustomer.RowTemplate.Height = 24;
            this.dtgCustomer.Size = new System.Drawing.Size(335, 326);
            this.dtgCustomer.TabIndex = 3;
            this.dtgCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCustomer_CellClick);
            // 
            // lblCustomerList
            // 
            this.lblCustomerList.AutoSize = true;
            this.lblCustomerList.Location = new System.Drawing.Point(475, 46);
            this.lblCustomerList.Name = "lblCustomerList";
            this.lblCustomerList.Size = new System.Drawing.Size(83, 16);
            this.lblCustomerList.TabIndex = 1;
            this.lblCustomerList.Text = "Customer list";
            // 
            // gbCustomerInformation
            // 
            this.gbCustomerInformation.Controls.Add(this.btnClearr);
            this.gbCustomerInformation.Controls.Add(this.txtCustomerAddress);
            this.gbCustomerInformation.Controls.Add(this.txtPhonenumber);
            this.gbCustomerInformation.Controls.Add(this.txtCustomerName);
            this.gbCustomerInformation.Controls.Add(this.txtCustomerCode);
            this.gbCustomerInformation.Controls.Add(this.btnDelete);
            this.gbCustomerInformation.Controls.Add(this.btnUpdate);
            this.gbCustomerInformation.Controls.Add(this.btnAdd);
            this.gbCustomerInformation.Controls.Add(this.lblAddress);
            this.gbCustomerInformation.Controls.Add(this.lblPhoneNumber);
            this.gbCustomerInformation.Controls.Add(this.lblCustomerName);
            this.gbCustomerInformation.Controls.Add(this.lblCustomerCode);
            this.gbCustomerInformation.Location = new System.Drawing.Point(15, 21);
            this.gbCustomerInformation.Name = "gbCustomerInformation";
            this.gbCustomerInformation.Size = new System.Drawing.Size(414, 386);
            this.gbCustomerInformation.TabIndex = 0;
            this.gbCustomerInformation.TabStop = false;
            this.gbCustomerInformation.Text = "Customer information";
            // 
            // btnClearr
            // 
            this.btnClearr.Location = new System.Drawing.Point(333, 348);
            this.btnClearr.Name = "btnClearr";
            this.btnClearr.Size = new System.Drawing.Size(75, 23);
            this.btnClearr.TabIndex = 12;
            this.btnClearr.Text = "Clear";
            this.btnClearr.UseVisualStyleBackColor = true;
            this.btnClearr.Click += new System.EventHandler(this.btnClear);
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Location = new System.Drawing.Point(179, 207);
            this.txtCustomerAddress.Multiline = true;
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(235, 135);
            this.txtCustomerAddress.TabIndex = 11;
            // 
            // txtPhonenumber
            // 
            this.txtPhonenumber.Location = new System.Drawing.Point(179, 157);
            this.txtPhonenumber.Name = "txtPhonenumber";
            this.txtPhonenumber.Size = new System.Drawing.Size(211, 22);
            this.txtPhonenumber.TabIndex = 10;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(179, 100);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(211, 22);
            this.txtCustomerName.TabIndex = 9;
            // 
            // txtCustomerCode
            // 
            this.txtCustomerCode.Location = new System.Drawing.Point(179, 35);
            this.txtCustomerCode.Name = "txtCustomerCode";
            this.txtCustomerCode.Size = new System.Drawing.Size(211, 22);
            this.txtCustomerCode.TabIndex = 8;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(213, 348);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(113, 348);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(21, 348);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(24, 207);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(58, 16);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(24, 157);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(94, 16);
            this.lblPhoneNumber.TabIndex = 2;
            this.lblPhoneNumber.Text = "Phone number";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(18, 103);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(104, 16);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblCustomerCode
            // 
            this.lblCustomerCode.AutoSize = true;
            this.lblCustomerCode.Location = new System.Drawing.Point(18, 41);
            this.lblCustomerCode.Name = "lblCustomerCode";
            this.lblCustomerCode.Size = new System.Drawing.Size(100, 16);
            this.lblCustomerCode.TabIndex = 0;
            this.lblCustomerCode.Text = "Customer Code";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(713, 444);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 37);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // ManagerCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 489);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbCustomerManager);
            this.Name = "ManagerCustomer";
            this.Text = "ManagerCustomer";
            this.Load += new System.EventHandler(this.ManagerCustomer_Load);
            this.gbCustomerManager.ResumeLayout(false);
            this.gbCustomerManager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomer)).EndInit();
            this.gbCustomerInformation.ResumeLayout(false);
            this.gbCustomerInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCustomerManager;
        private System.Windows.Forms.GroupBox gbCustomerInformation;
        private System.Windows.Forms.Label lblCustomerCode;

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerList;
        private System.Windows.Forms.DataGridView dtgCustomer;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.TextBox txtPhonenumber;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerCode;
        private System.Windows.Forms.Button btnClearr;
        private System.Windows.Forms.Button btnBack;
    }
}