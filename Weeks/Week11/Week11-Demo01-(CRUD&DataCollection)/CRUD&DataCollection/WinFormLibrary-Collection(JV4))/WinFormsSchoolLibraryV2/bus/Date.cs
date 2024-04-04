using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinFormsSchoolLibraryV3.bus
{
    [Serializable]
   public struct Date
    {
        //-1- Fields
        private int month;
        private int day;
        private int year;

        //-2- Properties

        public int Month { get { return this.month; } set { this.month = value; } }
        public int Day { get { return this.day; } set { this.day = value; } }
        public int Year { get { return this.year; } set { this.year= value; } }

        //-3- Methods
        public Date()
        {
            this.month = 0;
            this.day = 0;
            this.year = 0;
        }
        public Date(int month, int day, int year)
        {
            this.month = month;
            this.day = day;
            this.year = year;        
        }

        public string GetDateState()
        {
            string state;
            state = this.month + "/" + this.day + "/" + this.year;
            return state;        
        }

   }
}