using System;

namespace LibraryProject_V3
{
    struct Book
    {
        private int bookNumber;
        private string bookTitle;
        private string author;
        private int publicationYear;
        private bool isAvailable;

        public Book(int number, string title, string author, int year, bool available)
        {
            this.bookNumber = number;
            this.bookTitle = title;
            this.author = author;
            this.publicationYear = year;
            this.isAvailable = available;
        }

        public Book()
        {
            this.bookNumber = 0;
            this.bookTitle = "Undefined";
            this.author = "Undefined";
            this.publicationYear = 0;
            this.isAvailable = false;
        }

        public int GetBookNumber()
        {
            return bookNumber;
        }
        public void SetBookNumber(int bookNumber)
        {
            this.bookNumber = bookNumber;
        }

        public string GetBookTitle()
        {
            return bookTitle;
        }
        public void SetBookTitle(string bookTitle)
        {
            this.bookTitle = bookTitle;
        }

        public string GetAuthor()
        {
            return author;
        }
        public void SetAuthor(string author)
        {
            this.author = author;
        }

        public int GetPublicationYear()
        {
            return publicationYear;
        }
        public void SetPublicationYear(int publicationYear)
        {
            this.publicationYear = publicationYear;
        }

        public bool IsAvailable()
        {
            return isAvailable;
        }
        public void SetAvailability(bool isAvailable)
        {
            this.isAvailable = isAvailable;
        }

        public string GetBookState()
        {
            return $"{bookNumber} | {bookTitle} | {author} | {publicationYear} | Available: {isAvailable}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1, book2, book3, book4;

            book1 = new Book(1, "C# How To Program", "Author1", 2022, true);
            book2 = new Book(2, "JAVA How To Program", "Author2", 2021, false);

            book3 = new Book();
            book3.SetBookNumber(3);
            book3.SetBookTitle("Python Programming");
            book3.SetAuthor("Author3");
            book3.SetPublicationYear(2023);
            book3.SetAvailability(true);

            book4 = new Book(4, "C++ How To Program", "Author4", 2020, false);

            Console.WriteLine("**************** Version 03 **************");

            Console.WriteLine("Book1 : " + book1.GetBookState());
            Console.WriteLine("********************************************************");
            Console.WriteLine("Book2 : " + book2.GetBookState());
            Console.WriteLine("********************************************************");
            Console.WriteLine("Book3 : " + book3.GetBookState());
            Console.WriteLine("********************************************************");
            Console.WriteLine("Book4 : " + book4.GetBookState());
            Console.WriteLine("********************************************************");

            Console.WriteLine("\n \t\t Application written by Houria Houmel modified by Lennin Sabogal (Version 03)");
            Console.ReadKey();
        }
    }
}
