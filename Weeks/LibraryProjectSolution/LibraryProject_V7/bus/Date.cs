namespace LibraryProject_V7{
    struct Date {
        int month ;
        int day ;
        int year ;

        public Date(int month = 0 , int day = 0, int year = 0){

            this.month = month;
            this.day = day;
            this.year = year;

        }

        public int Month {
            get{return this.month;}
            set{this.month = value;}
        }
        public int Day {
            get{return this.day;}
            set{this.day = value;}
        }
        public int Year {
            get{return this.year;}
            set{this.year = value;}
        }

        public string GetValues(){
            return $"{this.day}/{this.month}/{this.year}";
        }
    }
}