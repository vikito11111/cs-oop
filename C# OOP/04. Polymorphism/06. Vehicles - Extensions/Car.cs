using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Vehicles_Extension
{
    public class Car : Vehicle
    {
        private const double AirConditionAdditionConsumption = 0.9;

        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            FuelConsumption += AirConditionAdditionConsumption;
        }
    }
}