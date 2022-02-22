using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle : Shape
    {
        public int SideA {get; set;}
        public int SideB {get; set;}
        public int SideC {get; set;}

        public Triangle() : base("Triangle")
        {
            SideA = 3;
            SideB = 4;
            SideC = 5;
        }
        public Triangle(string name, int a, int b, int c) : base(name)
        {
            SideA = a; SideB = b; SideC = c;
        }

        public override double Area
        {
            get
            {
                double p = (SideA + SideB + SideC) / 2.0;
                double s = Math.Sqrt(p*(p-SideA) * (p-SideB) * (p-SideC));
                return s;
            }
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            System.Console.WriteLine("3 sides: (" + SideA, ", " + SideB + ", " + SideC + ")");
        }

    }
}