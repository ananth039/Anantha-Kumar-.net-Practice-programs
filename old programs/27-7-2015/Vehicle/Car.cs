using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingStation
{
  public   class Car:IVehicle
    {
       private float parkingAmount;
        private int hours;
        private int minutes;
        public Car()
        {
            parkingAmount = 50;
        }
        public void SetEntryTime(int hours, int minutes)
        {
            this.hours = hours;
            this.minutes = minutes;
        }

        public float GetParkingAmount(int leavingHours, int leavingMinutes)
        {
            return (leavingHours - hours) * parkingAmount;
        }

        public float ParkingAmountPerHour
        {
            get { return parkingAmount; }
        }
    }
    }
