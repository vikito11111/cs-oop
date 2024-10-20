using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Vehicles
{
    public class Engine
    {
        public void Run()
        {
            string[] carInfo = Console.ReadLine()
                .Split(' ')
                .ToArray();

            string[] truckInfo = Console.ReadLine()
                .Split(' ')
                .ToArray();

            double carFuelQuantity = double.Parse(carInfo[1]);

            double carFuelConsumption = double.Parse(carInfo[2]);

            double truckFuelQuantity = double.Parse(truckInfo[1]);

            double truckFuelConsumption = double.Parse(truckInfo[2]);

            Car car = new Car(carFuelQuantity, carFuelConsumption);

            Truck truck = new Truck(truckFuelQuantity, truckFuelConsumption);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commandInfo = Console.ReadLine()
                    .Split(' ')
                    .ToArray();

                string command = commandInfo[0];

                string vehicleType = commandInfo[1];

                double value = double.Parse(commandInfo[2]);

                if (command == "Drive")
                {
                    if (vehicleType == "Car")
                    {
                        DriveVehicle(car, value);
                    }
                    else if (vehicleType == "Truck")
                    {
                        DriveVehicle(truck, value);
                    }
                }
                else if (command == "Refuel")
                {
                    if (vehicleType == "Car")
                    {
                        car.Refuel(value);
                    }
                    else if (vehicleType == "Truck")
                    {
                        truck.Refuel(value);
                    }
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");

            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");

            //{Math.Round(car.FuelQuantity, 2, MidpointRounding.AwayFromZero):f2}
        }

        void DriveVehicle(Vehicle vehicle, double value)
        {
            bool canTravell = vehicle.Drive(value);

            string result = !canTravell
                ? $"{vehicle.GetType().Name} needs refueling" 
                : $"{vehicle.GetType().Name} travelled {value} km";

            Console.WriteLine(result);
        }
    }
}