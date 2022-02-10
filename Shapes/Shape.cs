using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        public string Name {get; set;}
        public Shape()
        {
            Name = "Shape";
        }

        public Shape(string name)
        {
            Name = name; // should validate empty name
        }

        // C1: viet Area duoi dang ham
        // public double Area()
        // {
        //     return 0.0;
        // }
        // C2: viet Area duoi dang property
        public abstract double Area
        {
            get;
        } 

        public virtual void ShowInfo()
        {
            System.Console.WriteLine("Name: " + Name + ", Area: " + Area);
        }
    }
}