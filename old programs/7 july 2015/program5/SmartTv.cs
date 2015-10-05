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
       
        public void Log()
        {
           Log(true, true, true,true);

        }
        public void Log(bool isRemote, bool isPowerSupply, bool isSoundSystem, bool isInternetConnectivity)
        {
            if (isRemote)
            {
                Console.WriteLine("Remote is {0}", remote);
            }
            if (isPowerSupply)
            {
                Console.WriteLine("Power Supply is {0}", powerSupply);
            }
            if (isSoundSystem)
            {
                Console.WriteLine("Sound System is " + this.SoundSystem);
            }
            if (isInternetConnectivity)
            {
                Console.WriteLine("InternetConnectivity is " + this.InternetConnectivity);
            }
        }
        public void Log(bool isRemote)
        {
            Log(true, false, false,false);
        }
             public string SoundSystem { set; get; }
        public string InternetConnectivity{ set; get; }

    }
}
