﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine();

            engine.Run();

            Console.ReadLine();
        }
    }
}