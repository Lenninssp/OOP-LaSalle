using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject_V4
{
    //Definition of the struct Book
    struct Book
    {
        //-1- Data member: fields-attributes
        private int bookNumber;
        private String bookTitle;
        private string isbn; //international standard book number (barcode)
        private int pages;


        // -2- Operations Member
        //an operation is a: service, function, method

        //Functions OVERLOADING 
        //-1-Default constructor ( constructor without parameters- parameterless constructor)
        ////public Book()
        ////{
        ////    this.bookNumber = 0;
        ////    this.bookTitle = "Undefined ";
        ////    this.isbn = "Undefined";
        ////}

        //-1- Constructor with 2 paramers
        public Book(int bookNumber, string bookTitle) //bookNumber and bookTitle are the FORMAL Parameters
        {
            this.bookNumber = bookNumber;
            this.bookTitle = bookTitle;

            this.isbn = "UNKNOWN";
            this.pages = 0;
        }

        //-2- Constructor with 3 paramers
        public Book(int bookNumber, string bookTitle, string isbn) //bookNumber and bookTitle are the FORMAL Parameters
        {
            this.bookNumber = bookNumber;
            this.bookTitle = bookTitle;
            this.isbn = isbn;
            this.pages = 0;
        }
        //-3- Constructor with 4 paramers
        public Book(int bookNumber, string bookTitle, string isbn, int pages) //bookNumber and bookTitle are the FORMAL Parameters
        {
            this.bookNumber = bookNumber;
            this.bookTitle = bookTitle;
            this.isbn = isbn;
            this.pages = pages;
        }

        //-first way:
        // Setters and Getters for the private attribute bookNumber (java syntax)
                        public int GetBookNumber()
                        {
                            return this.bookNumber;
                        }
                        public void SetBookNumber(int bookNumber)
                        {
                            this.bookNumber = bookNumber;
                        }

        //- second way
        //Property BookNumber for the private attribute booknumber: (VB Dot Net syntax)
        public int BookNumber
        {
            set { this.bookNumber = value; }

            get { return this.bookNumber; }
        }
        public string GetBookTitle()
        {
            return this.bookTitle;
        }
        public void SetBookTitle(string bookTitle)
        {
            this.bookTitle = bookTitle;
        }
        
        /*******
         * the 2 public functions get() and set() are the java syntax
         */
        public string GetIsbn()
        { return this.isbn; }
        public void SetIsbn(string isbn)
        {
            this.isbn = isbn;
        }   

        //Isbn is the property get/set
        public String Isbn
        {
            set { this.isbn = value; }

            get { return this.isbn; }


        }

        public string GetBookState()
        {
            string state;

            state = this.bookNumber + " | " + this.bookTitle + " | " + this.isbn;

            return state;
        }
    };

    internal class Program
    {
        //Main process( function or method)
        //Main is the entry point of the application
        static void Main(string[] args)
        {
            //Declaration:
            const int MAX_SIZE = 3 ;
            Book[] bookLibrary;
            string input;

            //intialize a static array of books - A static array is created during compile-time
            bookLibrary = new Book[MAX_SIZE];

            //input data
            Console.WriteLine("******* INPUT Books ***************");
            for(int index = 0; index < MAX_SIZE; index++)
            {
                Book currentBook = new Book();

                Console.Write("Book number ? : ");
                input = Console.ReadLine();
                                                   // currentBook.SetBookNumber(Convert.ToInt32(input));
                currentBook.BookNumber = Convert.ToInt32(input);

                Console.Write("Book title ? : ");
                input = Console.ReadLine();
                currentBook.SetBookTitle(input);

                Console.Write("Book isbn ? : ");
                input = Console.ReadLine();
                                   //currentBook.SetIsbn(input);
                currentBook.Isbn = input;

                bookLibrary[index] = currentBook;
            }

            //input data
            Console.WriteLine("******* PRINT Books state ***************");
            for (int index = 0; index < MAX_SIZE; index++)
            {
                Console.WriteLine("Book number : " + bookLibrary[index].BookNumber);
                Console.WriteLine(bookLibrary[index].GetBookState() ) ;                
            }

            Console.WriteLine("\n \t\t Application written by Houria Houmel (Version 04)");
            Console.ReadKey(); // pause
        }
    }
}
