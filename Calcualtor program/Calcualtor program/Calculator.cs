using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcualtor_program
{
    public class Calculator
    {
       
        public double Addition(double a, double b)
        {
            return a + b;
        }
        public double Subtarction(double a, double b)
        {
            return a - b;
        }
        public double Multiplication(double a, double b)
        {
            return a * b;
        }
        public double Division(double a, double b)
        {
            if(b==0)
            {
                throw new DivideByZeroException();
            }
            return a / b;
        }
        public double Percentage(double a, double b)
        {
            return a % b;
        }
    }
}
