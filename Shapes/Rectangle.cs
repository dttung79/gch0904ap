using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shape
    {
        public int Width {get; set;}
        public int Height {get; set;}
        public Rectangle() : base("Rectangle")
        {
            Width = 2;
            Height = 1;
        }
        public Rectangle(string name, int w, int h) : base(name)
        {
            Width = w;
            Height = h;
        }

        public override double Area
        {
            get { return Width * Height; }
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            System.Console.WriteLine("Width: " + Width + ", Height: " + Height);
        }
    }

}