
using LibraryProject_V7.bus;

/***********************  Wednesday, Jan 31, 2024 - CT2 Gr92 ******************/

namespace LibraryProject_V7.user
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration:
            int max;
            Book[] bookLibrary;

            Console.Write("How many books ? : ");
            max = Convert.ToInt32(Console.ReadLine());

            //intialize the dynamic array of  - a Dynamic array is created during run-time
            bookLibrary = new Book[max];

            string? input;

            //input data
            Console.WriteLine("******* INPUT Books ***************");
            for (int index = 0; index < max; index++)
            {
                Book currentBook = new Book(); //Book() is the function (defaut constructor)

                //-1 validate the book number (avoiding a null value -empty string
                do
                {
                    Console.Write("Book number ? : ");
                    input = Console.ReadLine();
                } while (input == null || input.Equals(""));

                currentBook.SetBookNumber(Convert.ToInt32(input));


                //-2- validate the title
                do
                {
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

            int key; bool found = false;

            Book record = new Book();

            Console.Write(" Book number to search ? : ");
            key = Convert.ToInt32(Console.ReadLine());

            for (int index = 0; index < bookLibrary.Length; index++)
            {//begin for loop  

                if (bookLibrary[index].GetBookNumber() == key)
                {//begin if
                    found = true;
                    record = bookLibrary[index];
                    break;
                }//end if

            } //end for loop

            if (found)
            {
                Console.WriteLine("\t Book found \n " + record.GetBookState());
                
            }
            else
            {
                Console.WriteLine("Book not found");
            }

            Console.WriteLine("\n \t\t Application written by Houria Houmel (Version 07)-class data type");
            Console.ReadKey(); // pause
        }

      }
    }
