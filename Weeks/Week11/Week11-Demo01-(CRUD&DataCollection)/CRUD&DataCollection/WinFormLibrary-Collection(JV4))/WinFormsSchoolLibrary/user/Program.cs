

namespace WinFormsSchoolLibraryV3.user
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //-1- first way:
            ///////////////////
            // Application.Run(new Form1());


            //-2- second way:
            ///////////////////
            //declare a reference variable of the type Form1
            //myForm is an instance of the class Form1
            Form1 myForm;


            //initialize and create  myForm
            myForm = new Form1();

            Application.Run(myForm);

        }
    }
}