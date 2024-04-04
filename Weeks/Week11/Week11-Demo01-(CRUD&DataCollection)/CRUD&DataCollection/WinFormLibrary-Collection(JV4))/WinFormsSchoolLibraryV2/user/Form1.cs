

using System;
using System.Xml;
using System.Xml.Serialization;
using WinFormsSchoolLibraryV3.bus;

namespace WinFormsSchoolLibraryV3.user
{
    public partial class Form1 : Form
    {
        //declare and create the list of books named listOfBooks
        List<Book> listOfBooks = new List<Book>();

        Book currentBook;
        Date currentPublishedDate;


        public Form1()
        {
            InitializeComponent();
        }


        //At the event Click of the button named buttonAdd
        //we will create a current book to add to the list of books
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int currentMonth, currentDay, currentYear;

            try
            {
                currentBook = new Book();

                currentPublishedDate = new Date();

                EnumLanguage currentLanguage;
                Enum.TryParse(this.comboBoxLanguage.Text, out currentLanguage);

                currentBook.Number = Convert.ToInt32(this.textBoxNumber.Text);
                currentBook.Title = this.textBoxTitle.Text;

                currentBook.Language = currentLanguage;

                currentMonth = Convert.ToInt32(this.textBoxMonth.Text);
                currentDay = Convert.ToInt32(this.textBoxDay.Text);
                currentYear = Convert.ToInt32(this.textBoxYear.Text);

                currentPublishedDate.Month = currentMonth;
                currentPublishedDate.Day = currentDay;
                currentPublishedDate.Year = currentYear;

                currentBook.PublishedDate = currentPublishedDate;

                listOfBooks.Add(currentBook);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n \t You must input a valid data");
                this.textBoxNumber.Focus();
            }


            this.buttonAdd.Enabled = false;

        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if (this.listOfBooks.Count > 0 && this.listBoxLibrary.Items.Count == 0)
            {
                foreach (Book book in this.listOfBooks)
                {
                    this.listBoxLibrary.Items.Add(book.GetBookState());
                }

            }
            else { MessageBox.Show("The books already printed in the listBox or the list of books in memory is empty...."); }

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            this.textBoxNumber.Text = string.Empty;
            this.textBoxTitle.Text = "";

            this.textBoxMonth.Text = string.Empty;
            this.textBoxDay.Text = string.Empty;
            this.textBoxYear.Text = string.Empty;


            this.textBoxNumber.Focus();

            this.listBoxLibrary.Items.Clear();

            this.comboBoxLanguage.Text = Convert.ToString(EnumLanguage.UNDEFINED);

            this.buttonAdd.Enabled = true;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Application written by Houria Houmel", "Event Programming with C#",
               MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            bool found = false;
            Book bookFound = new Book();

            foreach (Book item in this.listOfBooks)
            {
                if (item.Number == Convert.ToInt32(this.textBoxNumber.Text))
                {
                    found = true;
                    bookFound = item;
                    break;
                }
            }

