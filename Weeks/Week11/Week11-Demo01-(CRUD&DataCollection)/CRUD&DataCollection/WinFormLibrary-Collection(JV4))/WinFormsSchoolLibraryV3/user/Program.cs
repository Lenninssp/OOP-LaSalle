

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


           //1- first way:
                 // Application.Run(new Form1());

            //2- second way
                //Form1 myMainForm = new Form1();
                //Application.Run(myMainForm) ;

            Application.Run(  new LoginForm() );  

        }
    }
}