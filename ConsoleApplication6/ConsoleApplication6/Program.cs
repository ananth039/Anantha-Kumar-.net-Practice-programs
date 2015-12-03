using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter value");
            int n=int.Parse(Console.ReadLine());
            for (int i = 1; i <= n;i++)
            {
                for(int j=n;j>=1;j--)
                {
                    Console.Write("#" + " " + "o"+" ");
                   
                }
               
                Console.WriteLine();
                for(int k=n;k>=1;k--)
                {
                    Console.Write("o"+" " +"#"+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
