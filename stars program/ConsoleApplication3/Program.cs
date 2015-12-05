using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, j, m = 3, n = 5,k;
            while(i<=m)
            {
                //for (k =n-1; k>=1;k--)
                //{
                //    Console.Write(" ");
                //}
               
                    for (j = 1; j <= n; j++)
                    {
                        Console.Write("* ");
                    }
               n= n-2;
                i++;
                Console.WriteLine(" ");
                
            }

        }
    }
}
