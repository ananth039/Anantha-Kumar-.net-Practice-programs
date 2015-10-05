using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] a = new int[3][]; 
            a[0] = new int[] { 1, 2 };
            a[1] = new int[] { 3, 4, 5, 6, 7, 8 };
            a[2] = new int[] { 9, 10, 11 };
            for (int i = 0; i < a.Length; i++) 
            { 
                for (int j = 0; j < a[i].Length; j++)
                { 
                    Console.Write(a[i][j] + " ");
                }
                Console.WriteLine();
            } 
            Console.Read();
        }
    }
}
