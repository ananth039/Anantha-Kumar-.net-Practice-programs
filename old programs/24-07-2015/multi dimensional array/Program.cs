using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multi_dimensional_array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Single dimension Array
            int[] x = { 10, 20, 30, 40 };
            Console.WriteLine("single dimension Array:");
            for (int i = 0; i < x.Length; i++)
                Console.WriteLine(x[i] + "");

            //Double dimension Array
            int[,] y = { { 10, 20 }, { 30, 40 }, { 50, 60 } };
            Console.WriteLine("Double dimension Array:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                    Console.WriteLine(y[i, j] + "");
            }
            Console.WriteLine("");

            //Multi Dimensional Array
            int[, ,] z = { { { 5, 10 }, { 15, 20 } }, { { 25, 30 }, { 35, 40 } }, { { 45, 50 }, { 55, 60 } } };
            Console.WriteLine("\nMulti dimensional array:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                        Console.Write(z[i, j, k] + " ");
                    Console.WriteLine();
                }
                Console.WriteLine();
            } Console.Read();
        }
    }
}