
using LibraryProject_V7M2_enum_.bus;

//CT2 Gr92 - Feb, 01

namespace LibraryProject_V7M2_enum_.user
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Book book1, book2, book3;
            string ?input;

            EnumLanguage language;

            book1 = new Book();

            Console.WriteLine("Input book number");
            input = Console.ReadLine();
            book1.SetNumber(Convert.ToInt32(input));


          
            Console.WriteLine("Input book title");
            input = Console.ReadLine();
            book1.SetTitle(input);

            /**************************/
            /* first way ***/
            Console.WriteLine("Input book language");
            input = Console.ReadLine();
            /* How to convert a string data type to a the type of EnumLanguage */
            //Enum.TryParse<EnumLanguage>(input, out language);
            //book1.SetLanguage(language);

            /* second  way ***/
            int option;
            Console.WriteLine("book language ? : [type 1-for English , 2-for French, 3- Spanish");
            Console.Write("Choose your option: ");
            option = Convert.ToInt32(Console.ReadLine()); 
            switch(option)
            {
                case 1:
                    book1.SetLanguage(EnumLanguage.English);
                    break;
                case 2:
                    book1.SetLanguage(EnumLanguage.French);
                    break;
                case 3:
                    book1.SetLanguage(EnumLanguage.Spanish);
                    break;

            }

            book2 = new Book();
            book2.Number = 2;
            book2.Title = "UML Design Patterns";
            book2.Language = EnumLanguage.French;

            book3 = new Book(3, " Advanced Object Oriented Programming", "English");

            Console.WriteLine("\n book1 - after using the setters");
            Console.WriteLine(book1.GetBookState());

            Console.WriteLine("\n book2 - Get the book2 using the properties");
            Console.WriteLine(book2.Number + " | " + book2.Title + " | " + book2.Language);

            Console.WriteLine("\n book3 - Get the book3 using the properties");
            Console.WriteLine(book3.Number + " | " + book3.Title + " | " + book3.Language);

            Console.WriteLine("\n \t Application written by Houria Houmel");
            Console.ReadKey();                   

        }
    }
}

/**** Execution test ***************************
 
 book1 - after using the setters
1 | C# How To Program | English

 book2 - Get the book2 using the properties
2 | UML Design Diagram | French

 * */