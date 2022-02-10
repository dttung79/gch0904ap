using System;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Shape s = new Shape();
            // s.ShowInfo();
            // Circle c = new Circle("Circle O", 3);
            // c.ShowInfo();

            Shape[] listShapes = {new Shape(), new Circle(), new Circle("01", 5)};
            foreach(Shape s in listShapes)
            {
                s.ShowInfo();
            }
        }
    }
}
