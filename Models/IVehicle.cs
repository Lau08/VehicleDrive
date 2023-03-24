using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleDrive.Models
{
    internal interface IVehicle
    {
        public abstract void Drive();
        public abstract bool Refuel(int fuelAmount);

    }
}
