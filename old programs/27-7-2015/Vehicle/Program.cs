using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingStation
{
    class Program
    {
        private static IEnumerable<IVehicle> vehicles;
        private static bool vechicle;
        static void Main(string[] args)
        {
            ParkingStation parkingStation = new ParkingStation();
            IVehicle bike = new Bike();
            bike.SetEntryTime(6, 0);
            parkingStation.AddVehicle(bike);

            IVehicle cycle = new Bicycle();
            cycle.SetEntryTime(7, 0);
            parkingStation.AddVehicle(cycle);
            IVehicle cycle1 = new Bicycle();
            cycle1.SetEntryTime(4, 0);
            parkingStation.AddVehicle(cycle1);

            IVehicle car = new Car();
            car.SetEntryTime(10, 0);
            parkingStation.AddVehicle(car);
          IVehicle car1=new Car();
            car1.SetEntryTime(8, 0);
            parkingStation.AddVehicle(car1);

            parkingStation.DisplayVehicleBills();
            parkingStation.NumberOfVechicles();
        }       
    }
}

 