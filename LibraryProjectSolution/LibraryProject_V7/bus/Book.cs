namespace LibraryProject_V7
{
    public struct Book
    {
        private string title;
        private string author;
        private int year;

        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
            this.year = 0000;
        }

        public Book(string title, string author, int year)
        {
            this.title = title;
            this.author = author;
            this.year = year;
        }

        public string Title
        {
            set { this.title = value; }
            get { return this.title; }
        }

        public string Author
        {
            set { this.author = value; }
            get { return this.author; }
        }

        public int Year
        {
            set { this.year = value; }
            get { return this.year; }
        }

        public void Print()
        {
            Console.WriteLine($"Title: {this.title}, Author: {this.author}, Year: {this.year}");
        }
    }
}
