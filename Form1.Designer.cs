namespace CreateUser
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
            label_FirstName = new Label();
            txt_firstname = new TextBox();
            label_Lastname = new Label();
            label_Username = new Label();
            label_Password = new Label();
            label_ConfirmPassword = new Label();
            txt_LastName = new TextBox();
            txt_Username = new TextBox();
            txt_Password = new TextBox();
            txt_ConPass = new TextBox();
            button_Submit = new Button();
            SuspendLayout();
            // 
            // label_FirstName
            // 
            label_FirstName.AutoSize = true;
            label_FirstName.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label_FirstName.Location = new Point(80, 114);
            label_FirstName.Margin = new Padding(4, 0, 4, 0);
            label_FirstName.Name = "label_FirstName";
            label_FirstName.Size = new Size(99, 24);
            label_FirstName.TabIndex = 0;
            label_FirstName.Text = "First Name";
            label_FirstName.Click += label1_Click;
            // 
            // txt_firstname
            // 
            txt_firstname.Location = new Point(248, 109);
            txt_firstname.Margin = new Padding(4);
            txt_firstname.Name = "txt_firstname";
            txt_firstname.Size = new Size(867, 31);
            txt_firstname.TabIndex = 1;
            // 
            // label_Lastname
            // 
            label_Lastname.AutoSize = true;
            label_Lastname.Location = new Point(80, 174);
            label_Lastname.Margin = new Padding(4, 0, 4, 0);
            label_Lastname.Name = "label_Lastname";
            label_Lastname.Size = new Size(95, 24);
            label_Lastname.TabIndex = 2;
            label_Lastname.Text = "Last Name";
            // 
            // label_Username
            // 
            label_Username.AutoSize = true;
            label_Username.Location = new Point(80, 388);
            label_Username.Margin = new Padding(4, 0, 4, 0);
            label_Username.Name = "label_Username";
            label_Username.Size = new Size(90, 24);
            label_Username.TabIndex = 5;
            label_Username.Text = "Username";
            // 
            // label_Password
            // 
            label_Password.AutoSize = true;
            label_Password.Location = new Point(80, 462);
            label_Password.Margin = new Padding(4, 0, 4, 0);
            label_Password.Name = "label_Password";
            label_Password.Size = new Size(85, 24);
            label_Password.TabIndex = 6;
            label_Password.Text = "Password";
            // 
            // label_ConfirmPassword
            // 
            label_ConfirmPassword.AutoSize = true;
            label_ConfirmPassword.Location = new Point(80, 526);
            label_ConfirmPassword.Margin = new Padding(4, 0, 4, 0);
            label_ConfirmPassword.Name = "label_ConfirmPassword";
            label_ConfirmPassword.Size = new Size(153, 24);
            label_ConfirmPassword.TabIndex = 7;
            label_ConfirmPassword.Text = "Confirm Password";
            // 
            // txt_LastName
            // 
            txt_LastName.Location = new Point(248, 174);
            txt_LastName.Margin = new Padding(4);
            txt_LastName.Name = "txt_LastName";
            txt_LastName.Size = new Size(867, 31);
            txt_LastName.TabIndex = 8;
            // 
            // txt_Username
            // 
            txt_Username.Location = new Point(248, 384);
            txt_Username.Margin = new Padding(4);
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new Size(867, 31);
            txt_Username.TabIndex = 11;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(248, 458);
            txt_Password.Margin = new Padding(4);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(867, 31);
            txt_Password.TabIndex = 12;
            // 
            // txt_ConPass
            // 
            txt_ConPass.Location = new Point(248, 513);
            txt_ConPass.Margin = new Padding(4);
            txt_ConPass.Name = "txt_ConPass";
            txt_ConPass.Size = new Size(867, 31);
            txt_ConPass.TabIndex = 13;
            txt_ConPass.TextChanged += txt_ConPass_TextChanged;
            // 
            // button_Submit
            // 
            button_Submit.Location = new Point(304, 644);
            button_Submit.Margin = new Padding(4);
            button_Submit.Name = "button_Submit";
            button_Submit.Size = new Size(117, 35);
            button_Submit.TabIndex = 14;
            button_Submit.Text = "Submit";
            button_Submit.UseVisualStyleBackColor = true;
            button_Submit.Click += button_Submit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1360, 803);
            Controls.Add(button_Submit);
            Controls.Add(txt_ConPass);
            Controls.Add(txt_Password);
            Controls.Add(txt_Username);
            Controls.Add(txt_LastName);
            Controls.Add(label_ConfirmPassword);
            Controls.Add(label_Password);
            Controls.Add(label_Username);
            Controls.Add(label_Lastname);
            Controls.Add(txt_firstname);
            Controls.Add(label_FirstName);
            Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "SQL";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label_FirstName;
        private TextBox txt_firstname;
        private Label label_Lastname;
        private Label label3;
        private Label label4;
        private Label label_Username;
        private Label label_Password;
        private Label label_ConfirmPassword;
        private TextBox txt_LastName;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox txt_Username;
        private TextBox txt_Password;
        private TextBox txt_ConPass;
        private Button button_Submit;
    }
}