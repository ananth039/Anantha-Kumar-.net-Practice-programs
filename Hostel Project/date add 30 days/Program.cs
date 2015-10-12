using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace date_add_30_days
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            DateTime dt2 = dt.AddDays(30);
            Console.WriteLine(dt2.ToShortDateString());
        }
    }
}
