﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat("Pesho", "Whiskas");

            Animal dog = new Dog("Gosho", "Meat");

            Console.WriteLine(cat.ExplainSelf());

            Console.WriteLine(dog.ExplainSelf());

            Console.ReadLine();
        }
    }
}