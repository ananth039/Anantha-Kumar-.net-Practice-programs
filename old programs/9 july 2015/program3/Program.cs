using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program3
{
    class Program
    {
        static void Main(string[] args)
        {
            ElectricToy e = new ElectricToy();
            e.Run();
            e.MakeSound();
            display(e);
            Toy told = new Toy();
            display(told);
            Toy t = new ElectricToy();
            display(t);
        }
        static void display(Toy e)
        {
            e.Run();
            e.MakeSound();
        }

        }
    }

