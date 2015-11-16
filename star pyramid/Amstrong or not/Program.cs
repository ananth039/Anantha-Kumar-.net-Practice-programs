using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Amstrong_or_not
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter one 3 digit number");
            int number = int.Parse(Console.ReadLine());
            int temp = number;
            int sum = 0, remainder= 0, cube = 0;
           
            for(int i=1;i<=3;i++)
            {
                remainder = number % 10;
                cube =remainder*remainder*remainder;
                sum = sum + cube;
                number = number / 10;
            }
            if(sum==temp)
            {
                Console.WriteLine("The given number is amstrong");
            }
            else
            {
                Console.WriteLine("The given number is not A amstrong");
            }
        }
    }
}
