using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program3
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartTv tv = new SmartTv("Sony", "Dc");
            tv.SoundSystem = "Dolby";
            tv.InternetConnectivity = "3G";

            tv.Log();
        }
    }
}
