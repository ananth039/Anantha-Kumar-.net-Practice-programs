using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace star_pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter one number");
            int n = int.Parse(Console.ReadLine());
            int a=1;
            Console.WriteLine("your pyramid");
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                    Console.Write(" ");
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    
                    Console.Write("*");
                 

                }

                    Console.WriteLine(" ");
            }
            }
        }
    }