            if (found)
            {
                MessageBox.Show("Book found ..." + bookFound.GetBookState(),
                      "Event Programming with C#", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.listBoxLibrary.Items.Add(bookFound.GetBookState());

            }
            else
            {
                MessageBox.Show("Book Not found ...",
                    "Event Programming with C#", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (EnumLanguage item in Enum.GetValues(typeof(EnumLanguage)))
            {
                this.comboBoxLanguage.Items.Add(item);
            }
            this.comboBoxLanguage.Text = Convert.ToString(EnumLanguage.UNDEFINED);

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {

        }


        //At the SelectedIndexChanged event on the listBoxLibrary

        int index = -1;
        private void listBoxLibrary_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = this.listBoxLibrary.SelectedIndex;

            this.textBoxNumber.Text = Convert.ToString(this.listOfBooks[index].Number);
            this.textBoxTitle.Text = this.listOfBooks[index].Title;

            //EnumLanguage
            this.comboBoxLanguage.Text = Convert.ToString(this.listOfBooks[index].Language);

            //Date
            this.textBoxMonth.Text = Convert.ToString(this.listOfBooks[index].PublishedDate.Month);
            this.textBoxDay.Text = Convert.ToString(this.listOfBooks[index].PublishedDate.Day);
            this.textBoxYear.Text = Convert.ToString(this.listOfBooks[index].PublishedDate.Year);


        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                this.listOfBooks[index].Number = Convert.ToInt32(this.textBoxNumber.Text);
                this.listOfBooks[index].Title = this.textBoxTitle.Text;

                //EnumLanguage
                EnumLanguage language;
                Enum.TryParse(this.comboBoxLanguage.Text, out language);
                this.listOfBooks[index].Language = language;

                //Date
                Date currentDate = new Date();

                currentDate.Month = Convert.ToInt32(this.textBoxMonth.Text);
                currentDate.Day = Convert.ToInt32(this.textBoxDay.Text);
                currentDate.Year = Convert.ToInt32(this.textBoxYear.Text);

                this.listOfBooks[index].PublishedDate = currentDate;
            }
            else
            {
                MessageBox.Show("Choose from the listBox the book to UPDATE");
            }

            this.listBoxLibrary.Items.Clear();

        }

        private void buttondELETE_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                this.listOfBooks.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Choose from the listBox the book to REMOVE");
            }

            this.listBoxLibrary.Items.Clear();

        }

        //public static void WriteXmlFile( List<Book> listOfBooks )
        //{
        //    XmlWriter xmlWriter = XmlWriter.Create(xmlFilePath);
        //    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Book>));
        //    xmlSerializer.Serialize(xmlWriter, listOfBooks);
        //    xmlWriter.Close();
        //}

        //public static List<Book> ReadXmlFile()
        //{
        //    List<Book> listFromFile = new List<Book>(); 

        //      StreamReader streamReader = new StreamReader(xmlFilePath);

        //      XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Book>));

        //    listFromFile = (List<Book>)xmlSerializer.Deserialize(streamReader);

        //    streamReader.Close();

        //    return listFromFile;     

        //}



        /***
         To Write(Serialize) date into an xml serializer file, we need to use 2 classes : 
           XmlWriter 
           XmlSerializer      
         ***/

       // public static String xmlFilePath = @"../../../data/library.xml";
        private void buttonWriteToXmlFile_Click(object sender, EventArgs e)
        {

            /****1- first way
            XmlWriter xmlWriter = XmlWriter.Create(xmlFilePath);             
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Book>));
            xmlSerializer.Serialize(xmlWriter, this.listOfBooks);
            xmlWriter.Close();  
            ***/

            /* 2- second way ***/
            // WriteXmlFile(listOfBooks);

            /* - 3- third way **/
            FileManager.WriteToXmlFile(this.listOfBooks);


        }
        /***
         To Read (Deserialize) date from an xml serializer file, we need to use 2 classes : 
           StreamReader 
           XmlSerializer      
         ***/
        private void buttonReadFromXmlFile_Click(object sender, EventArgs e)
        {

            this.listOfBooks.Clear();
            /* 1- first way 
              /////////////////List<Book> listFromFile = new List<Book>();

              this.listOfBooks.Clear();

              StreamReader streamReader = new StreamReader(xmlFilePath);

              XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Book>));

              this.listOfBooks =   (List<Book>) xmlSerializer.Deserialize(streamReader);

              streamReader.Close();
               /////////////// this.listOfBooks = listFromFile;
             ****************************************************************/


            /** 2 - second way
            this.listOfBooks = ReadXmlFile();
            ***/


            this.listOfBooks = FileManager.ReadFromXmlFile();

            foreach (Book item in this.listOfBooks)
            {
                this.listBoxLibrary.Items.Add(item.GetBookState() );
            
            }

        }
    }
}
