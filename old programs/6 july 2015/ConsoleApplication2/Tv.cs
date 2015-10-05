using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Tv
    {
        private string remote;
        private string powersupply;
        public Tv()
        {
            powersupply = "AC";
            remote = "LG";
        }
        public Tv(string remote)
        {
            this.remote = remote;
            this.powersupply = "AC";
        }
       
        public Tv(string powersupply,string remote) 
        {
            this.powersupply = powersupply;
            this.remote = remote;   

        }
        public void log()
        {
            Console.WriteLine("Remote is {0}", remote);
            Console.WriteLine("powersupply is {0}", powersupply);
        }
    }
}
