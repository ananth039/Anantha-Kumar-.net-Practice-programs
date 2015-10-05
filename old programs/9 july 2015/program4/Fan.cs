using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace program4
{
    class Fan
    {
       
        public  virtual void SwitchOn()
        {
            Console.WriteLine("celing fan is switched on ");
        }
        public  void Rotate()
        {
            Console.WriteLine("celling fan is roatated ");
        }

    }
}
