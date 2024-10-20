using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Vehicles
{
    public class Car : Vehicle
    {
        private const double AirConditionAdditionConsumption = 0.9;

        public Car(double fuelQuantity, double fuelConsumption) 
            : base(fuelQuantity, fuelConsumption)
        {
            FuelConsumption += AirConditionAdditionConsumption;
        }
    }
}