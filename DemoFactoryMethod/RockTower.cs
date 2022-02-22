using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoFactoryMethod
{
    public class RockTower : Tower
    {
        public RockTower() : base()
        {
        }
        public override void Shot()
        {
            string bullet = "";
            switch (level)
            {
                case 1: bullet = "."; break;
                case 2: bullet = "*"; break;
                case 3: bullet = "o"; break;
                case 4: bullet = "0"; break;
                default: bullet = "()"; break;
            }
            for (int i = 0; i < 10; i++)
            {
                System.Console.Write(bullet);
            }
            System.Console.WriteLine();
        }

    }
}