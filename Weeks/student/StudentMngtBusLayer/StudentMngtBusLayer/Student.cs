namespace StudentMngtBusLayer
{
    public class Student
    {
        private int number;
        private string firstName;
        private string lastName;

        /*
         add email and grades
         */

        public Student()
        {
            this.number = 0;
            this.firstName = string.Empty;
            this.lastName = string.Empty;
        }
        public Student(int number, string firstName, string lastName)
        {
            this.number = number;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public int Number
        {
            get { return this.number; }
            set { this.number = value; }
        }
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public string GetState()
        {
            return $"{this.number}, {this.firstName}, {this.lastName}";
        }

    }
}