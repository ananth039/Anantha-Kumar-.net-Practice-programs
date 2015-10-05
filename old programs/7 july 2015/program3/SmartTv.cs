using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program3
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
        public string SoundSystem
        {
            get
            {
                return this.soundSystem;
            }
            set
            {
                this.soundSystem = value;
            }
        }

        public string InternetConnectivity
        {
            get
            {
                return this.internetConnectivity;
            }
            set
            {
                this.internetConnectivity = value;
            }
        }
        public void Log()
        {
            Console.WriteLine("Remote is {0}", remote);
            Console.WriteLine("Pwer Supply is {0}", powerSupply);
            Console.WriteLine("Sound System is " + this.SoundSystem);
            Console.WriteLine("InternetConnectivity is " + this.internetConnectivity);

        }
       
    }
}
