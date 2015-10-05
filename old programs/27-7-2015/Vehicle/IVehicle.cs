using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingStation
{
    public interface IVehicle
    {
        void SetEntryTime(int hours, int minutes);

        float GetParkingAmount(int leavingHours, int leavingMinutes);

        float ParkingAmountPerHour { get; }


    }
}
