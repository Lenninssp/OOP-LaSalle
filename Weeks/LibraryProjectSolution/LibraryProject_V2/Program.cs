namespace LibraryProject_V2
{
    //Definition of the struct Book
    struct Book
    {
        //Member of data : attributes
        private int bookNumber;
        private String bookTitle;
       

        // Member of operations
        // //an operation is a service, function, method

        //the public default constructor ( constructor without paramters- parameterless constructor)
        public Book()
        {
            this.bookNumber = 0;
            this.bookTitle = "Undefined ";
        }

        //constructor with parameters
        public Book(int bookNumber, string bookTitle) //bookNumber and bookTitle are the FORMAL Parameters
        {
            this.bookNumber = bookNumber;
            this.bookTitle = bookTitle;
        }

        //the public Setters and Getters
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
        public string GetBookState()
        {
            string state;
            state = this.bookNumber + " | " + this.bookTitle;

            return state; 
        }
    };

    internal class Program
    {
        //Main process( function or method)
        //Main is thge entry point of the application
        static void Main(string[] args)
        {
            //Declaration:
            Book book1, book2, book3;

            book1 = new Book();
            book2 = new Book();

            book3 = new Book(3, " UML Design Patterns");

            //Assigning values to book1
            book1.SetBookNumber (1) ;

            book1.SetBookTitle( "C# How To Program" ) ;

            //Assigning values to book2() 
            book2.SetBookNumber(2);
            book2.SetBookTitle ("JAVA How To Program" );

            Console.WriteLine("**************** Version 02 **************");

            Console.WriteLine("Book1 : " + book1.GetBookState() );
            Console.WriteLine("********************************************************");
            Console.WriteLine("Book2 : " + book2.GetBookState());
            Console.WriteLine("********************************************************");

            Console.WriteLine("Book3 : " + book3.GetBookState());
            Console.WriteLine("********************************************************");

            Console.WriteLine("\n \t\t Application written by Houria Houmel (Version 02)");
            Console.ReadKey(); // pause
        }
    }



}