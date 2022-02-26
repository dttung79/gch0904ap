using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoStrategy
{
    public class RSPGame
    {
        private Player player1;
        private Player player2;
        
        public RSPGame()
        {
            player1 = new Human("Human");
            player2 = new Computer(GetStrategy());
        }

        private ChooseStrategy GetStrategy()
        {
            Random r = new Random(DateTime.Now.Millisecond);
            int s = r.Next(1, 3);
            ChooseStrategy stg;
            if (s == 1) stg = new RandomStrategy();
            else stg = new ContinuousStrategy();

            return stg;
        }

        public void Play()
        {
            System.Console.WriteLine("Player 1: " + player1.Name);
            System.Console.WriteLine("Player 2: " + player2.Name);

            for (int i = 0; i < 10; i++)
            {
                string choice1 = player1.Choose();
                string choice2 = player2.Choose();

                int whoWin = Compare(choice1, choice2);
                if (whoWin == 1)
                {
                    Console.WriteLine(player1.Name + " wins this round!");
                    player1.IncreaseScore();
                }
                else if (whoWin == 2)
                {
                    Console.WriteLine(player2.Name + " wins this round!");
                    player2.IncreaseScore();
                }
                else 
                {
                    Console.WriteLine("Draw round!");
                }
            }
            Console.WriteLine(player1.Name + " score: " + player1.Score);
            Console.WriteLine(player2.Name + " score: " + player2.Score);

            if (player1.Score > player2.Score)
                Console.WriteLine(player1.Name + " wins total game!");
            else if (player1.Score < player2.Score)
                Console.WriteLine(player2.Name + " wins total game!");
            else
                Console.WriteLine("Dram game!");
        }

        private int Compare(string choice1, string choice2)
        {
            if (choice1 == choice2) return 0; // draw

            if ((choice1 == "Rock" && choice2 == "Scissor") ||
                (choice1 == "Scissor" && choice2 == "Paper") ||
                (choice1 == "Paper" && choice2 == "Rock")) return 1;
            else return 2;

        }

    }
}