using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoStrategy
{
    public class Computer : Player
    {
        private ChooseStrategy strategy;

        public Computer(ChooseStrategy strategy) : base("Computer")
        {
            this.strategy = strategy;
        }
        
        public override string Choose()
        {
            Console.WriteLine("Computer is thingking ...");
            string choice = strategy.ChooseAlgorithm();
            Console.WriteLine("Computer chooses: " + choice);
            return choice;
        }
    }
}