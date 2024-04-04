using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsSchoolLibraryV3.bus
{
    internal class Book 
    {
        //Data member: (private fields)
        private int number;
        private string ? title;

        //public properties
        public int Number
        { 
            get { return number; }
            set { this.number = value; }
        }

        public string Title
        {
            get { return this.title; }
            set { this.title = value; }

        }

        //Functions Member
        public Book()
        { 
            this.number = 0;
            this.title = "Undefined";
        }

        public Book(int number, string title)
        {
            this.number = number ;
            this.title = title ;
        }

        public string GetBookState()
        {
            string state;

            state = this.number + " | " + this.title;

            return state;
        
        }




    }
}
