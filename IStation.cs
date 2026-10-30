using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
    public interface IStation<T>
    {
        int Capacity { get; set; }

        void Refuel(List<T> vehicles);
    }
}
