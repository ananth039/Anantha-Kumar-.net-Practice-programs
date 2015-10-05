using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_or_odd
{
    class Program
    {

        
        static void Main(string[] args)
        {
          
            Console.WriteLine("please enter a Value");
           int  entry = int.Parse(Console.ReadLine());
            if(entry>0)
            {
                EvenNumber Number = new EvenNumber();
                if(Number.IsEven(entry))
                {
                    Console.WriteLine("{0} is even", entry);

                }
                else
                {
                    Console.WriteLine("{0} is odd", entry);
                }
            }
        }
    }
}
