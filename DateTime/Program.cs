using System;

namespace Date
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime();
            date1 = new DateTime(2022, 12, 27, 14, 30, 0);
            date1 = date1.AddDays(4);
            //Console.WriteLine(date1);
            Console.WriteLine(date1.ToString("yyyy-MM-dd-hh-mm"));
            string dateStr = "02-16-2005";
            DateTime date2 = Convert.ToDateTime(dateStr);
            Console.WriteLine(date2);
            Console.WriteLine(date2.ToString("yyyy-MM-dddd-hh-mm"));
            //DateTime startdate = new DateTime(2005, 02, 16);
            //DateTime enddate = new DateTime(2022, 12, 27);
            //var diff = enddate - startdate;
            //Console.WriteLine(diff.Hours);
            //Console.WriteLine(diff.TotalHours);

            // Console.WriteLine(  diff.Minutes);
            //Console.WriteLine(diff.TotalMinutes);
            //task
            string inputdateStr = Console.ReadLine();
            DateTime inputdate = Convert.ToDateTime(inputdateStr);

            Console.WriteLine(inputdate.DayOfWeek);
            Console.WriteLine(inputdate.ToString("dddd"));


           
        }
    }
}

