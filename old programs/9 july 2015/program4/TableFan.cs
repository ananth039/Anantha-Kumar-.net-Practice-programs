using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace program4
{
    class TableFan:Fan
    {
     public override void SwitchOn()
        {
            Console.WriteLine("Table fan is switched on ");
        }

        public new void Rotate()
        {
            Console.WriteLine("Table fan is rotated ");
           
        }
    }
}
