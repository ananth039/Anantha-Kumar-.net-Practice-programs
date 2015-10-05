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
            Computer computer1 = new Computer(
               new CRTMonitor(), new Processor(), new InputDevice());
            computer1.Describe();
            Computer computer2 = new Computer(
            new LEDMonitor(), new Processor(), new InputDevice());
            computer2.Describe();
        }
    }
}
