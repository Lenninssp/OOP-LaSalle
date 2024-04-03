using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject_V7.bus
{
    // : is the inheritance means that
    internal class Book : Object
    {
        //-1- Data member: fields-attributes
        private int bookNumber;
        private String bookTitle;
        private string isbn; //international standard book number (barcode)

        private Date publishedDate;

        // -2- Operations Member
        //an operation is a: service, function, method


        //-1- constructor with 0 parameters
        public Book()
        {
            this.bookNumber = 0;
            this.bookTitle = "Undefined";
            this.isbn = "Undefined";

            this.publishedDate = new Date();
        }


    //-2- Constructor with 2 paramers
        public Book(int bookNumber, string bookTitle) //bookNumber and bookTitle are the FORMAL Parameters
        {
            this.bookNumber = bookNumber;
            this.bookTitle = bookTitle;
            this.isbn = "Undefined";
            this.publishedDate = new Date();
        }

        //-3- Constructor with 3 paramers
        public Book(int bookNumber, string bookTitle, string isbn) //bookNumber and bookTitle are the FORMAL Parameters
        {
            this.bookNumber = bookNumber;
            this.bookTitle = bookTitle;
            this.isbn = isbn;
            this.publishedDate = new Date();
        }

        public Book(int bookNumber, string bookTitle, string isbn, Date publishedDate) //bookNumber and bookTitle are the FORMAL Parameters
        {
            this.bookNumber = bookNumber;
            this.bookTitle = bookTitle;
            this.isbn = isbn;

            this.publishedDate = publishedDate;
        }
        // Setters and Getters for each private attribute
        public int GetBookNumber()
        {
            return this.bookNumber;
        }
        public void SetBookNumber(int bookNumber)
        {
            this.bookNumber = bookNumber;
        }
        public string GetBookTitle()
        {
            return this.bookTitle;
        }
        public void SetBookTitle(string bookTitle)
        {
            this.bookTitle = bookTitle;
        }
        public string GetIsbn()
        { return this.isbn; }
        public void SetIsbn(string isbn)
        {
            this.isbn = isbn;
        }

        public void SetPublishedDate( Date aPublishedDate)
        {
            this.publishedDate = aPublishedDate;
        }
        public Date GetPublishedDate()
        {
           return  this.publishedDate;
        }
        public string GetBookState()
        {
            string state;
            state = this.bookNumber + " | " + this.bookTitle + " | " + this.isbn + " | " + this.publishedDate;
            return state;
        }
    }
}
