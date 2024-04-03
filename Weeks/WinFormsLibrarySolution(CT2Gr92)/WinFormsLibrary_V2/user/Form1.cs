
using WinFormsLibrary_V2.bus;

namespace WinFormsLibrary_V2.user

{
    public partial class Form1 : Form
    {
        //declaration reference variables
        Book currentBook;    
        
        Date currentPublishedDate;

        List<Book> listOfBooks = new List<Book>();
        public Form1()
        {
            InitializeComponent();
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //initialize and create the reference variables
            currentBook = new Book();
            currentPublishedDate = new Date();           

            int number;
            string? title;            

            number = Convert.ToInt32(this.textBoxNumber.Text);
            title = this.textBoxTitle.Text;

            currentBook.Number = number;
            currentBook.Title = title;

            //language
            EnumLanguage currentLanguage;
            Enum.TryParse(this.comboBoxLanguage.Text, out currentLanguage);
                 currentBook.Language = currentLanguage;

            //published date           
            currentPublishedDate.Month = Convert.ToInt32(this.textBoxMonth.Text);
            currentPublishedDate.Day= Convert.ToInt32(this.textBoxDay.Text);
            currentPublishedDate.Year = Convert.ToInt32(this.textBoxYear.Text);

            currentBook.PublishedDate = currentPublishedDate;   

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
            this.textBoxNumber.Text = string.Empty;
            this.textBoxTitle.Text =string.Empty;

            this.textBoxMonth.Text = string.Empty;
            this.textBoxDay.Text = string.Empty;
            this.textBoxYear.Text = string.Empty;


            this.textBoxNumber.Focus();

            this.listBoxBookLibrary.Items.Clear();

            this.comboBoxLanguage.Text = Convert.ToString(EnumLanguage.UNDEFINED);
        }



        private void buttonExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application written by Houria Houmel", "Event Programming with C#", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (EnumLanguage item in Enum.GetValues(typeof(EnumLanguage)))
            {
                this.comboBoxLanguage.Items.Add(item);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            bool found = false;
            Book searchedBook = new Book();

            foreach (Book item in this.listOfBooks)
            {
                if (item.Number  == Convert.ToInt32(this.textBoxNumber.Text))
                {
                    found = true;
                    searchedBook = item;
                    break;                
                }            
            }

            if (found)
            {
                MessageBox.Show("Book found \n  " + searchedBook.GetBookState() , "Event programming with C#", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.listBoxBookLibrary.Items.Add(searchedBook.GetBookState());
            }
            else {
                
                MessageBox.Show("Book not found", "Event programming with C#" , MessageBoxButtons.OK , MessageBoxIcon.Information);
            }



        }
    }
}
