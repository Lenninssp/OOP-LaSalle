

using System;
using System.Xml;
using System.Xml.Serialization;


using WinFormsSchoolLibraryV3.bus;

namespace WinFormsSchoolLibraryV3.user
{
    public partial class Form1 : Form
    {
        //declare and create 3 lists
        List<Item> ?                listOfItems = new List<Item>();
        List<Book> ?                listOfBooks = new List<Book>();
        List<CompactDisk> ? listOfCompactDisks  = new List<CompactDisk>();

        //declare 3 reference variables: 3 instances Or 3 objects
        Item        currentItem;
        CompactDisk currentCompactDisk;
        Book        currentBook;
        Date        currentPublishedDate;


        public Form1()
        {
            InitializeComponent();
        }


        //At the event Click of the button named buttonAdd
        //we will create a current book to add to the list of books
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //variable declarations
            int number;
            string? title;
            int currentMonth, currentDay, currentYear;

            try
            {                 
                //create an instance of the Date class
                currentPublishedDate = new Date();


        // Data input

                //item type
                EnumItemType currentItemType;
                Enum.TryParse(this.comboBoxItemType.Text,  out currentItemType);

                //language
                EnumLanguage currentLanguage;
                Enum.TryParse(this.comboBoxLanguage.Text, out currentLanguage);


               // number and title
                number = Convert.ToInt32(this.textBoxNumber.Text);
                title = this.textBoxTitle.Text;

               //published date
                currentMonth = Convert.ToInt32(this.textBoxMonth.Text);
                currentDay = Convert.ToInt32(this.textBoxDay.Text);
                currentYear = Convert.ToInt32(this.textBoxYear.Text);
                    currentPublishedDate.Month = currentMonth;
                    currentPublishedDate.Day = currentDay;
                    currentPublishedDate.Year = currentYear;

;              //pages and capcity

                if ( currentItemType == EnumItemType.Book)
                {

                    currentBook = new Book();

                    currentBook.Type = currentItemType;
                    currentBook.Number = number;
                    currentBook.Title = title;
                    currentBook.Language = currentLanguage;
                    currentBook.PublishedDate = currentPublishedDate;

                        try
                        {
                            currentBook.Pages = Convert.ToInt32(this.textBoxPages.Text);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }


                    //add the currentCompactDisk to the list of items
                    /****
                    if (this.listOfItems != null)
                    {
                        this.listOfItems.Add(currentBook);
                    
                    ***/


                    //first way
                    //if (DataCollection.ListOfItems  != null)
                    //{
                    //    DataCollection.Add(currentBook);
                    //}

                    //second way
                    if (DataCollection.GetItemList() != null)
                    {
                        DataCollection.Add(currentBook);
                    }

                }
                else if (currentItemType == EnumItemType.CompactDisk)
                 {

                    currentCompactDisk = new CompactDisk();

                    currentCompactDisk.Type = currentItemType;
                    currentCompactDisk.Number = number;
                    currentCompactDisk.Title = title;
                    currentCompactDisk.Language = currentLanguage;
                    currentCompactDisk.PublishedDate = currentPublishedDate;

                        try
                        {
                            currentCompactDisk.Capacity = Convert.ToInt32(this.textBoxCapacity.Text);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    /***
                    if (this.listOfItems != null)
                    {
                        this.listOfItems.Add(currentCompactDisk);
                    }
                    **********/

                    //first way
                    if (DataCollection.ListOfItems != null)
                    {
                        DataCollection.Add(currentCompactDisk);
                    }

                    //second way
                    //if (DataCollection.GetItemList() != null)
                    //{
                    //    DataCollection.Add(currentCompactDisk);
                    //}

                }                
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
            this.listBoxLibrary.Items.Clear();

            

            if ( DataCollection.GetItemList() != null && DataCollection.GetItemList().Count > 0 && this.listBoxLibrary.Items.Count == 0)
            {
                foreach (Item currentItem  in DataCollection.GetItemList())
                {
                    if (currentItem is Book)
                    {
                        currentBook = (Book)currentItem;

                        this.listBoxLibrary.Items.Add(  currentBook.GetBookState() );
                    }
                    else if (currentItem is CompactDisk)
                    {
                        currentCompactDisk  = (CompactDisk)currentItem;

                        this.listBoxLibrary.Items.Add(currentCompactDisk.GetCompactDiskState());
                    }
                }
            }
            else { 
                MessageBox.Show("The list of items already printed in the listBox or the list of itemss in memory is empty...."); 
            }

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {

           // this.comboBoxItemType.Text = Convert.ToString(EnumItemType.Undefined);

            this.comboBoxItemType.Text = EnumItemType.Undefined.ToString();

            this.comboBoxLanguage.Text = Convert.ToString(EnumLanguage.UNDEFINED);

            this.textBoxNumber.Text = string.Empty;
            this.textBoxTitle.Text = "";

            this.textBoxMonth.Text = string.Empty;
            this.textBoxDay.Text = string.Empty;
            this.textBoxYear.Text = string.Empty;

            this.textBoxCapacity.Text = string.Empty;
            this.textBoxPages.Text = string.Empty;

            this.textBoxCapacity.Enabled = true;
            this.textBoxPages.Enabled = true;

            this.textBoxNumber.Focus();

            this.listBoxLibrary.Items.Clear();
               
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
            Item itemToSearch = new Item();

            Book currentBook;
            CompactDisk currentCompactDisk;

            /***
            if ( this.listOfItems != null)
            {
                foreach (Item currentItem in this.listOfItems)
                {
                    if (currentItem.Number == Convert.ToInt32(this.textBoxNumber.Text))
                    {
                        found = true;
                        itemToSearch = currentItem;
                        break;
                    }
                }
            }
            ***/


            if (DataCollection.GetItemList != null)
            {
                foreach (Item currentItem in DataCollection.GetItemList() )
                {
                    if (currentItem.Number == Convert.ToInt32(this.textBoxNumber.Text))
                    {
                        found = true;
                        itemToSearch = currentItem;
                        break;
                    }
                }
            }
            if (found)
            {
                if (itemToSearch.Type == EnumItemType.Book)
                {
                    currentBook = (Book)itemToSearch; //casting

                    MessageBox.Show("Book found ..." + currentBook.GetBookState(),
                       "Event Programming with C#", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    this.listBoxLibrary.Items.Add(currentBook.GetBookState());

                }
                else if (itemToSearch.Type == EnumItemType.CompactDisk)
                {
                    currentCompactDisk = (CompactDisk)itemToSearch; //casting

                    MessageBox.Show("Book found ..." + currentCompactDisk.GetCompactDiskState() , 
                       "Event Programming with C#", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    this.listBoxLibrary.Items.Add(currentCompactDisk.GetCompactDiskState());

                }

            }
            else
            {
                MessageBox.Show("Item Not found ...",
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


            foreach (EnumItemType item in Enum.GetValues(typeof(EnumItemType)))
            {
                this.comboBoxItemType.Items.Add(item);
            }

            this.comboBoxItemType.Text = Convert.ToString(EnumLanguage.UNDEFINED);

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {

        }


        //At the SelectedIndexChanged event on the listBoxLibrary

        int currentIndex = -1;
        private void listBoxLibrary_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentIndex = this.listBoxLibrary.SelectedIndex;

            EnumItemType currentItemType;

            
            this.listOfItems = DataCollection.GetItemList();

            if (this.listOfItems  != null)
            {
                currentItemType = this.listOfItems[currentIndex].Type;

                this.comboBoxItemType.Text = Convert.ToString(currentItemType); ;

                if ( currentIndex >= 0 && currentItemType == EnumItemType.Book)
                {
                    Book currentBook = new Book();

                    currentBook = (Book)this.listOfItems[currentIndex];

                    this.textBoxNumber.Text = currentBook.Number.ToString();
                    this.textBoxTitle.Text = currentBook.Title;

                    //language
                    this.comboBoxLanguage.Text = currentBook.Language.ToString();

                    //published date
                    this.textBoxMonth.Text = currentBook.PublishedDate.Month.ToString();
                    this.textBoxDay.Text = currentBook.PublishedDate.Day.ToString();
                    this.textBoxYear.Text = currentBook.PublishedDate.Year.ToString();

                    this.textBoxPages.Text = currentBook.Pages.ToString();  

                }
                else
                if (currentIndex >= 0 && currentItemType == EnumItemType.CompactDisk)
                {
                    CompactDisk currentCompactDisk = new CompactDisk();

                    currentCompactDisk = (CompactDisk)this.listOfItems[currentIndex];

                    this.textBoxNumber.Text = currentCompactDisk.Number.ToString();
                    this.textBoxTitle.Text = currentCompactDisk.Title;

                    //language
                    this.comboBoxLanguage.Text = currentCompactDisk.Language.ToString();

                    //published date
                    this.textBoxMonth.Text = currentCompactDisk.PublishedDate.Month.ToString();
                    this.textBoxDay.Text = currentCompactDisk.PublishedDate.Day.ToString();

                    this.textBoxYear.Text = currentCompactDisk.PublishedDate.Year.ToString();

                    this.textBoxCapacity.Text = currentCompactDisk.Capacity.ToString();

                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            EnumItemType currentItemType;
            Enum.TryParse(this.comboBoxItemType.Text, out currentItemType);


           // this.listOfItems = DataCollection.ListOfItems;

            if (DataCollection.ListOfItems != null)
            {
                currentItemType = DataCollection.ListOfItems[currentIndex].Type;
            }

            if (currentIndex >= 0 && listOfItems != null)
            {
                if (currentItemType == EnumItemType.Book)
                {
                    Book currentBook = new Book();

                    currentBook.Type = currentItemType;
                    currentBook.Number = Convert.ToInt32(this.textBoxNumber.Text);
                    currentBook.Title = this.textBoxTitle.Text;

                    //EnumLanguage
                    EnumLanguage currentLanguage;
                    Enum.TryParse(this.comboBoxLanguage.Text, out currentLanguage);
                    currentBook.Language = currentLanguage;

                    //Date
                    Date currentDate = new Date();
                    currentDate.Month = Convert.ToInt32(this.textBoxMonth.Text);
                    currentDate.Day = Convert.ToInt32(this.textBoxDay.Text);
                    currentDate.Year = Convert.ToInt32(this.textBoxYear.Text);
                    currentBook.PublishedDate = currentDate;

                    currentBook.Pages = Convert.ToInt32(this.textBoxPages.Text);


                    //remove the the booksk at the current index
                    DataCollection.RemoveAt(currentIndex);


                    //Insert the updated book at the currentIndex
                    DataCollection.InsertAt(currentIndex, currentBook);

                }
                else if (currentItemType == EnumItemType.CompactDisk)
                {
                    CompactDisk currentCompactDisk = new CompactDisk();

                    currentCompactDisk.Type = currentItemType;
                    currentCompactDisk.Number = Convert.ToInt32(this.textBoxNumber.Text);
                    currentCompactDisk.Title = this.textBoxTitle.Text;

                    //language
                    EnumLanguage currentLanguage;
                    Enum.TryParse(this.comboBoxLanguage.Text, out currentLanguage);
                    currentCompactDisk.Language = currentLanguage;

                    //published date
                    Date currentDate = new Date();
                    currentDate.Month = Convert.ToInt32(this.textBoxMonth.Text);
                    currentDate.Day = Convert.ToInt32(this.textBoxDay.Text);
                    currentDate.Year = Convert.ToInt32(this.textBoxYear.Text);
                    currentCompactDisk.PublishedDate = currentDate;

                    currentCompactDisk.Capacity = Convert.ToInt32(this.textBoxCapacity.Text);

                    //remove the the compact disk at the current index
                    //this.listOfItems.RemoveAt(currentIndex);
                    //Insert the updated compact disk at the currentIndex
                    //this.listOfItems.Insert(currentIndex, currentCompactDisk);


                  //  if (DataCollection.ListOfItems != null)
                   // {
                        DataCollection.RemoveAt(currentIndex);
                        DataCollection.InsertAt(currentIndex, currentCompactDisk);
                   // }

                }
            }
            else
            {
                MessageBox.Show("Choose from the listBox the item to UPDATE");
            }

            this.listBoxLibrary.Items.Clear();


        }

        private void buttondELETE_Click(object sender, EventArgs e)
        {
            if (currentIndex >= 0  && this.listOfItems != null)
            {
                ///////////// this.listOfItems.RemoveAt(currentIndex);

                DataCollection.ListOfItems.RemoveAt(currentIndex);
            }
            else
            {
                MessageBox.Show("Choose from the listBox the item to REMOVE");
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
            if (DataCollection.ListOfItems != null)
            {
                FileManager.WriteToXmlFile(DataCollection.ListOfItems);
            }


        }
        /***
         To Read (Deserialize) date from an xml serializer file, we need to use 2 classes : 
           StreamReader 
           XmlSerializer      
         ***/
        private void buttonReadFromXmlFile_Click(object sender, EventArgs e)
        {

            this.listOfItems.Clear();
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

            /***
                        this.listOfItems = FileManager.ReadFromXmlFile();

                        if ((this.listOfItems = FileManager.ReadFromXmlFile()) != null)
                        {
                            foreach (Item currentItem in this.listOfItems)
                            {
                                if (currentItem is Book)
                                {
                                    currentBook = (Book)currentItem;

                                    this.listBoxLibrary.Items.Add(currentBook.GetBookState());

                                }

                                else if (currentItem is CompactDisk)
                                {
                                    currentCompactDisk = (CompactDisk)currentItem;

                                    this.listBoxLibrary.Items.Add(currentCompactDisk.GetCompactDiskState());

                                }
                            }

                        }

                        ***/

           DataCollection.ListOfItems = FileManager.ReadFromXmlFile();

            if (( DataCollection.ListOfItems  = FileManager.ReadFromXmlFile()) != null)
            {
                foreach (Item currentItem in DataCollection.ListOfItems)
                {
                    if (currentItem is Book)
                    {
                        currentBook = (Book)currentItem;

                        this.listBoxLibrary.Items.Add(currentBook.GetBookState());

                    }

                    else if (currentItem is CompactDisk)
                    {
                        currentCompactDisk = (CompactDisk)currentItem;

                        this.listBoxLibrary.Items.Add(currentCompactDisk.GetCompactDiskState());

                    }
                }

            }
        }

       private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            EnumItemType currentItemType;

            Enum.TryParse(this.comboBoxItemType.Text, out currentItemType);

            if ( currentItemType == EnumItemType.Book)
            {
                this.textBoxPages.Enabled = true;
                this.textBoxCapacity.Enabled = false;
            }


            else if (currentItemType == EnumItemType.CompactDisk)
            {
                this.textBoxPages.Enabled = false;
                this.textBoxCapacity.Enabled = true;
            }


        }







        private void labelNumber_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
