using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floyd_s_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows, i, j, k = 0;
            rows = 6;
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; ++j)
                  Console.Write( k + j);
                ++k;
                Console.WriteLine();
                
            }
        }
    }
}
