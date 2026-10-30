using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
    public class BatteryStation: IStation<IElectricVehicle>
    {
        public int Capacity { get; set; } = 5;

        public void Refuel(List<IElectricVehicle> vehicles)
        {
            for (int i = 0; i < vehicles.Count; i++)
            {
                vehicles[i].ChargeBattery();
                Console.WriteLine($"The {vehicles[i].GetType().Name} has been fully recharged with 200KWh of power");
            }
        }
    }
}
