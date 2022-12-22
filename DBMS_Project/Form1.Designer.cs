namespace DBMS_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfrimPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegis = new System.Windows.Forms.Button();
            this.btnTranToLogin = new System.Windows.Forms.Button();
            this.cbbAccType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Showcard Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblUserName.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblUserName.Location = new System.Drawing.Point(36, 127);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(155, 18);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Enter User Name";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblPassword.Location = new System.Drawing.Point(100, 183);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(91, 18);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblConfirmPassword.Location = new System.Drawing.Point(36, 235);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(160, 18);
            this.lblConfirmPassword.TabIndex = 2;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(221, 123);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(146, 27);
            this.txtUserName.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(221, 183);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(207, 27);
            this.txtPassword.TabIndex = 4;
            // 
            // txtConfrimPassword
            // 
            this.txtConfrimPassword.Location = new System.Drawing.Point(224, 226);
            this.txtConfrimPassword.Name = "txtConfrimPassword";
            this.txtConfrimPassword.PasswordChar = '*';
            this.txtConfrimPassword.Size = new System.Drawing.Size(204, 27);
            this.txtConfrimPassword.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(166, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Register";
            // 
            // btnRegis
            // 
            this.btnRegis.Font = new System.Drawing.Font("Showcard Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnRegis.Location = new System.Drawing.Point(221, 432);
            this.btnRegis.Name = "btnRegis";
            this.btnRegis.Size = new System.Drawing.Size(157, 31);
            this.btnRegis.TabIndex = 7;
            this.btnRegis.Text = "Regis Now!";
            this.btnRegis.UseVisualStyleBackColor = true;
            this.btnRegis.Click += new System.EventHandler(this.btnRegis_Click);
            // 
            // btnTranToLogin
            // 
            this.btnTranToLogin.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTranToLogin.Location = new System.Drawing.Point(100, 489);
            this.btnTranToLogin.Name = "btnTranToLogin";
            this.btnTranToLogin.Size = new System.Drawing.Size(453, 49);
            this.btnTranToLogin.TabIndex = 8;
            this.btnTranToLogin.Text = "Have Account? Login Now";
            this.btnTranToLogin.UseVisualStyleBackColor = true;
            this.btnTranToLogin.Click += new EventHandler(btnLogin_Click);
            // 
            // cbbAccType
            // 
            this.cbbAccType.FormattingEnabled = true;
            this.cbbAccType.Items.AddRange(new object[] {
            "Nhân viên",
            "Đối Tác",
            "Tài Xế",
            "Khách hàng"});
            this.cbbAccType.Location = new System.Drawing.Point(651, 123);
            this.cbbAccType.Name = "cbbAccType";
            this.cbbAccType.Size = new System.Drawing.Size(151, 28);
            this.cbbAccType.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(520, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Account Type";
            //this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 631);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbAccType);
            this.Controls.Add(this.btnTranToLogin);
            this.Controls.Add(this.btnRegis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConfrimPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Name = "Form1";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblUserName;
        private Label lblPassword;
        private Label lblConfirmPassword;
        private TextBox txtUserName;
        private Label label1;
        private Button btnRegis;
        private Button btnTranToLogin;
        private ComboBox cbbAccType;
        private Label label2;
        private TextBox txtPassword;
        private TextBox txtConfrimPassword;
    }
}