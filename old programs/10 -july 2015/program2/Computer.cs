using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace program2
{
    class Computer
    {
        private Monitor monitor;
        private InputDevice keyboard;
        private Processor cpu;


        public Computer(Monitor monitor, Processor cpu, InputDevice keyboard)
        {
            this.monitor = monitor;
            this.cpu = cpu;
            this.keyboard = keyboard;
        }

        public void Describe()
        {
            monitor.Start();
            cpu.Identify();
            keyboard.Identify();
            monitor.Identify();
            monitor.Stop();

        }

        public Monitor Monitor
        {
            set
            {
                this.monitor = value;
            }

        }
    }
}
