﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Single_Inheritance
{
    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("barking…"); 
        }

        public override void PrintAnimal()
        {
            Console.WriteLine("I am a dog!");
        }
    }
}