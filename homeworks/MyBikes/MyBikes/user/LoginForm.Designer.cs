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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            labelUser = new Label();
            buttonLogin = new Button();
            labelPassword = new Label();
            textBoxUser = new TextBox();
            textBoxPassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(96, 150);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 74);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(96, 57);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(78, 76);
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // labelUser
            // 
            labelUser.BackColor = SystemColors.ScrollBar;
            labelUser.BorderStyle = BorderStyle.Fixed3D;
            labelUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelUser.ForeColor = Color.Black;
            labelUser.Location = new Point(198, 88);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(146, 45);
            labelUser.TabIndex = 13;
            labelUser.Text = "User:";
            labelUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.Transparent;
            buttonLogin.Location = new Point(291, 261);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(129, 60);
            buttonLogin.TabIndex = 17;
            buttonLogin.Text = "LOGIN";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // labelPassword
            // 
            labelPassword.BackColor = SystemColors.ScrollBar;
            labelPassword.BorderStyle = BorderStyle.Fixed3D;
            labelPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelPassword.ForeColor = Color.Black;
            labelPassword.Location = new Point(198, 167);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(151, 48);
            labelPassword.TabIndex = 14;
            labelPassword.Text = "Password:";
            labelPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxUser
            // 
            textBoxUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textBoxUser.Location = new Point(371, 98);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(175, 35);
            textBoxUser.TabIndex = 15;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textBoxPassword.Location = new Point(371, 176);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(175, 35);
            textBoxPassword.TabIndex = 16;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(614, 349);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(labelUser);
            Controls.Add(buttonLogin);
            Controls.Add(labelPassword);
            Controls.Add(textBoxUser);
            Controls.Add(textBoxPassword);
            Name = "LoginForm";
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label labelUser;
        private Button buttonLogin;
        private Label labelPassword;
        private TextBox textBoxUser;
        private TextBox textBoxPassword;
    }
}