using System;
using System.Collections.Generic;

namespace Shapes
{
    public class ShapeProgram : MenuProgram
    {
        private List<Shape> listShapes;

        public ShapeProgram()
        {
            listShapes = new List<Shape>();
        }
        protected override void PrintMenu()
        {
            System.Console.WriteLine("~~~~~~ DEMO SHAPES ~~~~~~");
            System.Console.WriteLine("1. Add Rectangle.");
            System.Console.WriteLine("2. Add Square.");
            System.Console.WriteLine("3. Add Triangle.");
            System.Console.WriteLine("4. Show All Shapes.");
            System.Console.WriteLine("0. Quit program.");
        }
        protected override void DoTask(int choice)
        {
            switch(choice)
            {
                case 1 : AddRectangle(); break;
                case 2 : AddSquare();    break; // TODO
                case 3 : AddTriangle();  break; // TODO
                case 4 : ShowAll();      break; // TODO
                case 0 :                 break;
                default: ShowError();    break; // TODO
            }
        }

        private void AddRectangle()
        {
            System.Console.WriteLine("Add rectangle information");
            System.Console.Write("Enter name: ");
            string name = Console.ReadLine();
            System.Console.Write("Enter width: ");
            int width = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Enter height: ");
            int height = Convert.ToInt32(Console.ReadLine());

            Rectangle r = new Rectangle(name, width, height);
            listShapes.Add(r);

            System.Console.WriteLine("Rectangle added successful!");
        }
        private void AddTriangle()
        {
            // TODO
        }
        private void AddSquare()
        {
            // TODO
        }
        private void ShowAll()
        {
            // TODO
        }
        private void ShowError()
        {
            // TODO
        }

    }
}