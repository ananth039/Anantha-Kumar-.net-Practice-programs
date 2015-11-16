using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your Number");
            int no = int.Parse(Console.ReadLine());
             int revno=0;
            while(no!=0)
            {
               int r = no % 10;
               revno = revno * 10 + r;
                no = no / 10;
            }
            Console.WriteLine( revno);
        }
    }
}
