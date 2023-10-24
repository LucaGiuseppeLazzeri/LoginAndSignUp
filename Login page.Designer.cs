namespace CreateUser
{
    partial class Login_page
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
            Button button_login;
            Button button_register;
            txt_password = new TextBox();
            txt_username = new TextBox();
            labelUsername = new Label();
            lablePassword = new Label();
            button_login = new Button();
            button_register = new Button();
            SuspendLayout();
            // 
            // button_login
            // 
            button_login.Location = new Point(194, 262);
            button_login.Name = "button_login";
            button_login.Size = new Size(94, 29);
            button_login.TabIndex = 4;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // button_register
            // 
            button_register.Location = new Point(359, 262);
            button_register.Name = "button_register";
            button_register.Size = new Size(94, 29);
            button_register.TabIndex = 5;
            button_register.Text = "Register";
            button_register.UseVisualStyleBackColor = true;
            button_register.Click += button_register_Click;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(163, 190);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(343, 27);
            txt_password.TabIndex = 0;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(163, 129);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(343, 27);
            txt_username.TabIndex = 1;
            txt_username.TextChanged += txt_username_TextChanged;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(49, 132);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(75, 20);
            labelUsername.TabIndex = 2;
            labelUsername.Text = "Username";
            labelUsername.Click += label1_Click;
            // 
            // lablePassword
            // 
            lablePassword.AutoSize = true;
            lablePassword.Location = new Point(49, 193);
            lablePassword.Name = "lablePassword";
            lablePassword.Size = new Size(70, 20);
            lablePassword.TabIndex = 3;
            lablePassword.Text = "Password";
            lablePassword.Click += label2_Click;
            // 
            // Login_page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_register);
            Controls.Add(button_login);
            Controls.Add(lablePassword);
            Controls.Add(labelUsername);
            Controls.Add(txt_username);
            Controls.Add(txt_password);
            Name = "Login_page";
            Text = "Login_page";
            Load += Login_page_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_password;
        private TextBox txt_username;
        private Label labelUsername;
        private Label lablePassword;
    }
}