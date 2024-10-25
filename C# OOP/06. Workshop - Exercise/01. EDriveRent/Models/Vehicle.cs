using EDriveRent.Models.Contracts;
using EDriveRent.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EDriveRent.Models
{
    public abstract class Vehicle : IVehicle
    {
        private string brand;
        private string model;
        private double maxMileage;
        private string licensePlateNumber;
        private int batteryLevel;
        private bool isDamaged;

        protected Vehicle(string brand, string model, double maxMileage, string licensePlateNumber)
        {
            Brand = brand;
            Model = model;
            MaxMileage = maxMileage;
            LicensePlateNumber = licensePlateNumber;
            BatteryLevel = 100;
        }

        public string Brand
        {
            get => brand; 
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.BrandNull);
                }

                brand = value;
            }
        }

        public string Model
        {
            get => model;
            private set
            {
                model = value;
            }
        }

        public double MaxMileage
        {
            get => maxMileage;
            private set
            {
                maxMileage = value;
            }
        }

        public string LicensePlateNumber
        {
            get => licensePlateNumber;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.LicenceNumberRequired);
                }

                licensePlateNumber = value;
            }
        }

        public int BatteryLevel
        {
            get => batteryLevel;
            private set
            {


                batteryLevel = value;
            }
        }

        public bool IsDamaged
        {
            get => isDamaged; 
            private set
            {
                isDamaged = value;
            }
        }

        public void ChangeStatus()
        {
            IsDamaged = IsDamaged ? false : true;
        }

        public void Drive(double mileage)
        {
            BatteryLevel -= (int)Math.Round(mileage / MaxMileage * 100);

            if (this.GetType() == typeof(CargoVan))
            {
                this.BatteryLevel -= 5;
            }
        }

        public void Recharge()
        {
            BatteryLevel = 100;
        }

        public override string ToString()
        {
            return $"{Brand} {Model} License plate: {LicensePlateNumber} Battery: {BatteryLevel}% Status: {(IsDamaged ? "damaged" : "OK")}";
        }
    }
}
