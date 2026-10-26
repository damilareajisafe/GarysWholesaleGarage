using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
    public interface IGasVehicle
    {
        int CurrentTankPercentage { get; set; }

        void RefuelTank();
    }
}
