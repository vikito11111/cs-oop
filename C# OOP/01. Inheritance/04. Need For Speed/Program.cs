using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Need_For_Speed
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle(300, 100);

            Vehicle car = new Car(300, 100);

            vehicle.Drive(10);

            car.Drive(10);

            Console.WriteLine(vehicle.Fuel);

            Console.WriteLine(car.Fuel);

            Console.ReadLine();
        }
    }
}