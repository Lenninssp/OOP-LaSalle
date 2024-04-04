using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsSchoolLibraryV3.bus
{
    [Serializable]
    public  class Book : Item
    {
        //Data member: (private fields)
        //Fields
        private int pages;

        // Properties
        // 
        public int Pages
        {
            get { return this.pages; }
            set { this.pages = value; }
        }
        // Methods (functions) Member
        public Book() : base()
        {
            this.pages = 0;
        }
        public Book(int number, string title) : base(number, title)
        {
            this.pages = 0;

        }
        public Book(int number, string title, EnumLanguage language) : base(number, title, language)
        {
            this.pages = 0;

        }

        public Book(int number, string title, EnumLanguage language, Date publishedDate) : base(number, title, language, publishedDate)
        {
            this.pages = 0;

        }

        public Book(int number, string title, EnumLanguage language, Date publishedDate, int pages) : base(number, title, language, publishedDate)
        {
            this.pages = pages;

        }
        public string GetBookState()
        {
            string state;

            state = base.GetItemState() + " | " + this.pages;

            return state;
        
        }

    }
}
