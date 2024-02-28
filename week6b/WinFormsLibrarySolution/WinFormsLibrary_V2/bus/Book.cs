using System;

namespace WinFormsLibrary_V2.bus
{
    public class Book : Object
    {
        private int number;
        private string? title;
        private string isbn;
        private int pages;

        public int Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }

        public string Isbn
        {
            get { return this.isbn; }
            set { this.isbn = value; }
        }

        public int Pages
        {
            get { return this.pages; }
            set { this.pages = value; }
        }

        public Book()
        {
            this.number = 0;
            this.title = "Undefined";
            this.isbn = "Unknown";
            this.pages = 0;
        }

        public Book(int number, string title, string isbn, int pages)
        {
            this.number = number;
            this.title = title;
            this.isbn = isbn;
            this.pages = pages;
        }

        public string GetBookState()
        {
            string state;
            state = this.number + " | " + this.title;
            return state;

        }

        public override string ToString()
        {
            string state;
            state = this.number + " | " + this.title;
            return state;

        }
    }
}
