using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Hierarchical_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();

            dog.Bark();

            dog.Eat();

            Cat cat = new Cat();

            cat.Eat();

            cat.Meow();

            Console.ReadLine();
        }
    }
}