using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flag
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = "John";
            String password = "letmein";
            Boolean flag;
            flag = (name == "John" || name == "john"|| password=="letmein");
            Console.WriteLine(flag);
            Console.ReadKey();
        }
    }
}
