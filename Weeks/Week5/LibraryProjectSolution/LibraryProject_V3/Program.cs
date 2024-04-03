namespace LibraryProject_V3
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

        //Functions OVERLOADING 
        //-1-Default constructor ( constructor without parameters- parameterless constructor)
        public Book()
        {
            this.bookNumber = 0;
            this.bookTitle = "Undefined ";
            this.isbn = "Undefined";
        }

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
        { return this.isbn;}
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
            Book book1, book2;//book1 and book2 are the 2 objects
            Book book3, book4;
            
            book1 = new Book(); //book1 is an instance of the struct Book
            book2 = new Book();  //book2 is an instance of the struct Book
            book3 = new Book();
            book4 = new Book(4, "Python", "444-444-444");

            //Assigning values to book1
            book1.SetBookNumber(1);
            book1.SetBookTitle("C# How To Program");
            book1.SetIsbn("111-111-111");

            //Assigning values to book2
            book2.SetBookNumber(2);
            book2.SetBookTitle("JAVA How To Program");
            book2.SetIsbn("222-222-222");
            //Assigning values to book3
            book3.SetBookNumber(3);
            book3.SetBookTitle("ASP Dot Net");
            book3.SetIsbn("333-333-333");

            Console.WriteLine("**************** Version 03 **************");

            //Console.WriteLine("Book1 : " + book1.GetBookNumber() + " | " + book1.GetBookTitle() + " | " + book1.GetIsbn()  ) ;
            //Console.WriteLine("********************************************************");
            //Console.WriteLine("Book2 : " + book2.GetBookNumber() + " | " + book2.GetBookTitle() + " | " + book2.GetIsbn());

            Console.WriteLine("Book1 : " + book1.GetBookState());
            Console.WriteLine("********************************************************");
            Console.WriteLine("Book2 : " + book2.GetBookState());
            Console.WriteLine("********************************************************");

            Console.WriteLine("Book3 : " + book3.GetBookState());
            Console.WriteLine("********************************************************");

            Console.WriteLine("Book4 : " + book4.GetBookState());
            Console.WriteLine("********************************************************");

            Console.WriteLine("\n \t\t Application written by Houria Houmel (Version 03)");
            Console.ReadKey(); // pause
        }
    }


}