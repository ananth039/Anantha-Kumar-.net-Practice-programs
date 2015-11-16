using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows, i, j, space;
            rows = 6;

            for (i = rows; i >= 1; --i)
            {

                for (space = 0; space < rows - i; ++space)
                    Console.Write("  ");
                for (j = i; j <= 2 * i - 1; ++j)
                    Console.Write("* ");
                for (j = 0; j < i - 1; ++j)
                    Console.Write("* ");
                Console.WriteLine(" ");
            }
        }
              
               
        }
    }

