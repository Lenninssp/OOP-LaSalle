using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsLibrary_V2.bus
{
    public class Book : Object
    {
        private int number;
        private string? title;

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

        public Book()
        {
            this.number = 0;
            this.title = "Undefined";
        }

        public Book(int number, string title)
        {
            this.number = number; 
            this.title = title;
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
