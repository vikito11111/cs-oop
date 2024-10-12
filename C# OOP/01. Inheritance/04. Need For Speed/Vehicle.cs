using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Need_For_Speed
{
    public class Vehicle
    {
        private const double DefaultFuelConsumption = 1.25;

        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;

            Fuel = fuel;
        }

        public virtual double FuelConsumption => DefaultFuelConsumption;

        public int HorsePower { get; set; }

        public double Fuel { get; set; }

        public void Drive(double kilometers)
        {
            bool canDrive = Fuel - kilometers * FuelConsumption >= 0;

            if (canDrive)
            {
                Fuel -= kilometers * FuelConsumption;
            }
        }
    }
}