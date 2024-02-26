using System;
using LibraryProject_V7M2_enum_.bus;

namespace LibraryProject_V7M2_enum_.user
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the maximum number of books:");
            int max = Convert.ToInt32(Console.ReadLine());
            Book[] bookLibrary = new Book[max];

            for (int i = 0; i < max; i++)
            {
                Console.WriteLine($"Enter details for book {i + 1}:");
                Console.Write("number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.Write("tille: ");
                string title = Console.ReadLine();
                Console.Write("langqage: ");
                string language = Console.ReadLine();

                bookLibrary[i] = new Book(number, title, language);
            }

            Console.WriteLine("\nList of books:");
            foreach (Book book in bookLibrary)
            {
                Console.WriteLine(book.GetBookState());
            }

        }
    }
}
//program made by lennin sabogal inpired by Houria Houmel

/**

test

3
101
a
English
102
v
English
103
c
Spanish

**/