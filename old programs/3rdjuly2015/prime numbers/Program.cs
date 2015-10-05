using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int entry = 0;
            Console.WriteLine("Please enter a value");
            entry = int.Parse(Console.ReadLine());
            if (entry > 2)
            {

                int currentnumber = 2;
               
                while (currentnumber < entry)
                {
                   
                    currentnumber++;
                }

                if (isPrime(entry))
                {
                    Console.WriteLine("Prime number");

                }
                else
                {

                    Console.WriteLine("Not Prime number");
                }
            }
        }
    }
}
