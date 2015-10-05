using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100_prime_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int entry = 0, stno;
           string s;

           
            Console.WriteLine("Please enter a value");
            entry = int.Parse(Console.ReadLine());

            int currentnumber = 2;
            int count = 1;
            while (entry<=count)
            {
                for (stno = 1; stno <= entry; stno++)
                {
                    if (stno % currentnumber == 1)
                    {

                        

                        Console.WriteLine(count+""+stno);
                        count++;

                    }
                    count = count + 1;
                    currentnumber++;
                }
            }
            count++;
          }
        }

    }



     
         
