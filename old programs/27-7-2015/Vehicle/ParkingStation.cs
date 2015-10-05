using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingStation
{
    class ParkingStation
    {
        IList<IVehicle> vehicles = new List<IVehicle>(1);

        public void AddVehicle(IVehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public void DisplayVehicleBills()
        {
            foreach(IVehicle vehicle in vehicles)
            {
                Console.WriteLine(" The Parking amount is " + vehicle.GetParkingAmount(14, 50));
                Console.WriteLine("");
            }
        }


        int car1 = 0;
        int count2 = 0;
        int bike2 = 0;
      
        public  void NumberOfVechicles()
        {
            foreach (IVehicle vehicle in vehicles)
            {
                if (vehicle is Bike)
                {

                  bike2++;
                }
               
                if (vehicle is Bicycle)
                {
                   
                  count2++;

                }
                if (vehicle is Car)
                {

                    car1++;

                } 
            }
            Console.WriteLine("");
            Console.WriteLine("Number Of Vechicles :{0}", vehicles.Count);
            Console.WriteLine("");

            Console.WriteLine("Number of Bicycles are: {0}", count2);
            Console.WriteLine("Number of Bikes are: {0}", bike2);
            Console.WriteLine("Number of cars are: {0}", car1);
            Console.WriteLine(""); 
        }
    }
}
