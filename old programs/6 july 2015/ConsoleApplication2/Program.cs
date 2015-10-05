using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Tv t = new Tv();
            t.log();
            Tv tv = new Tv("Samsung");
            tv.log();
            Tv mynewtv = new Tv("DC","Sony");
            mynewtv.log();
        }
    }
}
