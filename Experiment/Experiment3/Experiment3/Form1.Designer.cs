namespace Experiment3
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
            label1 = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            lblEmail = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            btnTest = new Button();
            txtConfirmPassword = new TextBox();
            lblConfirmPassword = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(59, 19);
            label1.Name = "label1";
            label1.Size = new Size(132, 27);
            label1.TabIndex = 0;
            label1.Text = "用户注册验证";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(33, 68);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(44, 17);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "用户名";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(34, 97);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(32, 17);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "密码";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(35, 155);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(32, 17);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "邮箱";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(96, 91);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(119, 23);
            txtPassword.TabIndex = 5;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(96, 62);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(119, 23);
            txtUsername.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(96, 149);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(119, 23);
            txtEmail.TabIndex = 7;
            // 
            // btnTest
            // 
            btnTest.Location = new Point(35, 178);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(182, 27);
            btnTest.TabIndex = 8;
            btnTest.Text = "验证";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(96, 120);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(119, 23);
            txtConfirmPassword.TabIndex = 10;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(34, 126);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(56, 17);
            lblConfirmPassword.TabIndex = 9;
            lblConfirmPassword.Text = "确认密码";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(250, 222);
            Controls.Add(txtConfirmPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(btnTest);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(lblEmail);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(label1);
            Name = "Form1";
            Text = "用户注册数据验证";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblEmail;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private TextBox txtEmail;
        private Button btnTest;
        private TextBox txtConfirmPassword;
        private Label lblConfirmPassword;
    }
}