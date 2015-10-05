using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program4
{
    class Program
    {
        static void Main(string[] args)
        {
            Fan f = new Fan();
            f.SwitchOn();
            f.Rotate();
            
            TableFan tf = new TableFan();
           
            tf.SwitchOn();
            tf.Rotate();

            Fan ft = new TableFan();
           
            ft.SwitchOn();
            ft.Rotate();
        }
    }
}
