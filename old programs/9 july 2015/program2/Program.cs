using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class Program
    {
        static void Main(string[] args)
        {
            Toy t = new ElectricToy();
            t.Run();       // call Run method in ElectricToy class
            t.MakeSound(); // call MakeSound method in Toy calss
        }
    }
}
