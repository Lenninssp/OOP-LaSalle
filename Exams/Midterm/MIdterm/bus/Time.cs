using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIdterm.bus
{
    [Serializable]
    public class Time
    {
        private int minutes;
        private int hours;

        public int Hours
        {
            get { return hours; }
            set { hours = value; }
        }
        public int Minutes
        {
            get { return minutes; }
            set { minutes = value; }
        }

        public Time()
        {
            hours = 0;
            minutes = 0;
        }
        public Time(int hours, int minutes)
        {
            this.hours = hours;
            this.minutes = minutes;
        }
        public string GetState()
        {
            return $"{hours} hours with {minutes } minutes";
        }
    }
}


