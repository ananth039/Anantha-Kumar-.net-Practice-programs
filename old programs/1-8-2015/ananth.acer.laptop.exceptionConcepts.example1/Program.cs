using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ananth.acer.laptop.exceptionConcepts.example1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cites = { "vijayawada", "Rajamundry", "vizag","hyderabad" };
            try
            {
                for (int i = 0; i < cites.Length;i++ )
                {
                    Console.WriteLine(cites[i]);
                }
                    Console.WriteLine("\n"+cites[3]);
                Console.WriteLine(cites[4]);
            }
            catch(Exception e)
            {
               
                Console.WriteLine("\n error occured");
                Console.WriteLine(e.Message);
                
            }
            finally
            {
                Console.WriteLine("\n The finally Block");
                Console.Read();
            }
            
        }
    }
}
