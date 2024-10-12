using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Single_Inheritance
{
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("eating…");
        }

        public virtual void PrintAnimal()
        {
            Console.WriteLine("I am an animal!");
        }
    }
}