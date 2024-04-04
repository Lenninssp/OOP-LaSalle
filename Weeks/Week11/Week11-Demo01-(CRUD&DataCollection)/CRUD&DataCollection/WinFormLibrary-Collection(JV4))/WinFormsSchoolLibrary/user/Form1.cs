

using WinFormsSchoolLibraryV3.bus;

namespace WinFormsSchoolLibraryV3.user
{

    //: is the inheritance

    //Form1 is the name of the class
    public partial class Form1 : Form
    {
        List<Book> listOfBooks = new List<Book>();

                Book book1; Book book2;

        //Form1() is the default constructor of the class Form1.....................?????????????
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonShowMessage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome To Windows Forms Proramming", "Course Number: 420-CT2-AS",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //DO NOT type the event method by yourself
        //MUST BE GENERATED
        private void buttonExit_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Application written by Houria Houmel", "Course Number: 420-CT2-AS",
               MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();

        }


        //At the event Load of the Form1 we will create 2 books
        private void Form1_Load(object sender, EventArgs e)
        {
            book1 = new Book();
            book1.Number = 1;
            book1.Title = "C# - Windows Forms Programming";

            this.listOfBooks.Add(book1);

            book2 = new Book(2, "Java How To Program");
            this.listOfBooks.Add(book2);

        }

        private void buttonShowIndividualBook_Click(object sender, EventArgs e)
        {

            MessageBox.Show("book1 state:  " + book1.GetBookState(), "Course Number: 420-CT2-AS",
               MessageBoxButtons.OK, MessageBoxIcon.Information);

            MessageBox.Show("book2 state:  " + book2.GetBookState(), "Course Number: 420-CT2-AS",
              MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void buttonShowAllBooks_Click(object sender, EventArgs e)
        {
            if (this.listOfBooks.Count > 0 && this.listBoxSchoolLibrary.Items.Count == 0)
            {
                foreach (Book record in this.listOfBooks)
                {
                    this.listBoxSchoolLibrary.Items.Add(record.GetBookState());
                }

            }
            else { MessageBox.Show("The books already printed in the listBox or the list of books in memory is empty...."); }

        }
    }
}
