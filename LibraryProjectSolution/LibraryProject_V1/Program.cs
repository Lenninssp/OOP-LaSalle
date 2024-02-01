using System;

namespace LibraryProject_V1
{
   //Definition of the struct Book
   struct Book
    {    
        public int bookNumber;
        public String bookTitle;
    };  
      
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration:
            Book book1, book2;

            book1.bookNumber = 1;
            book1.bookTitle = "C# How To Program";
            book2.bookNumber = 2;
            book2.bookTitle = "JAVA How To Program";

            Console.WriteLine("**************** Version 01 **************");

            Console.WriteLine( "Book1 : " + book1.bookNumber + " | " + book1.bookTitle);
            Console.WriteLine("********************************************************");
            Console.WriteLine("Book2 : " + book2.bookNumber + " | " + book2.bookTitle);

            Console.WriteLine("\n \t\t Application written by Houria Houmel (Version 01)");
            Console.ReadKey(); // pause
        }
    }
}