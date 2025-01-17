namespace Session03
{
    public class HiringDate
    {
		private int day;
        private int month;
        private int year;

     

        public int Day
		{
			get { return day; }
			set { day=value>31 || value <= 0 ? DateTime.Now.Day:value; }
        }

		public int Month
		{
			get { return month; }
			set { month = value>12 || value <= 0 ? DateTime.Now.Month:value; }
		}

		public int Year
		{
			get { return year; }
			set { year = value>DateTime.Now.Year || value<=0?DateTime.Now.Year:value; }
		}
        public HiringDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public HiringDate()
        {
            day=DateTime.Now.Day;
            month=DateTime.Now.Month;
            year=DateTime.Now.Year;
        }

        public DateTime ToDateTime()
        {
            return new DateTime(year, month, day);
        }
        public override string ToString()
        {
            return $"({Day} / {Month} / {Year} )";
        }
    }
}