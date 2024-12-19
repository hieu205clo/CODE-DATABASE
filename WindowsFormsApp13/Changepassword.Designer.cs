namespace WindowsFormsApp13
{
    partial class Changepassword
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
            this.gbChangePassword = new System.Windows.Forms.GroupBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblConfirmPasswod = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbChangePassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbChangePassword
            // 
            this.gbChangePassword.Controls.Add(this.btnClear);
            this.gbChangePassword.Controls.Add(this.btnChange);
            this.gbChangePassword.Controls.Add(this.txtConfirmPassword);
            this.gbChangePassword.Controls.Add(this.txtNewPassword);
            this.gbChangePassword.Controls.Add(this.lblConfirmPasswod);
            this.gbChangePassword.Controls.Add(this.lblNewPassword);
            this.gbChangePassword.Location = new System.Drawing.Point(31, 12);
            this.gbChangePassword.Name = "gbChangePassword";
            this.gbChangePassword.Size = new System.Drawing.Size(757, 426);
            this.gbChangePassword.TabIndex = 0;
            this.gbChangePassword.TabStop = false;
            this.gbChangePassword.Text = "Change pasword";
            this.gbChangePassword.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(87, 99);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(89, 16);
            this.lblNewPassword.TabIndex = 0;
            this.lblNewPassword.Text = "New pasword";
            // 
            // lblConfirmPasswod
            // 
            this.lblConfirmPasswod.AutoSize = true;
            this.lblConfirmPasswod.Location = new System.Drawing.Point(87, 213);
            this.lblConfirmPasswod.Name = "lblConfirmPasswod";
            this.lblConfirmPasswod.Size = new System.Drawing.Size(107, 16);
            this.lblConfirmPasswod.TabIndex = 1;
            this.lblConfirmPasswod.Text = "Confirm pasword";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(246, 82);
            this.txtNewPassword.Multiline = true;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(183, 33);
            this.txtNewPassword.TabIndex = 2;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(246, 198);
            this.txtConfirmPassword.Multiline = true;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(183, 34);
            this.txtConfirmPassword.TabIndex = 3;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(180, 315);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 4;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(386, 315);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // Changepassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbChangePassword);
            this.Name = "Changepassword";
            this.Text = "Changepassword";
            this.gbChangePassword.ResumeLayout(false);
            this.gbChangePassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbChangePassword;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblConfirmPasswod;
        private System.Windows.Forms.Label lblNewPassword;
    }
}