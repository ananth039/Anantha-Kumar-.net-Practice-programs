using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_program_using_web_services
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorService.Calculator cal = new CalculatorService.Calculator();
            Console.WriteLine("Add:"+ cal.Add(2, 5));

            Console.WriteLine("Subtract:" + cal.Subtract(100, 85));
            Console.WriteLine("Multiply:" + cal.Multiply(200, 35));
            Console.WriteLine("Divide:" + cal.Divide(500, 200));



        }
    }
}
