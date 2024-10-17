using _01.Shapes.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            IDrawable drawable1 = new Circle(15);

            drawable1.Draw();

            IDrawable drawable2 = new Rectangle(16, 4);

            drawable2.Draw();

            Console.ReadLine();
        }
    }
}