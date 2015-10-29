using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcualtor_program
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            Console.WriteLine("Addition: {0}",cal.Addition(2,3));
            Console.WriteLine("Subtarction: {0}", cal.Subtarction(10, 5));
            Console.WriteLine("Division: {0}", cal.Division(25, 5));
            Console.WriteLine("Multiplication: {0}", cal.Multiplication(100, 25));
            Console.WriteLine("Percentage: {0}", cal.Percentage(50, 10));
        }
    }
}
