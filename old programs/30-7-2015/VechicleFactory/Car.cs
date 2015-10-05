using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VechicleFactory
{
    public class Car:IWork,IVechicleSpecialization
    {
       
        public void start()
        {
            Console.WriteLine("car Engine is started");
        }

        public void Run()
        {
            Console.WriteLine("Drive");
        }

        public void stop()
        {
            Console.WriteLine("Car Engine is stopped");
        }

        public void steeringCapability()
        {
            Console.WriteLine("Car has steering compatiability");
        }

        public void seatCapability()
        {
            Console.WriteLine("Car has 6 seats available");
        }

        public void NumberOfWheels()
        {
            Console.WriteLine("Car has 4 wheels");
        }
    }
}
