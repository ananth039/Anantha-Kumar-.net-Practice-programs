using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_mobile_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter ur Number");
            double a = Convert.ToDouble(Console.ReadLine());
            double d, res = 0;
            double e=0, f = 0;
            while(a!=0)
            {
               d = a % 10;
                 res = res + d;
                 
             
                a = a / 10;
                
            }
            Console.WriteLine((int)res);
          
        }
    }
}
