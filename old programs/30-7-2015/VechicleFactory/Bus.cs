using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VechicleFactory
{
 public class Bus:IWork,IVechicleSpecialization
    {
     

     public void start()
     {
         Console.WriteLine(" Bus Engine is started");
     }
     public void Run()
     {
         Console.WriteLine("Drive");
     }
     public void stop()
     {
         Console.WriteLine(" Bus Engine is stopped");
     }

     public void steeringCapability()
     {
         Console.WriteLine("Bus has steering");
     }

     public void seatCapability()
     {
         Console.WriteLine("Bus has 51 Seats available");
     }

     public void NumberOfWheels()
     {
         Console.WriteLine("6 wheels");
     }
    }
}
