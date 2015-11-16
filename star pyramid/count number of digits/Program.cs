using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace count_number_of_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            long n, count = 0;
            n = 9912481075;
            while(n!=0)
            {
                n = n / 10;
                count++;
            }
            Console.WriteLine(count);
        }

    }
}
