using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_or_odd_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a Value");
            int entry = int.Parse(Console.ReadLine());
            if (entry > 0)
            {
                if (Number.Iseven(entry))
                {
                    Console.WriteLine("{0} is even", entry);

                }
                else
                {
                    Console.WriteLine("{0} is odd", entry);
                }
            }

        }

    }|
}

