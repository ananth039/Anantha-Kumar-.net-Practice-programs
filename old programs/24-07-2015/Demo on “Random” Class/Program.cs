using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_on__Random__Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            for (int i = 0; i < 300; i++) 
            {
                Console.Write(r.Next(1, 300) + ", ");
            } 
            Console.Read();
        }
    }
}
