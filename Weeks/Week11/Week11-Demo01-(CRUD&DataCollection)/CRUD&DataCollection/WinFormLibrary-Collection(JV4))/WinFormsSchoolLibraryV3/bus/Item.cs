using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                                    using System.Xml.Serialization;

namespace WinFormsSchoolLibraryV3.bus
{
    public enum EnumItemType
    {
        Book,
        CompactDisk,
        Undefined

    }
       
    [XmlInclude (typeof(Book))]
    [XmlInclude(typeof(CompactDisk))]
   public class Item
    {
        //Data member: (private fields)
        //Fields
        private int number;
        private string? title;
        private EnumLanguage language;
        private Date publishedDate;

        private EnumItemType type;

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

        public EnumItemType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public Date PublishedDate
        {
            get { return this.publishedDate; }
            set { this.publishedDate = value; }
        }
        // Methods (functions) Member
        public Item()
        {
            this.number = 0;
            this.title = "Undefined";
            this.language = EnumLanguage.UNDEFINED;
            this.type = EnumItemType.Undefined;
        }
        public Item(int number, string title)
        {
            this.number = number;
            this.title = title;
            this.language = EnumLanguage.UNDEFINED;
            this.type = EnumItemType.Undefined;
        }
        public Item(int number, string title, EnumLanguage language)
        {
            this.number = number;
            this.title = title;
            this.language = language;
            this.type = EnumItemType.Undefined;
        }

        public Item(int number, string title, EnumLanguage language, Date publishedDate)
        {
            this.number = number;
            this.title = title;
            this.language = language;
            this.publishedDate = publishedDate;
            this.type = EnumItemType.Undefined;
        }

        public Item(int number, string title, EnumLanguage language, Date publishedDate , EnumItemType type)
        {
            this.number = number;
            this.title = title;
            this.language = language;
            this.publishedDate = publishedDate;
            this.type = type;

        }
        public string GetItemState()
        {
            string state;

            state = this.number + " | " + this.title + "  |  " + this.language
                + " | " + this.publishedDate.GetDateState()  + " | " + this.type;

            return state;

        }

    }
}
