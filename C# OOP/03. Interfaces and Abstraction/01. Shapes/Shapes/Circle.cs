using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes.Shapes
{
    public class Circle : IDrawable
    {
        public Circle(int radius)
        {
            Radius = radius;
        }

        public int Radius { get; }

        public void Draw()
        {
            for (int row = 0; row <= Radius * 2; row++)
            {
                for (int col = 0; col <= Radius*2; col++)
                {
                    var distance = Math.Ceiling(Math.Sqrt((row - Radius) * (row - Radius) + (col - Radius) * (col - Radius)));

                    if (distance == Radius)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }

                Console.WriteLine();
            }
        }
    }
}