using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace date_and_time_example
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);
            Console.WriteLine(dt.ToShortDateString());
            Console.WriteLine(dt.ToShortTimeString());
            Console.WriteLine( dt.ToUniversalTime());
            Console.WriteLine(dt.Hour+":"+dt.Minute);      
            Console.WriteLine(  dt.TimeOfDay);              
        }

    }
}
