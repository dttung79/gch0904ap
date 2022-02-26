using System;

namespace DemoAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[3];
            shapes[0] = new Line(5);
            shapes[1] = new TextShape("Design Pattern");
            shapes[2] = new Rectangle();

            for (int i = 0; i < shapes.Length; i++)
            {
                shapes[i].Draw();
                System.Console.WriteLine();
            }
        }
    }
}
