using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref_Parameters_Demo
{
    class SampleClass
    { 
        public void FirstMethod(int x, int y)
        {
            x++; 
            y++; 
        } 
        public void SecondMethod(int x, ref int y)
        {
            x++;
            y++;
        } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20; 
            SampleClass sc = new SampleClass();
            Console.WriteLine(a + ", " + b);
            sc.FirstMethod(a, b);
            Console.WriteLine(a + ", " + b);
            sc.SecondMethod(a, ref b);
            Console.WriteLine(a + ", " + b);
            Console.Read();
        }
    }
}
