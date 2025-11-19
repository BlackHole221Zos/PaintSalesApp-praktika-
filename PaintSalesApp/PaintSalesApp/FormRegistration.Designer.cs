namespace PaintSalesApp
{
    partial class FormRegistration
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(150, 50);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(150, 22);
            this.tbLogin.TabIndex = 0;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(150, 100);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(150, 22);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(150, 200);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 30);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Зарегистрироваться";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(50, 53);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(47, 16);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "Логин:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(50, 103);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(59, 16);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Пароль:";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(50, 153);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(44, 16);
            this.lblRole.TabIndex = 5;
            this.lblRole.Text = "Роль:";
            // 
            // cbRole
            // 
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(150, 150);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(150, 24);
            this.cbRole.TabIndex = 6;
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 270);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Name = "FormRegistration";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cbRole;
    }
}