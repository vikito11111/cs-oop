using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes.Shapes
{
    public class Rectangle : IDrawable
    {
        public Rectangle(int width, int height)
        {
            Width = width;

            Height = height;
        }

        public int Width { get; }

        public int Height { get; }

        public void Draw()
        {
            Console.WriteLine(new string('*', Width));

            for (int i = 0; i < Height - 2; i++)
            {
                Console.WriteLine("*" + new string(' ', Width - 2) + "*");
            }

            Console.WriteLine(new string('*', Width));
        }
    }
}