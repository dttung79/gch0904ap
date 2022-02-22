using System;

namespace DemoFactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Stage s;
            System.Console.Write("Choose your stage: (1: Rock, 2: Arrow): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1) s = new RockStage();
            else s = new ArrowStage();

            s.PlaceTowers();
            for (int i = 0; i < 5; i++)
            {
                s.Shot();
                s.Upgrade();
            }
        }
    }
}
