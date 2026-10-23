using System;
using System.Collections.Generic;
using System.Text;
//using Garage;

namespace Garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }

        public virtual void Turn(string direction)
        {
            Console.WriteLine($"The vehicle takes a {direction} turn");
        }

        public virtual void Stop()
        {
            Console.WriteLine("The vehicle comes to a stop");
        }
    }
}
