using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interview_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter range");
            int range = int.Parse(Console.ReadLine());
            for(int i=1;i<=range;i++)
            {
                for (int j = 1; j <= i;j++ )
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine(" ");
               
            }
        }
    }
}
