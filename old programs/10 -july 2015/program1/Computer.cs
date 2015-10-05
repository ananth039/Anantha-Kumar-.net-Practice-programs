using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace july_10_2015
{
    class Computer
    {

        private CRTMonitor monitor;
        private InputDevice keyboard;
        private Processor cpu;

        public Computer()
        {
            monitor = new CRTMonitor();
            keyboard = new InputDevice();
            cpu = new Processor();
        }
        public Computer(CRTMonitor monitor, Processor cpu, InputDevice keyboard)
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

        public CRTMonitor Monitor
        {
            set
            {
                this.monitor = value;
            }
           
        }
    }
}
