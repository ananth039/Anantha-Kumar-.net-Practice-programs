using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Smarttv
    {
         private string remote;
        private string powersupply;
        public Smarttv():this("LG","AC")
    {

    }
      public Smarttv(string remote)
        {
            this.remote = remote;
            this.powersupply = "AC";
        }
       
        public Smarttv(string remote,string powersupply) 
        {
            
            this.remote = remote;
            this.powersupply = powersupply;

        }
        public void display()
        {
            Console.WriteLine("Remote is {0}", remote);
            Console.WriteLine("powersupply is {0}", powersupply);
        }
    }
}
