using System;

/************** Jan 25 - CT2 -  Gr92 ****************/

namespace LibraryProject_V5
{
    //Definition of the struct Book
    struct Book
    {
        //-1- Data member: fields-attributes
        private int bookNumber;
        private String bookTitle;
        private string isbn; //international standard book number (barcode)

        // -2- Operations Member
        //an operation is a: service, function, method

        //-2- Constructor with 2 paramers
        public Book(int bookNumber, string bookTitle) //bookNumber and bookTitle are the FORMAL Parameters
        {
            this.bookNumber = bookNumber;
            this.bookTitle = bookTitle;

            this.isbn = "Undefined";
        }

        //-3- Constructor with 3 paramers
        public Book(int bookNumber, string bookTitle, string isbn) //bookNumber and bookTitle are the FORMAL Parameters
        {
            this.bookNumber = bookNumber;
            this.bookTitle = bookTitle;
            this.isbn = isbn;
        }
        // Setters and Getters for each private attribute
        public int GetBookNumber()
        {
            return this.bookNumber;
        }
        public void SetBookNumber(int bookNumber)
        {
            this.bookNumber = bookNumber;
        }
        public string GetBookTitle()
        {
            return this.bookTitle;
        }
        public void SetBookTitle(string bookTitle)
        {
            this.bookTitle = bookTitle;
        }
        public string GetIsbn()
        { return this.isbn; }
        public void SetIsbn(string isbn)
        {
            this.isbn = isbn;
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
              int max ;
              Book[] bookLibrary;            

            Console.Write("How many books ? : ");
            max = Convert.ToInt32(Console.ReadLine());

            //intialize the dynamic array of  - a Dynamic array is created during run-time
            bookLibrary = new Book[max];

            //input data
            Console.WriteLine("******* INPUT Books ***************");
            for (int index = 0; index < max; index++)
            {
                Book currentBook = new Book();

                Console.Write("Book number ? : ");               
                currentBook.SetBookNumber(Convert.ToInt32(Console.ReadLine()));

                Console.Write("Book title ? : ");               
                currentBook.SetBookTitle(Console.ReadLine());

                Console.Write("Book isbn ? : ");                
                currentBook.SetIsbn(Console.ReadLine());

                bookLibrary[index] = currentBook;
            }

            //input data
            Console.WriteLine("******* PRINT Books state ***************");
            for (int index = 0; index < max; index++)
            {
                Console.WriteLine(bookLibrary[index].GetBookState());
            }

            Console.WriteLine("\n \t\t Application written by Houria Houmel (Version 05)");
            Console.ReadKey(); // pause
        }
    }
}

/*
 ****** Console output - execution test ********************************
 *
How many books ? : 3
******* INPUT Books ***************
Book number ? : 1
Book title ? : C
Book isbn ? : 111-111
Book number ? : 2
Book title ? : C++
Book isbn ? : 222-222
Book number ? : 3
Book title ? : C#
Book isbn ? : 333-333
******* PRINT Books state ***************
1 | C | 111-111
2 | C++ | 222-222
3 | C# | 333-333

                 Application written by Houria Houmel (Version 05)

 * 
 * 
 * 
 * 
 * */