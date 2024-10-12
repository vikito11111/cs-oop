using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Single_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();

            dog.Bark();

            dog.Eat();

            Animal animal = new Animal();

            animal.PrintAnimal();

            dog.PrintAnimal();

            Console.ReadLine();
        }
    }
}