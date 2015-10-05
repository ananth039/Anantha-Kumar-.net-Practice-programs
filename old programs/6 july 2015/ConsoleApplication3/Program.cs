using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Notes n = new Notes();
            n.display();
            Notes nt = new Notes("Classmate");
            nt.display();
            Notes ntt=new Notes("Bindu","Nataraj");
            ntt.display();

        }
    }
}
