using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter ur Number");
            string a =Console.ReadLine();
            int sum = 0;
            for(char ch in a)
            {
                sum=-48+ch+sum;
            }
        }
    }
}
