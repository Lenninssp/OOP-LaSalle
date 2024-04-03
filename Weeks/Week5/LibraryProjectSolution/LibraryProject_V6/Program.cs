namespace LibraryProject_V6
{

    //Definition of the struct Book
    struct Book  //////////////////////////////////////////// : Object

    {//begin of struct Book

        //-1- Data member: fields-attributes
        private int bookNumber;
        private String bookTitle;
        private string isbn; //international standard book number (barcode)

        // -2- Operations Member
        //an operation is a: service, function, method


        //-1- constructor with 0 parameters
        //public Book()
        //{
        //    this.bookNumber = 0;
        //    this.bookTitle = "Undefined";
        //    this.isbn = "Undefined";          
        //}
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

    };//end struct Book

    internal class Program
    {
        //Main process( function or method)
        //Main is the entry point of the application
        static void Main(string[] args)
        {
            //Declaration:
            int max;
            Book[] bookLibrary;

            Console.Write("How many books ? : ");
            max = Convert.ToInt32(Console.ReadLine());

            //intialize the dynamic array of  - a Dynamic array is created during run-time
            bookLibrary = new Book[max];

            string  ? input;

            //input data
            Console.WriteLine("******* INPUT Books ***************");
            for (int index = 0; index < max; index++)
            {
                Book currentBook = new Book(); //Book(0 is the function (defaut constructor)

                //-1 validate the book number (avoiding a null value -empty string
                do {
                    Console.Write("Book number ? : ");
                    input = Console.ReadLine();
                } while (input == null || input.Equals(""));

                     currentBook.SetBookNumber(Convert.ToInt32(input));


                //-2- validate the title
                do { 
                Console.Write("Book title ? : ");
                input = Console.ReadLine();
                } while (input == null || input.Equals(""));

                        currentBook.SetBookTitle(input);

                do
                {
                    Console.Write("Book isbn ? : ");
                    input = Console.ReadLine();
                } while (input == null || input.Equals(""));

                     currentBook.SetIsbn(input);

                bookLibrary[index] = currentBook;

            }

            //input data
            Console.WriteLine("******* PRINT Books state ***************");
            for (int index = 0; index < max; index++)
            {
                Console.WriteLine(bookLibrary[index].GetBookState());
            }

            Console.WriteLine("\n \t\t Application written by Houria Houmel (Version 06) - struct data type");
            Console.ReadKey(); // pause
        }
    }





}