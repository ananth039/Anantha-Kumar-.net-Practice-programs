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
            for (int i = 5; i >= 1; i--)
            {
                for (int k = 4; k >= i; k--)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    // if (i == 1 || i == 3 || i == 5)
                    if(i%2==1)

                    Console.Write("* ");
                }
                Console.WriteLine(" ");

            }

        }
    }
}
