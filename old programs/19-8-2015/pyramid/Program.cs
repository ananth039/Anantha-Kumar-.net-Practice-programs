using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter one number");
            int a = int.Parse(Console.ReadLine());
            char star = '*';
            int currentIteration = 0; 
              int imediatevalue;
              Console.WriteLine("\n while loop \n");
            while (currentIteration < a)
            {
                imediatevalue = 0;
                while (imediatevalue <= currentIteration)
                {
                    Console.Write(star);
                    imediatevalue++;
                }
                Console.WriteLine("");
                currentIteration++;
            }

            Console.WriteLine("\n For loop \n");
            for(currentIteration=0;currentIteration<a;currentIteration++)
            {
               
                for(imediatevalue=0;imediatevalue<=currentIteration;imediatevalue++)
                {
                    Console.Write(star);

                }
                Console.WriteLine("");
            }
        }
    }
}
