using Microsoft.VisualBasic.Logging;

namespace CountersFactory.user
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

            //Application.Run(new Form1());
            //Application.Run(MyMainForm); 

            LoginForm myLogin = new LoginForm(); //If we want to execute the Login we have to create it.
            Application.Run(myLogin); //This is to startup the "Login" form first.
        }
    }
}