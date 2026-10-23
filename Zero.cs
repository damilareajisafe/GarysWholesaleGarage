using System;
using System.Collections.Generic;
using System.Text;
//using Garage;

namespace Garage
{
    public class Zero : Vehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {

        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} {this.GetType().Name} speeds past you. zoom zoooom!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} {this.GetType().Name} zips {direction}");
        }
    }
}
