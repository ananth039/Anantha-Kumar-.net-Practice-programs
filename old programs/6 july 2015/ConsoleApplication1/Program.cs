using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Smarttv t = new Smarttv();
            t.display();
            Smarttv tv = new Smarttv("Samsung");
            tv.display();
            Smarttv mynewtv = new Smarttv("Sony", "DC");
            mynewtv.display();
        }
    }
}
