using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplication_table
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=1;
            Console.WriteLine("enter one  number to  generate multipliaction table ");
                int num=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter range of the multiplication table");
                int range = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("***** "+num+" multiplication table *********");
                do
                {
                    Console.WriteLine("{0} *{1} = {2}", i, num, i * num);
                    i++;
                } while (i <= range);

        }

    }
}
