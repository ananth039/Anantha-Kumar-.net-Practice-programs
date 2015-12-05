using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_number_star_pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Odd number");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    if (i % 2 == 0)
                        Console.Write("* ");
                }
                Console.WriteLine("");

            }
        }
    }
}
