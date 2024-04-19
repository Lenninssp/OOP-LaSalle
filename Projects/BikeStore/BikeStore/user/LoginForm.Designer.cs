namespace MyBikes.user
{
    partial class LoginForm
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
            labelUser = new Label();
            buttonLogin = new Button();
            labelPassword = new Label();
            textBoxUser = new TextBox();
            textBoxPassword = new TextBox();
            SuspendLayout();
            // 
            // labelUser
            // 
            labelUser.BackColor = Color.FromArgb(192, 192, 255);
            labelUser.BorderStyle = BorderStyle.Fixed3D;
            labelUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelUser.ForeColor = Color.Black;
            labelUser.Location = new Point(89, 43);
            labelUser.Margin = new Padding(2, 0, 2, 0);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(97, 30);
            labelUser.TabIndex = 13;
            labelUser.Text = "User:";
            labelUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.Transparent;
            buttonLogin.Location = new Point(154, 159);
            buttonLogin.Margin = new Padding(2);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(86, 40);
            buttonLogin.TabIndex = 17;
            buttonLogin.Text = "LOGIN";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // labelPassword
            // 
            labelPassword.BackColor = Color.FromArgb(192, 192, 255);
            labelPassword.BorderStyle = BorderStyle.Fixed3D;
            labelPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelPassword.ForeColor = Color.Black;
            labelPassword.Location = new Point(89, 95);
            labelPassword.Margin = new Padding(2, 0, 2, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(101, 32);
            labelPassword.TabIndex = 14;
            labelPassword.Text = "Password:";
            labelPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxUser
            // 
            textBoxUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textBoxUser.Location = new Point(204, 49);
            textBoxUser.Margin = new Padding(2);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(118, 27);
            textBoxUser.TabIndex = 15;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textBoxPassword.Location = new Point(204, 101);
            textBoxPassword.Margin = new Padding(2);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(118, 27);
            textBoxPassword.TabIndex = 16;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(409, 233);
            Controls.Add(labelUser);
            Controls.Add(buttonLogin);
            Controls.Add(labelPassword);
            Controls.Add(textBoxUser);
            Controls.Add(textBoxPassword);
            Margin = new Padding(2);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelUser;
        private Button buttonLogin;
        private Label labelPassword;
        private TextBox textBoxUser;
        private TextBox textBoxPassword;
    }
}