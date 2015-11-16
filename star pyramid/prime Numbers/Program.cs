using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter range");
            int range = int.Parse(Console.ReadLine());
            
            if(range>2) 
            {
               for(int i=2;i<=range;i++)
               {
                  
                       if (i % 2 == 0)
                       {

                       }
                       else
                       {
                         Console.WriteLine(i);   
                       }
                   
                  
                       
               }
              
            }
        }
    }
}
