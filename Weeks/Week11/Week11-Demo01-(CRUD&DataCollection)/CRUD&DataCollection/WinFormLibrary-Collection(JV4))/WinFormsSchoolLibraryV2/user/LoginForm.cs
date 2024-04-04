using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsSchoolLibraryV3.user
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (this.textBoxUserName.Text == "user1" && this.textBoxPassword.Text == "123")
            {
                Form1 myMainForm = new Form1();
                this.Hide();

                myMainForm.ShowDialog();

                this.Dispose();
            
            }
            else {

                MessageBox.Show("invalid input");
                this.textBoxUserName.Clear(); this.textBoxPassword.Clear();
                this.textBoxUserName.Focus();
            
            }
        }
    }
}
