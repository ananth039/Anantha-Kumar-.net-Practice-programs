using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class StringExample
    {
        public static int Main()
        {
            string s1 = "a string";
            string s2 = s1;
            Console.WriteLine("s1 is " + s1);
            Console.WriteLine("s2 is " + s2);
            s1 = "another string";
            Console.WriteLine("s1 is now " + s1);
            Console.WriteLine("s2 is now " + s2);
            return 0;
        }
    }
}
