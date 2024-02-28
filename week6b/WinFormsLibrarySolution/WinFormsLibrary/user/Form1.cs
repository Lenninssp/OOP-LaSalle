
using WinFormsLibrary_V2.bus;

namespace WinFormsLibrary_V2.user
{
    public partial class Form1 : Form
    {
        //Declaration et creation d<une liste de livres

         List<Book> listOfBooks = new List<Book>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WELCOME TO C# PROGRAMMING ", "420-JV4-AS", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Application written by Houria Houmel ", "420-JV4-AS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        //Au chargement du formulaire Form1 (At the event Load)
        private void Form1_Load(object sender, EventArgs e)
        {
            Book book1 = new Book();
            book1.Number = 1;
            book1.Title = "C#";

            listOfBooks.Add(book1);


            Book book2 = new Book(2, "Python");

            listOfBooks.Add(book2);

        }

        private void buttonShowBook_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listOfBooks[0].GetBookState(), "...book 01...", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MessageBox.Show(listOfBooks[1].ToString(), "...book 02...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            if (this.listOfBooks.Count > 0 && this.listBoxLibrary.Items.Count == 0)
            {

                foreach (Book item in listOfBooks)
                {
                   

                    this.listBoxLibrary.Items.Add( item);
                }

            }

            else {

                MessageBox.Show("Books already printed");
            }

        }
    }
}
