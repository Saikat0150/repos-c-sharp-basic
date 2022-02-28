using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addDatetimeMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt1d,dt2;
            //DateTime Now
            dt1d = DateTime.Now;
            Console.WriteLine("Day at present: " + dt1d.Day);
            Console.WriteLine("Month at present: " + dt1d.Month);
            Console.WriteLine("Year at present: " + dt1d.Year);
            Console.WriteLine("Hour at present: " + dt1d.Hour);
            Console.WriteLine("Minute at present: " + dt1d.Minute);
            Console.WriteLine("Second at present: " + dt1d.Second);
            Console.WriteLine("Millisecond at present: " + dt1d.Millisecond);
            Console.WriteLine("Day of the year: " + dt1d.DayOfYear);
            Console.WriteLine("Day at Week: " + dt1d.DayOfWeek);
            Console.WriteLine("Short date format of present date: " + dt1d.ToShortDateString());
            Console.WriteLine("Long date format of present date: " + dt1d.ToLongDateString());
            Console.WriteLine("Short time format of present date: " + dt1d.ToShortTimeString());
            Console.WriteLine("Long time format of present date: " + dt1d.ToLongTimeString());
            //adding 5 days
            dt2 = dt1d.AddDays(5);
            Console.WriteLine("After Adding 5 days: " + dt2.ToString());
            //adding 5 months
            DateTime dt3 = dt1d.AddMonths(5);
            Console.WriteLine("After adding 5 months: " + dt3.ToString());
            //after adding 5 years
            DateTime dt4 = dt1d.AddYears(5);
            Console.WriteLine("After adding 5 months: " + dt4.ToString());
            DateTime dt5 = dt1d.AddHours(5);
            Console.WriteLine("After adding 5 Hours: " + dt5.ToString());
            DateTime dt6 = dt1d.AddMinutes(5);
            Console.WriteLine("After adding 5 minutes: " + dt6.ToString());
            DateTime dt7 = dt1d.AddSeconds(5);
            Console.WriteLine("After adding 5 seconds: " + dt7.ToString());
            Console.Read();
        }
    }
}
