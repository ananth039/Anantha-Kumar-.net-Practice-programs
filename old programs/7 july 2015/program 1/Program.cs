using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07july_01
{
    class Program
    {
        static void Main(string[] args)
        {
            TV tv = new TV("LG","DC");
            tv.SetSoundSystem("Dolby");
            tv.Log();
        }
    }
}
