using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleDrive.Models
{
    internal class Car : IVehicle
    {
        private int fuelAmount;

        public Car(int fuelAmount)
        {
            this.fuelAmount = fuelAmount;
        }
        public void Drive()
        {
            if (fuelAmount > 0)
            {
                Console.WriteLine("The car is driving: ");
            }
            else
            {
                Console.WriteLine("Car out of fuel...");
            }
        }

        public bool Refuel(int fuelAmount)
        {
            this.fuelAmount += fuelAmount;
            return true;
        }

        public void SetFuel(int fuelAmount)
        {
            this.fuelAmount = fuelAmount;
        }

        public int GetFuel()
        {
            return this.fuelAmount;
        }
    }
}
