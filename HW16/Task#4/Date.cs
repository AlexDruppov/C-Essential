using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Date
    {
        public int Day {  get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public Date(int day, int month, int year) 
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public static int operator -(Date d1, Date d2) 
        {
            DateTime date1 = new DateTime(d1.Year, d1.Month, d1.Day);
            DateTime date2 = new DateTime(d2.Year, d2.Month, d2.Day);
            TimeSpan time = date1 - date2;
            return time.Days;
        }

        public static Date operator +(Date date, int day)
        {
            DateTime star = new DateTime(date.Year, date.Month, date.Day);
            DateTime end = star.AddDays(day);
            return new Date(end.Day, end.Month, end.Year);
        }

        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }
    }
}
