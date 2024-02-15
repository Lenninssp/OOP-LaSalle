namespace ContactListProject
{
    public class Contact
    {
        private int number;
        private string firstname;
        private string lastname;
        private string email;

        public Contact(int number, string firstname, string lastname, string email)
        {
            this.number = number;
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
        }

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string GetState()
        {
            return $"Number: {number}, First Name: {firstname}, Last Name: {lastname}, Email: {email}";
        }
    }
}
