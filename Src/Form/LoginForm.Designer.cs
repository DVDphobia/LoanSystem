namespace LoanSystem
{
    partial class LoginForm
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
            Password = new TextBox();
            Username = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Login = new Button();
            openFileDialog1 = new OpenFileDialog();
            Register = new Button();
            SuspendLayout();
            // 
            // Password
            // 
            Password.Location = new Point(81, 41);
            Password.Name = "Password";
            Password.Size = new Size(326, 23);
            Password.TabIndex = 0;
            Password.TextChanged += textBox1_TextChanged;
            // 
            // Username
            // 
            Username.Location = new Point(81, 12);
            Username.Name = "Username";
            Username.Size = new Size(326, 23);
            Username.TabIndex = 1;
            Username.TextChanged += Username_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 20);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 49);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // Login
            // 
            Login.Location = new Point(247, 70);
            Login.Name = "Login";
            Login.Size = new Size(160, 23);
            Login.TabIndex = 4;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Register
            // 
            Register.Location = new Point(81, 70);
            Register.Name = "Register";
            Register.Size = new Size(160, 23);
            Register.TabIndex = 5;
            Register.Text = "Register";
            Register.UseVisualStyleBackColor = true;
            Register.Click += Register_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 137);
            Controls.Add(Register);
            Controls.Add(Login);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Username);
            Controls.Add(Password);
            Name = "LoginForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Password;
        private TextBox Username;
        private Label label1;
        private Label label2;
        private Button Login;
        private OpenFileDialog openFileDialog1;
        private Button Register;
    }
}
