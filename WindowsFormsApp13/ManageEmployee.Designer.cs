namespace WindowsFormsApp13
{
    partial class ManageEmployee
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
            this.gbManageemployee = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dtgEmployee = new System.Windows.Forms.DataGridView();
            this.lblEmployeeList = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbEmployeeInformation = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbAuthorityLevel = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtEmployeePosition = new System.Windows.Forms.TextBox();
            this.txtEmployeeCode = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblAuthorityLevel = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblEmployeeCode = new System.Windows.Forms.Label();
            this.gbManageemployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmployee)).BeginInit();
            this.gbEmployeeInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbManageemployee
            // 
            this.gbManageemployee.Controls.Add(this.txtSearch);
            this.gbManageemployee.Controls.Add(this.dtgEmployee);
            this.gbManageemployee.Controls.Add(this.lblEmployeeList);
            this.gbManageemployee.Controls.Add(this.btnBack);
            this.gbManageemployee.Controls.Add(this.gbEmployeeInformation);
            this.gbManageemployee.Location = new System.Drawing.Point(12, 12);
            this.gbManageemployee.Name = "gbManageemployee";
            this.gbManageemployee.Size = new System.Drawing.Size(782, 434);
            this.gbManageemployee.TabIndex = 0;
            this.gbManageemployee.TabStop = false;
            this.gbManageemployee.Text = "0";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(595, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(143, 22);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // dtgEmployee
            // 
            this.dtgEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEmployee.Location = new System.Drawing.Point(416, 62);
            this.dtgEmployee.Name = "dtgEmployee";
            this.dtgEmployee.RowHeadersWidth = 51;
            this.dtgEmployee.RowTemplate.Height = 24;
            this.dtgEmployee.Size = new System.Drawing.Size(349, 335);
            this.dtgEmployee.TabIndex = 3;
            this.dtgEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEmployee_CellClick);
            // 
            // lblEmployeeList
            // 
            this.lblEmployeeList.AutoSize = true;
            this.lblEmployeeList.Location = new System.Drawing.Point(435, 31);
            this.lblEmployeeList.Name = "lblEmployeeList";
            this.lblEmployeeList.Size = new System.Drawing.Size(89, 16);
            this.lblEmployeeList.TabIndex = 2;
            this.lblEmployeeList.Text = "EmployeeList";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(34, 405);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(67, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gbEmployeeInformation
            // 
            this.gbEmployeeInformation.Controls.Add(this.btnClear);
            this.gbEmployeeInformation.Controls.Add(this.btnUpdate);
            this.gbEmployeeInformation.Controls.Add(this.btnDelete);
            this.gbEmployeeInformation.Controls.Add(this.btnAdd);
            this.gbEmployeeInformation.Controls.Add(this.cbAuthorityLevel);
            this.gbEmployeeInformation.Controls.Add(this.txtPassword);
            this.gbEmployeeInformation.Controls.Add(this.txtUsername);
            this.gbEmployeeInformation.Controls.Add(this.txtEmployeePosition);
            this.gbEmployeeInformation.Controls.Add(this.txtEmployeeCode);
            this.gbEmployeeInformation.Controls.Add(this.txtEmployeeName);
            this.gbEmployeeInformation.Controls.Add(this.lblPassword);
            this.gbEmployeeInformation.Controls.Add(this.lblUsername);
            this.gbEmployeeInformation.Controls.Add(this.lblAuthorityLevel);
            this.gbEmployeeInformation.Controls.Add(this.lblPosition);
            this.gbEmployeeInformation.Controls.Add(this.lblEmployeeName);
            this.gbEmployeeInformation.Controls.Add(this.lblEmployeeCode);
            this.gbEmployeeInformation.Location = new System.Drawing.Point(6, 21);
            this.gbEmployeeInformation.Name = "gbEmployeeInformation";
            this.gbEmployeeInformation.Size = new System.Drawing.Size(395, 376);
            this.gbEmployeeInformation.TabIndex = 0;
            this.gbEmployeeInformation.TabStop = false;
            this.gbEmployeeInformation.Text = "Employee Information";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(208, 346);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(208, 305);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(45, 346);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(45, 305);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbAuthorityLevel
            // 
            this.cbAuthorityLevel.FormattingEnabled = true;
            this.cbAuthorityLevel.Location = new System.Drawing.Point(140, 167);
            this.cbAuthorityLevel.Name = "cbAuthorityLevel";
            this.cbAuthorityLevel.Size = new System.Drawing.Size(121, 24);
            this.cbAuthorityLevel.TabIndex = 13;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(140, 261);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(121, 22);
            this.txtPassword.TabIndex = 12;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(140, 214);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(121, 22);
            this.txtUsername.TabIndex = 11;
            // 
            // txtEmployeePosition
            // 
            this.txtEmployeePosition.Location = new System.Drawing.Point(140, 127);
            this.txtEmployeePosition.Name = "txtEmployeePosition";
            this.txtEmployeePosition.Size = new System.Drawing.Size(121, 22);
            this.txtEmployeePosition.TabIndex = 9;
            // 
            // txtEmployeeCode
            // 
            this.txtEmployeeCode.Location = new System.Drawing.Point(140, 29);
            this.txtEmployeeCode.Name = "txtEmployeeCode";
            this.txtEmployeeCode.Size = new System.Drawing.Size(121, 22);
            this.txtEmployeeCode.TabIndex = 8;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(140, 80);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(121, 22);
            this.txtEmployeeName.TabIndex = 7;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(25, 261);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 16);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(25, 214);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(70, 16);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username";
            // 
            // lblAuthorityLevel
            // 
            this.lblAuthorityLevel.AutoSize = true;
            this.lblAuthorityLevel.Location = new System.Drawing.Point(25, 170);
            this.lblAuthorityLevel.Name = "lblAuthorityLevel";
            this.lblAuthorityLevel.Size = new System.Drawing.Size(36, 16);
            this.lblAuthorityLevel.TabIndex = 3;
            this.lblAuthorityLevel.Text = "Role";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(25, 127);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(55, 16);
            this.lblPosition.TabIndex = 2;
            this.lblPosition.Text = "Position";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(25, 80);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(62, 16);
            this.lblEmployeeName.TabIndex = 1;
            this.lblEmployeeName.Text = "Fullname";
            // 
            // lblEmployeeCode
            // 
            this.lblEmployeeCode.AutoSize = true;
            this.lblEmployeeCode.Location = new System.Drawing.Point(25, 35);
            this.lblEmployeeCode.Name = "lblEmployeeCode";
            this.lblEmployeeCode.Size = new System.Drawing.Size(40, 16);
            this.lblEmployeeCode.TabIndex = 0;
            this.lblEmployeeCode.Text = "Code";
            // 
            // ManageEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbManageemployee);
            this.Name = "ManageEmployee";
            this.Text = "ManageEmployee";
            this.gbManageemployee.ResumeLayout(false);
            this.gbManageemployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmployee)).EndInit();
            this.gbEmployeeInformation.ResumeLayout(false);
            this.gbEmployeeInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbManageemployee;
        private System.Windows.Forms.GroupBox gbEmployeeInformation;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblAuthorityLevel;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblEmployeeCode;
        private System.Windows.Forms.ComboBox cbAuthorityLevel;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtEmployeePosition;
        private System.Windows.Forms.TextBox txtEmployeeCode;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblEmployeeList;
        private System.Windows.Forms.DataGridView dtgEmployee;
        private System.Windows.Forms.TextBox txtSearch;
    }
}