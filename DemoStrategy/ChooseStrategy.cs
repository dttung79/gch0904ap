using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoStrategy
{
    public abstract class ChooseStrategy
    {
        public abstract string ChooseAlgorithm();
    }

    public class RandomStrategy : ChooseStrategy
    {
        public override string ChooseAlgorithm()
        {
            Random r = new Random(DateTime.Now.Millisecond);
            int choice = r.Next(1, 4);
            if (choice == 1) return "Rock";
            else if (choice == 2) return "Scissor";
            else return "Paper";
        }
    }

    public class ContinuousStrategy : ChooseStrategy
    {
        private string lastChoice;
        public ContinuousStrategy()
        {
            lastChoice = "Rock";
        }
        public override string ChooseAlgorithm()
        {
            if (lastChoice == "Rock") 
                lastChoice = "Scissor";
            else if (lastChoice == "Scissor") lastChoice = "Paper";
            else lastChoice =  "Rock";

            return lastChoice;
        }
    }
}