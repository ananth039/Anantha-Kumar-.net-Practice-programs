using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int i = 10;
            int j = 20;
            Console.WriteLine("{0} plus {1} equals {2}", i, j, i + j);
             i = 940;
            j = 73;
            Console.WriteLine(" {0,4}\n+{1,4}\n — — \n {2,4}", i, j, i + j);

            Console.WriteLine(" c is the local currency format");
            decimal a = 940.23m;
            decimal b= 73.7m;
            Console.WriteLine(" {0,9:C2}\n+{1,9:C2}\n — — — — -\n {2,9:C2}", a, b, a + b);
            double d = 0.234;
            Console.WriteLine("{0:#.00}", d);
           

        }
    }
}
