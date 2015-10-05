using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_main_methods
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("This is the Main() method in Program class.");
            Console.Read();
        } 
    }
    class MySample
    { 
        static void Main(string[] args)
        { 
            Console.WriteLine("This is the Main() method in MySample class."); 
            Console.Read(); 
        } 
    }
}
