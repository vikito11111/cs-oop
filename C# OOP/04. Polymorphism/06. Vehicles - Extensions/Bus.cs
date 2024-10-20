using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Vehicles_Extension
{
    public class Bus : Vehicle
    {
        private double airConditionAdditionConsumption = 1.4;

        private double defaultFuelConsumption;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            defaultFuelConsumption = fuelConsumption;

            airConditionAdditionConsumption += fuelConsumption;
        }

        public bool IsEmpty { get; set; }

        public override bool Drive(double distance)
        {
            if (!IsEmpty)
            {
                FuelConsumption = airConditionAdditionConsumption;
            }
            else
            {
                FuelConsumption = defaultFuelConsumption;
            }

            return base.Drive(distance);
        }
    }
}