using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsLibrary_V2.bus
{
    public class Book : Object
    {
        //Fields
        private int number;
        private string? title;       
        private EnumLanguage language;
        private Date publishedDate;

        //Properties
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
        public EnumLanguage Language
        {
            get { return this.language; }
            set { this.language = value; }

        }
       
        public Date PublishedDate
        {
            get { return this.publishedDate; }
            set { this.publishedDate = value; }
        
        }

        //Methods
        public Book()
        {
            this.number = 0;
            this.title = "Undefined";
            this.language = EnumLanguage.UNDEFINED;
            this.publishedDate = new Date();
        }

        public Book(int number, string title)
        {
            this.number = number; 
            this.title = title;
            this.language = EnumLanguage.UNDEFINED;
            this.publishedDate = new Date();
        }
        public Book(int number, string title, EnumLanguage language)
        {
            this.number = number;
            this.title = title;
            this.language = language;
            this.publishedDate = new Date();
        }
        public Book(int number, string title, EnumLanguage language, Date publishedDate)
        {
            this.number = number;
            this.title = title;
            this.language = language;
            this.publishedDate = publishedDate;
        }

        public string GetBookState()
        {
            string state;
            state =  this.number + " | " + this.title  
                    + " | " + this.language  + " | " + this.publishedDate;
            return state;

        }

        public override string ToString()
        {
            string state;
            state =  this.number + " | " + this.title
                      + " | " + this.language + " | " + this.publishedDate.GetDateState();
            return state;

        }



    }

}
