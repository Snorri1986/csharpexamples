using System;
using System.Net.Http.Headers;

namespace DateTime2 {
    class Program
    {
        static void Main(string[] args)
        {
            DateTime awesomeDate = new DateTime(1974,12,21);
            Console.WriteLine("Day of Week {0}", awesomeDate.DayOfWeek);
            // add days
            awesomeDate = awesomeDate.AddDays(1);
            Console.WriteLine("Day of Week {0}", awesomeDate.DayOfWeek);
            // add month
            awesomeDate = awesomeDate.AddMonths(1);
            Console.WriteLine("Month {0}", awesomeDate.Month);
            // add years
            awesomeDate = awesomeDate.AddYears(1);
            Console.WriteLine("Year {0}", awesomeDate.Year);
            // print all date
            Console.WriteLine("New date {0}", awesomeDate.Date);


            TimeSpan lunchTime = new TimeSpan(12, 30, 0);
            // change timespane(subsctract)
            lunchTime = lunchTime.Subtract(new TimeSpan(0,15,0));
            Console.WriteLine("Lunch Time: {0}", lunchTime.ToString());
        }
    }
}
