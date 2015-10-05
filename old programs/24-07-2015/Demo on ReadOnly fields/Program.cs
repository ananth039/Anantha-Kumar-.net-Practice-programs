using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_on_ReadOnly_fields
{
    class Sample 
    { 
        //read only data member
        public readonly string CompanyName = "Wipro";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sample s = new Sample(); 
            Console.WriteLine(s.CompanyName);
            //s.CompanyName = "TCS"; // is not allowed bcoz it is the readonly member. 
            Console.Read();
        }
    }
}
