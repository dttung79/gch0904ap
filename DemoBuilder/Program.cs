using System;

namespace DemoBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowRoom fpt = new ShowRoom();
            Computer c = fpt.BuildComputer();

            Console.WriteLine("Your computer:");
            Console.WriteLine(c);
        }
    }
}
