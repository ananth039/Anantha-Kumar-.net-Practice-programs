using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_Of_Squares_of_the_natural_numbers
{
    class Program
    {
        public delegate void Print(String Message);
        static void Main(string[] args)
        {
            Print p = new Print(Console.WriteLine);
           

            long sumOfSquares = 0;
            long SquareOfSum = 0;
            long SquareOfSum2=0;
            long difference=0;
      

            long NaturalNumbersLimit=100;
           
            for(long num=1;num<=NaturalNumbersLimit;num++)
            {
                sumOfSquares += num * num;
                SquareOfSum += num;
            }
            p("The Sum Of the Squares of the First "+NaturalNumbersLimit+" Natuarl Numbers is:");
            p(sumOfSquares.ToString());
            p("");
            Console.WriteLine(sumOfSquares);
            Console.WriteLine();
            Console.WriteLine(SquareOfSum2);
            Console.WriteLine();
            Console.WriteLine(difference);
            p("Square of the Sum Of the first "+NaturalNumbersLimit+" Natural nNumbers is");
            SquareOfSum2 = SquareOfSum * SquareOfSum;
            p(SquareOfSum2.ToString());
            p("");
            difference=SquareOfSum2-sumOfSquares;

            p("The Difference between the sum of the squares of the first " + NaturalNumbersLimit + " Natural Numbers and Square of the sum is");
            p("");
            p(SquareOfSum2 + "-" + sumOfSquares + "=" + difference);
            p("");
            p(difference.ToString());
            p("");
        }
        }
    }

