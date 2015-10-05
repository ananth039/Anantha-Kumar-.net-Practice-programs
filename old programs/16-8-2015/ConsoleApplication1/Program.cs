using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaDemo
{
    class Program
    {
        static Action<int> displayAction = (number => Console.WriteLine(number.ToString()));

        static Func<double, int, double, double> simpleIntrestFunction = ((p, t, r) =>
        {
            return (p * t * r) / 100;
        });

        static Func<int, int, int> multiplyAction = ((number1, number2) =>
        {
            return number1 * number2;
        });
        static void Main(string[] args)
        {

            for (int index = 0; index < 100; index++)
            {

                displayAction(multiplyAction(index, 5));
            }
            CalculateSimpleIntrest(simpleIntrestFunction, 100000.0, 2, 2);

        }

        public static void CalculateSimpleIntrest(Func<double, int, double, double> simpleIntrestFunc, double p, int t, double r)
        {
            Console.WriteLine(simpleIntrestFunc(p, t, r));
        }

        static void DisplayToConsole(int number)
        {
            Console.WriteLine(number.ToString());
        }
    }
}
