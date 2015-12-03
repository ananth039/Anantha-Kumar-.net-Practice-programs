using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stars_program
{
    class Program
    {
        static void Main(string[] args)
        {

            int i, j;

            for (i = 1; i <= 5; i++)
            {
                for (int k = 4; k >= i; k--)
                {
                    Console.Write(" ");
                }

                    for (j = 1; j <= i; j++)
                    {
                        Console.Write(" * ");
                    }

                    Console.WriteLine(" ");
                }

            
        }

                }
            
        }
    //}

