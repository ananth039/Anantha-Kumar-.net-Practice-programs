using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _this__Keyword_Demo
{
    class Sample 
    { 
        //fields
        public int n = 100; 
        //methods 
        public void Increment() 
        { 
            int n = 10; 
            //incrementation value
            this.n = this.n + n;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sample s = new Sample();
            Console.WriteLine(s.n);
            s.Increment();
            Console.WriteLine(s.n); 
            Console.Read();
        }
    }
}
