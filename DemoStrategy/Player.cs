using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoStrategy
{
    public abstract class Player
    {
        public string Name { get; set; }
        
        private int score;

        public int Score
        {
            get { return score; }
        }

        public Player(string name)
        {
            Name = name;
            score = 0;
        }

        public void IncreaseScore()
        {
            score++;
        }

        public abstract string Choose();
    }
}