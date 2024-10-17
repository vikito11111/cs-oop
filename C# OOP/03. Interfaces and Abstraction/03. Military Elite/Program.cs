using _07.Military_Elite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Military_Elite
{
    class Program
    {
        static void Main(string[] args)
        {
            ICommandInterpreter command = new CommandInterpreter();

            IEngine engine = new Engine(command);

            engine.Run();

            Console.ReadLine();
        }
    }
}