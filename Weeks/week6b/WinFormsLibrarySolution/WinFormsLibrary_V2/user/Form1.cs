using WinFormsLibrary_V2.bus;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsLibrary_V2.user
{
    public partial class Form1 : Form
    {
        Book currentBook;
        List<Book> listOfBooks = new List<Book>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            currentBook = new Book();

            int number = Convert.ToInt32(this.textBoxNumber.Text);
            string title = this.textBoxTitle.Text;
            string isbn = this.textBoxISBN.Text;
            int pages = Convert.ToInt32(this.textBoxPages.Text);

            currentBook.Number = number;
            currentBook.Title = title;
            currentBook.Isbn = isbn;
            currentBook.Pages = pages;

            listOfBooks.Add(currentBook);
        }

        private void buttonPRINT_Click(object sender, EventArgs e)
        {
            if (this.listOfBooks.Count > 0 && this.listBoxBookLibrary.Items.Count == 0)
            {
                foreach (Book currentBook in this.listOfBooks)
                {
                    this.listBoxBookLibrary.Items.Add(currentBook);
                }

            }
            else { MessageBox.Show("Books already printed in the listBox...."); }

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            this.textBoxNumber.Text = "";
            this.textBoxTitle.Text = "";
            this.textBoxISBN.Text = "";
            this.textBoxPages.Text = "";

            this.textBoxNumber.Focus();

            this.listBoxBookLibrary.Items.Clear();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application written by Houria Houmel", "Event Programming with C#", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void textBoxNumber_TextChanged(object sender, EventArgs e)
        {
        }

        private void labelBookNumber_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
