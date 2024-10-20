using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Vehicles
{
    public class Truck : Vehicle
    {
        private const double AirConditionAdditionConsumption = 1.6;

        public Truck(double fuelQuantity, double fuelConsumption) 
            : base(fuelQuantity, fuelConsumption)
        {
            FuelConsumption += AirConditionAdditionConsumption;
        }

        public override void Refuel(double fuel)
        {
            fuel *= 0.95;

            base.Refuel(fuel);
        }
    }
}