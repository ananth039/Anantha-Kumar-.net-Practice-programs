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

            Console.WriteLine("enter one value");
            int n =Convert.ToInt32( Console.ReadLine());
            for (int i = n; i >= 1; i--)
            {
                for (int k = n-1; k >= i; k--)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <=i; j++)
                {
                    // if (i == 1 || i == 3 || i == 5)
                    if (i % 2 == 1)

                        Console.Write("* ");
                }
                Console.WriteLine(" ");

            }
        }
    }
}
