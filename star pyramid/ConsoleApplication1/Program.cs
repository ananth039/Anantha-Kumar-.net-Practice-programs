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
            int n, c, k, space, count = 1;

            n = 6;
    space = n;
            
 
    for ( c = 1 ; c <= n ; c++)
    {
        for( k = 1 ; k < space; k++)
          Console.Write(" ");
 
        for ( k = 1 ; k <= c ; k++)
        {
            Console.Write("*");
 
            if ( c > 1 && count < c)
            {
                Console.Write(" ");    
                 count++; 
            }      
        }

        Console.WriteLine(" ");
        space--;
        count = 1;
    }
              
               
        }
    }
}