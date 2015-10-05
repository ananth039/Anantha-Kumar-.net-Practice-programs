using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VechicleFactory
{
   public  class Bike:IWork
    {


        public void start()
        {
            Console.WriteLine("Bike Engine started");
        }
        public void Run()
        {
            Console.WriteLine("drive");
        }
        
        public void stop()
        {
            Console.WriteLine("Bike Engine is stopped");
        }

     
        public void seatCapability()
        {
            Console.WriteLine("Bike Specyifications");
            Console.WriteLine("Bike has 2 seats avaialbilty");
        }
        public void NumberOfWheels()
        {
            Console.WriteLine("Bike has 2 wheels");
        }
    }
}
