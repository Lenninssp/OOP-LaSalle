using System;


namespace ContactListProject.user
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact[] contacts = new Contact[1]; 

            contacts[0] = new Contact(1021662543, "Lennin", "Sabogal", "lenninssp1021@gmail.com");


            foreach (var contact in contacts)
            {
                Console.WriteLine(contact.GetState());
            }
        }
    }
}
