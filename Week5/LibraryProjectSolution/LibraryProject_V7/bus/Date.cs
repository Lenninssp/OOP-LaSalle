using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryProject_V7.bus
{
    public struct Date
    {

        private int month;
        private int day;
        private int year;

        public Date()
        {
            month = 0;
            day = 0;
            year = 0;
        }
        public Date(int month, int day, int year)
        {
            this.month = month;
            this.day = day;
            this.year = year;
        }

        //Getters/Setters





        public string GetDateState()
        {
            string state;
            state = month + "/" + day + "/" + year;
            return state;
        }
    }
}