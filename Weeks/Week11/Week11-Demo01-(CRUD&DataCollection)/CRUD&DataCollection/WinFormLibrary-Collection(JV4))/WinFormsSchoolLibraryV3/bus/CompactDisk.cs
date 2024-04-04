using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsSchoolLibraryV3.bus
{
    public class CompactDisk : Item
    {
        private int capacity;

        public int Capacity
        {
            get { return this.capacity; }
            set { this.capacity = value; }

        }

        public CompactDisk() : base()
        {
            this.capacity = 0;
        }

        public CompactDisk(int number, string title) : base(number, title)
        {
            this.capacity = 0;
        }


        public CompactDisk(int number, string title, EnumLanguage language) : base(number, title, language)
        {
            this.capacity = 0;

        }

        public CompactDisk(int number, string title, EnumLanguage language, Date publishedDate) : base(number, title, language, publishedDate)
        {
            this.capacity = 0;

        }

        public CompactDisk(int number, string title, EnumLanguage language, Date publishedDate, int capacity) : base(number, title, language, publishedDate)
        {
            this.capacity = capacity;

        }
        public string GetCompactDiskState()
        {
            string state;

            state = base.GetItemState() + " | " + this.capacity;

            return state;

        }




    }


}
