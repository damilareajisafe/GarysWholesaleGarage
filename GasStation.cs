using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
    public class GasStation:IStation<IGasVehicle>
    {
        public int Capacity { get; set; } = 5;

        public void Refuel(List<IGasVehicle> vehicles)
        {
            for (int i = 0; i < vehicles.Count; i++)
            {
                vehicles[i].RefuelTank();
                Console.WriteLine($"The {vehicles[i].GetType().Name} has been refueled with 200 gallons of gas");
            }
        }
    }
}
