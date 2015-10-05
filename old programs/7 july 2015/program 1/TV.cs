using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07july_01
{
    class TV
    {
        private string remote;
        private string powerSupply;
        private string soundSystem;

        public TV(string remote, string powerSupply)
        {
            this.remote = remote;
            this.powerSupply = powerSupply;
        }
        public void SetSoundSystem(string soundSystem)
        {
            this.soundSystem = soundSystem;
        }

        public string GetSoundSystem()
        {
            return this.soundSystem;
        }


        public void Log()
        {
            Console.WriteLine("Remote is {0}", remote);
            Console.WriteLine("Pwer Supply is {0}", powerSupply); 
            Console.WriteLine("Sound System is " + this.soundSystem);
            
           
        }

      
    }
}
