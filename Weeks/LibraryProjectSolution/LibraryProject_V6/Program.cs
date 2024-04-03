using System;

namespace Week4
{
    struct Books
    {
        private string title;
        private string author;
        private int year;

        public Books(string title, string author)
        {
            this.title = title;
            this.author = author;
            this.year = 0000;
        }
        public Books(string title, string author, int year)
        {
            this.title = title;
            this.author = author;
            this.year = year;
        }

        public string Title
        {
            set { this.title = value; }
            get { return this.title; }
        }

        public string Author
        {
            set { this.author = value; }
            get { return this.author; }
        }

        public int Year
        {
            set { this.year = value; }
            get { return this.year; }
        }

        public void Print()
        {
            Console.WriteLine($"Title: {this.title}, Author: {this.author}, Year: {this.year}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Books[] booksArray = new Books[3];

            for (int i = 0; i < booksArray.Length; i++)
            {
                do {
                    Console.WriteLine("Enter book title:");
                    booksArray[i].Title = Console.ReadLine();
                }while(booksArray[i].Title == null || (booksArray[i].Title).Equals(""));
                
                do{
                    Console.WriteLine("Enter book author:");
                    booksArray[i].Author = Console.ReadLine();
                }while(booksArray[i].Author == null || (booksArray[i].Author).Equals(""));

                do {
                     Console.WriteLine("Enter publication year:");
                    int year;
                    if (int.TryParse(Console.ReadLine(), out year))
                    {
                        booksArray[i].Year = year;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for year. Setting to 0000.");
                    }
                }while(booksArray[i].Title == null || (booksArray[i].Title).Equals(""));
            }

            for (int i = 0; i < booksArray.Length; i++)
            {
                booksArray[i].Print();
            }

            Console.WriteLine("Program by Lennin Sabogal 2024");
        }
    }
}
