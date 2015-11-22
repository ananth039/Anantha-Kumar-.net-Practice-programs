using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            
            for (x = -1; x <= 10; x++)
            {
                if (x < 5)
                    continue;
                else
                    break;
                Console.WriteLine("Ananth");
            }
        }
    }
}