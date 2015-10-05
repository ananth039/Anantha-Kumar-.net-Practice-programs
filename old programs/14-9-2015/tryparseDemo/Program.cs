using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryparseDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isContinue = false;
            do
            {
                Console.WriteLine("Enter one number");

                int n;
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    Console.Write("square of the number is ");
                    Console.Write("{0}*{0}=", n);

                    Console.WriteLine(calculateSquare(n));

                }
                else
                {
                    Console.WriteLine("Invalid Value. please enter integer values");
                }
                Console.WriteLine("Do you want continue? y or N");
                    string option=Console.ReadLine();
               if(option=="y"|option=="Y")
               {
                   isContinue=true;
               }
               else if(option=="n"|option=="N")
               {
                   isContinue=false;
                   break;
               }
               else
               {
                   Console.WriteLine("you enterd invalid option.try again");
                   isContinue = true;
                   Console.WriteLine( );
               }
                
            } while (isContinue);
        }
        private static int calculateSquare(int n)
                      {
                         
                          return n * n;
                        }
          
        }

          
    }
     

