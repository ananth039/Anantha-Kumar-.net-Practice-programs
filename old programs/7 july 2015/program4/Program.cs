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
            SmartTv tv = new SmartTv("Samsug", "Dc");
            tv.SoundSystem = "Dolby Atom";
            tv.InternetConnectivity = "4G";

            tv.Log();
        }
    }
}
