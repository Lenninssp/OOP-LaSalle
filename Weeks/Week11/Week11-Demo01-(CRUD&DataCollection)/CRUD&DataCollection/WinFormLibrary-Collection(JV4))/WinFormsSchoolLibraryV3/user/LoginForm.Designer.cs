

namespace WinFormsSchoolLibraryV3.user
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
            labelUserName = new Label();
            labelPassword = new Label();
            textBoxUserName = new TextBox();
            textBoxPassword = new TextBox();
            buttonLogin = new Button();
            SuspendLayout();
            // 
            // labelUserName
            // 
            labelUserName.BorderStyle = BorderStyle.Fixed3D;
            labelUserName.Location = new Point(37, 48);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(100, 23);
            labelUserName.TabIndex = 0;
            labelUserName.Text = "User name: ";
            labelUserName.TextAlign = ContentAlignment.MiddleCenter;
            labelUserName.Click += label1_Click;
            // 
            // labelPassword
            // 
            labelPassword.BorderStyle = BorderStyle.Fixed3D;
            labelPassword.Location = new Point(37, 105);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(100, 23);
            labelPassword.TabIndex = 1;
            labelPassword.Text = "Password:  ";
            labelPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(143, 49);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(100, 23);
            textBoxUserName.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(143, 106);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(100, 23);
            textBoxPassword.TabIndex = 3;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(89, 164);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(75, 39);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "LOGIN";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 254);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUserName);
            Controls.Add(labelPassword);
            Controls.Add(labelUserName);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUserName;
        private Label labelPassword;
        private TextBox textBoxUserName;
        private TextBox textBoxPassword;
        private Button buttonLogin;
    }
}