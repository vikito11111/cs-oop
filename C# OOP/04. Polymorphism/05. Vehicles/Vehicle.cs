using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Vehicles
{
    public abstract class Vehicle
    {
        private double fuelQuantity;

        private double fuelConsumption;

        protected Vehicle(double fuelQuantity, double fuelConsumption)
        {
            FuelQuantity = fuelQuantity;

            FuelConsumption = fuelConsumption;
        }

        //TODO: add validation

        public double FuelQuantity
        {
            get 
            { 
                return fuelQuantity; 
            }
            protected set
            {
                fuelQuantity = value; 
            }
        }

        public double FuelConsumption
        {
            get
            {
                return fuelConsumption;
            }
            protected set
            {
                fuelConsumption = value;
            }
        }

        public bool Drive(double distance)
        {
            bool canDrive = FuelQuantity - FuelConsumption * distance >= 0;

            if (canDrive)
            {
                FuelQuantity -= FuelConsumption * distance;

                return true;
            }

            //throw new InvalidOperationException();

            return false;
        }

        public virtual void Refuel(double fuel)
        {
            FuelQuantity += fuel;
        }
    }
}