using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ananth.acer.laptop.mouse.touch;
using library1 = ananth.acer.laptop1;

namespace Namespacedemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            ananth.acer.laptop.Keyboard.keys key = new ananth.acer.laptop.Keyboard.keys();
            ananth.acer.laptop.Keyboard.keys.displayKeyboard();
            Console.WriteLine("");

            drag ddhfg = new drag();
            drag.displayMouse();
            Console.WriteLine("");

            //ananth.acer.laptop1.Drag ddhfg = new ananth.acer.laptop1.Drag();
            library1.Drag ddhf = new library1.Drag();
            library1.Drag.displayMouse();
            Console.WriteLine("");
        }
    }
}
