using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            do
            {
             
             if(i!=1)
             {
                
                 Console.Write(i);
                 Console.Write(" ");
                 i += 5;
               
             }
               else
             {
                 Console.Write(i);
                 Console.Write(" ");
                 i = 5;
             }

            } while (i <= 100);
        }
    }
}
