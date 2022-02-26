using System;

namespace DemoStrategy
{
    public class Human : Player
    {
        public Human(string name) : base(name)
        {}

        public override string Choose()
        {
            Console.Write("Your choice? (Rock/Scissor/Paper): ");
            string choice = Console.ReadLine();
            // TODO: validate choice

            Console.WriteLine("Human choose " + choice);
            return choice;
        }
    }
}