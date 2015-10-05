using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace program2
{
    class LEDMonitor:Monitor
    {

        public override void Start()
        {
            Console.WriteLine("LED Monitor Started");
        }

        public override void Stop()
        {
            Console.WriteLine("LED Monitor Stopped");

        }
    }
}
