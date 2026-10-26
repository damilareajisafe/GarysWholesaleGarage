using System;
using System.Collections.Generic;
using System.Text;
//using Garage;

namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle  // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public int CurrentChargePercentage { get; set; } = 30;

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} {this.GetType().Name} zips past you. Zooooooom!");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {this.GetType().Name} silently comes to a halt.");
        }
    }
}
