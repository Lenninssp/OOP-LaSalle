using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///////////CT2- Gr90 - Friday March 08 ///////////////
namespace WinFormsSchoolLibraryV3.bus
{
    [Serializable]
    public  class Book 
    {
        //Data member: (private fields)
        //Fields
        private int number;
        private string ? title;
        private EnumLanguage language;
        private Date publishedDate;


        //TO DO
        /************
         * Add the isbn  and the pages in the class Book
         then refine the class Book
        *********************/


        // Properties
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
        // Methods (functions) Member
        public Book()
        { 
            this.number = 0;
            this.title = "Undefined";
            this.language = EnumLanguage.UNDEFINED;
        }
        public Book(int number, string title)
        {
            this.number = number ;
            this.title = title ;
            this.language = EnumLanguage.UNDEFINED;
        }
        public Book(int number, string title, EnumLanguage language)
        {
            this.number = number;
            this.title = title;

            this.language = language;

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

            state = this.number + " | " + this.title  + "  |  " + this.language
                + " | " + this.publishedDate.GetDateState();

            return state;
        
        }

    }
}
