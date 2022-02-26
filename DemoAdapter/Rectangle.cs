using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAdapter
{
    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle()
        {
            Width = 8;
            Height = 2;
        }

        public Rectangle(int w, int h)
        {
            Width = w;
            Height = h;
        }
        public override void Draw()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }

        
    }
}