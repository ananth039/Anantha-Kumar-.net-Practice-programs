using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Hiding_Demo
{
    class MyMath 
    { 
        //private fields
        private int x, y; 
        //public methods
        public void SetValues(int FirstVal, int SecondVal)
        {
            x = FirstVal;
            y = SecondVal;
        }
        public void Addition()
        { 
            int sum = x + y;
            Console.WriteLine("Sum is " + sum);
        } 
        public void Subtraction() 
        { 
            int diff = x - y;
            Console.WriteLine("Difference is " + diff);
        } 
        public void Multiplication() 
        {
            int prod = x * y;
            Console.WriteLine("Product is: " + prod);
        } 
        public void Division() 
        { 
            int div = x / y;
            Console.WriteLine("Division is: " + div);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyMath mm = new MyMath(); 
            mm.SetValues(10, 3);
            mm.Addition();
            mm.Subtraction();
            mm.Multiplication();
            mm.Division(); 
            Console.Read();
        }
    }
}
