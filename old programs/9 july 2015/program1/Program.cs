using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            ElectricToy e = new ElectricToy();
            e.Run();
            e.MakeSound();
            Toy told = new Toy();
            told.Run();
            told.MakeSound();
            Toy t = new ElectricToy();
            t.Run();       // call Run method in ElectricToy class
            t.MakeSound(); // call MakeSound method in Toy calss
        }
    }
}
