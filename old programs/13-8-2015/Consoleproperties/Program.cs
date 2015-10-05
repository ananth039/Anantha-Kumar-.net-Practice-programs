using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoleproperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title="EX";
         Console.BackgroundColor=ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.CursorSize = 5;
            for (int i = 1; i <= 5; i++)
            {
                Console.Beep();
                Console.WriteLine("Beep " + i);
            }
            Console.Clear();
            Console.ResetColor();
            Console.WriteLine("color is changed");
            Console.Read();
            
        }
    }
}
