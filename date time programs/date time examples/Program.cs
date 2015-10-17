using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace date_time_examples
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime dt2=DateTime.Now;
            DateTime dt3=DateTime.UtcNow;
            bool dt4=DateTime.IsLeapYear(dt2.Year);

            
            Console.WriteLine("Static Properties of “DateTime” Structure");
            Console.WriteLine("current date time:"+DateTime.Now);
            Console.WriteLine("");
               Console.WriteLine("Current time and date:"+dt2);
               Console.WriteLine("Current universal date and time:"+dt3);
               Console.WriteLine("");
               Console.WriteLine("Static Methods of “DateTime” Structure");
               Console.WriteLine("current year is leap year :"+dt4);
               Console.WriteLine("");



               CultureInfo culture = new CultureInfo("te-in");
               Console.WriteLine("telugu time format:"+dt2.ToString(culture));

               Console.WriteLine("");

               Console.WriteLine("Properties of DateTime Structure");

               Console.WriteLine("1.today in calendar:"+dt2.Day);
               Console.WriteLine("2.Current Month:"+dt2.Month);
               Console.WriteLine("3.Current year:"+dt2.Year);
               Console.WriteLine("4. current hour:"+dt2.Hour);
               Console.WriteLine("5.current minutes:"+dt2.Minute);
               Console.WriteLine("6.current seconds:"+dt2.Second);
               Console.WriteLine("7.Current milli seconds:"+dt2.Millisecond);

               Console.WriteLine("index of the current day:"+dt2.DayOfYear);
               Console.WriteLine("current week name:"+dt2.DayOfWeek);
               Console.WriteLine("");
               Console.WriteLine("current date and time:" + dt2.Date);

               Console.WriteLine("time of day:" + dt2.TimeOfDay);
              

               Console.WriteLine("");

               Console.WriteLine("Methods of “DateTime” Structure");
               Console.WriteLine("string format:"+dt2.ToString());
               Console.WriteLine("short date:" + dt2.ToShortDateString());
               Console.WriteLine("Long date:" +dt2.ToLongDateString());
               Console.WriteLine("Short time:" + dt2.ToShortTimeString());
               Console.WriteLine("long time:" + dt2.ToLongTimeString());

               Console.WriteLine("add 5 days:"+dt2.AddDays(5));
               Console.WriteLine("add 2 months:"+dt2.AddMonths(2));
               Console.WriteLine("add 3 years:"+dt2.AddYears(3));
               Console.WriteLine("add 4 hours:"+dt2.AddHours(4));
               Console.WriteLine("add 5 minutes:"+dt2.AddMinutes(5));
               Console.WriteLine("add 6 seconds:"+dt2.AddSeconds(6));
               Console.WriteLine("add 70 millis seconds:"+dt2.AddMilliseconds(70));

               Console.WriteLine("Comparisoin operators in date");
               if (dt2 == dt3)
                   Console.WriteLine("\ndt1 and dt2 are equal."); 
               else if (dt2 > dt3)
                   Console.WriteLine("\ndt1 is greater than dt2."); 
               else if (dt2 < dt3)
                   Console.WriteLine("\ndt1 is less than dt2.");

               Console.WriteLine("");
               Console.WriteLine("timespan");
               TimeSpan t = dt2 - dt3;
               Console.WriteLine("difference two datetimes:"+t);
               Console.WriteLine("difference in minutes:" + t.Minutes);
               Console.WriteLine("difference in seconds:" + t.Seconds);
               Console.WriteLine("difference in Hours:" + t.Hours);
               Console.WriteLine("difference in days:" + t.Days);
               Console.WriteLine("Total hours:" + t.TotalHours);
               Console.WriteLine("total minues:"+t.TotalMilliseconds);
               Console.WriteLine("total seconds:"+t.TotalSeconds);
               Console.WriteLine("total days:"+t.TotalDays);
               Console.WriteLine("");
               Console.WriteLine("date time formats");
               Console.WriteLine("date:"+dt2.ToString("MM-dd-yyyy"));
               Console.WriteLine("date:" + dt2.ToString("MMM-dd-yyyy"));
               Console.WriteLine("date:" + dt2.ToString("d-M-yy"));
               Console.WriteLine("date:" + dt2.ToString("dd/MMM/yy"));

               Console.WriteLine("Time:" + dt2.ToString("HH:MM"));
               Console.WriteLine("Time:" + dt2.ToString("h:m:s"));
               Console.WriteLine("Time:" + dt2.ToString("HH:MM:ss:ms"));

               Console.WriteLine("");
               Console.WriteLine("Stop watch concept");
               Stopwatch s = new Stopwatch();
               s.Start();
            for(int i=0;i<=60;i++)
            {
                Console.WriteLine("stop watch concept:"+i );
            }
            s.Stop();
            
            Console.WriteLine("elapsed time:"+s.Elapsed.ToString());
            s.Reset();
            Console.WriteLine("stopwatch reset time:" + s.Elapsed.ToString());

        }

        }

    }

