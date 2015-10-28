using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_program_with_stars_and_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter ur number:");
            int n = int.Parse(Console.ReadLine());
            int i, j, k, m, l;
            for (i = 1; i <= n; i++)
            {
                for (int s = i; s <= n; s++)
                {
                    Console.Write(" ");
                }
                for (l = i; l >= 2; l--)
                {
                    Console.Write("*");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write(k);
                }
                Console.WriteLine();
            }
            for (m = n - 1; m >= 1; m--)
            {
                for (int x = m - 1; x < n; x++)
                {
                    Console.Write(" ");
                }
                for (int b = m; b >= 2; b--)
                {
                    Console.Write("*");
                }
                for (j = 1; j <= m; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
