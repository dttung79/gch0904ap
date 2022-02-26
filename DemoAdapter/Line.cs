using System;
using System.Collections.Generic;

namespace DemoAdapter
{
    public class Line : Shape
    {
        public int Length
        {
            get; set;
        }
        
        public Line()
        {
            Length = 10;
        }
        public Line(int length)
        {
            Length = length;
        }

        public override void Draw()
        {
            for (int i = 0; i < Length; i++)
            {
                Console.Write("-");
            }
            System.Console.WriteLine();
        }
    }
}