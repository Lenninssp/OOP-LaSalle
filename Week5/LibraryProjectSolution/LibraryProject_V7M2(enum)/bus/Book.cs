using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*****
 *  Fundamental Concpts of OOP (Pillars of OOP)
 *  
 *  
 *  ENCAPSULATION: true for struct and class data types.
 *     
 *  INHERITANCE: true for the class data type
 *
 *
 *
 * ***/



namespace LibraryProject_V7M2_enum_.bus
{
    public class Book : Object
    {
        /****Data member**/
        private int number;
        private string title;

        private EnumLanguage language;

        /********   Functions Member ( public)  ********************/
        // -1- public Get/Set for the private field number ( Java syntax)
        public int GetNumber()
        { 
            return this.number; 
        }
        public void SetNumber(int number)
        {
            this.number = number;
        }
        public string GetTitle()
        {
            return this.title;
        }
        public void SetTitle(string title)
        {
            this.title = title;
        }
        public EnumLanguage GetLanguage()
        {
            return this.language;
        }
        public void SetLanguage(EnumLanguage language)
        {
            this.language = language;
        }

        // -2- public PROPERTY Number : VB .Net syntax
        public int Number
        {
            get { return this.number; }
            set { this.number = value; }    
        }
        // public PROPERTY Title : VB .Net syntax
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
        // public PROPERTY Languager : VB .Net syntax
        public EnumLanguage Language
        {
            get { return this.language; }
            set { this.language = value; }
        }
        
       
        
        /* Implementing the OVERLOADED Constructors**/
        //Constructor with 0 parameters
        public Book()
        {
            this.number = 0;
            this.title = "Undefined";
            this.language = EnumLanguage.Undefined;
        }
        //Constructor with 3 parameters
        public Book(int number, string title, string language)
        {
            this.number = number;
            this.title = title;
            this.language = EnumLanguage.Undefined;
        }

        public string GetBookState()
        {
            string state;
            state = this.number + " | " + this.title + " | " + this.language;
            return state;
        }    
    }
}
