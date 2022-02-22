using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : Shape
    {
        protected int radius;
        public int Radius 
        {
            get { return radius; }
            set { radius = value; } // should validate
        }
        public Circle() : base("Circle")
        {
            Radius = 1;
        }
        public Circle(string name, int radius) : base(name)
        {
            Radius = radius; // should validate radius > 0 in set property
        }

        public override double Area
        {
            get { return 3.14 * Radius * Radius; }
        }

        public override void ShowInfo()
        {
            base.ShowInfo(); // call ShowInfo of Shape
            System.Console.WriteLine("Radius: " + Radius);
        }
    }
}