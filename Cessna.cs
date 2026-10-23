using System;
using System.Collections.Generic;
using System.Text;
//using Garage;

namespace Garage
{
    public class Cessna : Vehicle // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {

        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} {this.GetType().Name} blasts past you. Boooooooom!");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {this.GetType().Name} lands on the runway.");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} {this.GetType().Name} banks {direction}");
        }
    }
    
}

