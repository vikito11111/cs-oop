using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Vehicles_Extension
{
    public class Truck : Vehicle
    {
        private const double AirConditionAdditionConsumption = 1.6;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            FuelConsumption += AirConditionAdditionConsumption;
        }

        public override void Refuel(double fuel)
        {
            if (FuelQuantity + fuel > TankCapacity)
            {
                throw new InvalidOperationException($"Cannot fit {fuel} fuel in the tank");
            }

            fuel *= 0.95;

            base.Refuel(fuel);
        }
    }
}