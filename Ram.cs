using System;
using System.Collections.Generic;
using System.Text;
//using Garage;


namespace Garage
{
    public class Ram : Vehicle, IGasVehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public int CurrentTankPercentage { get; set; } = 25;

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} {this.GetType().Name} drives past you. Vroooooom!");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {this.GetType().Name} rolls to a halt.");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} {this.GetType().Name} takes a hard {direction}");
        }
    }
}
