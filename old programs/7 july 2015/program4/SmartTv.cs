using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program4
{
    class SmartTv
    {
        private string remote;
        private string powerSupply;
        private string soundSystem;
        private String internetConnectivity;
        public SmartTv(string remote, string powerSupply)
        {
            this.remote = remote;
            this.powerSupply = powerSupply;
        }
        public string SoundSystem { set; get; }
        public string InternetConnectivity{ set; get; }
        public void Log()
        {
            Console.WriteLine("Remote is {0}", remote);
            Console.WriteLine("Pwer Supply is {0}", powerSupply);
            Console.WriteLine("Sound System is " + this.SoundSystem);
            Console.WriteLine("InternetConnectivity is " + this.InternetConnectivity);

        }
    }
}
