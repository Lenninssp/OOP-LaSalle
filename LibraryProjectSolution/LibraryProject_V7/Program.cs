
namespace LibraryProject_V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] booksArray = new Book[3];
            Date date = new Date();

            date.Day = 1;
            date.Month = 10;
            date.Year = 2000;

            Console.WriteLine(date.GetValues());

            for (int i = 0; i < booksArray.Length; i++)
            {
                do
                {
                    Console.WriteLine("Enter book title:");
                    booksArray[i].Title = Console.ReadLine();
                } while (string.IsNullOrEmpty(booksArray[i].Title));

                do
                {
                    Console.WriteLine("Enter book author:");
                    booksArray[i].Author = Console.ReadLine();
                } while (string.IsNullOrEmpty(booksArray[i].Author));

                do
                {
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
                } while (booksArray[i].Title == null || booksArray[i].Title.Equals(""));
            }

            for (int i = 0; i < booksArray.Length; i++)
            {
                booksArray[i].Print();
            }

            Console.WriteLine("Program by Lennin Sabogal 2024");
        }
    }
}
