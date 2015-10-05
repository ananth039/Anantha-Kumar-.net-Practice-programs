using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ananth.acer.laptop.exceptionConcepts.example2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1, n2, n3;
                Console.WriteLine("Enter first value");
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second value");
                n2 = Convert.ToInt32(Console.ReadLine());
                n3 = n1 / n2;
                Console.WriteLine("The Result is " + n3);

            }
                catch(DivideByZeroException e)
            {
                Console.WriteLine("cant divide by zero.");
            }
            catch(OverflowException e)
            {
                Console.WriteLine("This is overflow excpetion.");
            }
            catch(FormatException e)
            {
                Console.WriteLine("This is invalid cast exception.");
            }
           
        }
    }
}
