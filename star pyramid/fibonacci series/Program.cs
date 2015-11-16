using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci_series
{
    class Program
    {
        static void Main(string[] args)
        {
            int f1 = 0, f2 = 1, f3 = 0;
            Console.Write(f1);
            Console.Write(f2);
            for(int i=1;i<=7;i++)
            {
                f3 = f1 + f2;
                Console.Write(f3);
                f1 = f2;
                f2 = f3;
            }
        }
    }
}
