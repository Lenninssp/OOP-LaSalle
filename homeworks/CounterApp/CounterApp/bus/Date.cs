namespace CounterApp.bus
{
    public class Date
    {
        private int day;
        private int month;
        private int year;

        public int Day
        {
            get { return day; }
            set { day = value; }
        }
        public int Month
        {
            get { return month; }
            set { month = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public Date()
        {
            day = 0;
            month = 0;
            year = 0;
        }
        public Date (int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public string getState()
        {
            return $"{day} {month} {year}";
        }
    }
}