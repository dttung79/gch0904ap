using System;
using System.Collections.Generic;

namespace DemoFactoryMethod
{
    public abstract class Stage
    {
        protected List<Tower> towers;

        public Stage()
        {
            towers = new List<Tower>();
        }

        protected abstract Tower CreateTower();

        public void Upgrade()
        {
            foreach (Tower t in towers)
            {
                t.Upgrade();
            }
        }

        public void PlaceTowers()
        {
            System.Console.Write("Number of towers: ");
            int nTowers = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < nTowers; i++)
            {
                //Tower t = new Tower(); // Cannot initiate object of abstract class!!!
                Tower t = CreateTower();
                towers.Add(t);
            }
            Shot();
        }
        public void Shot()
        {
            foreach(Tower t in towers)
            {
                t.Shot();
            }
        }

    }
    public class RockStage : Stage
    {
        public RockStage() : base() {}
        
        protected override Tower CreateTower()
        {
            return new RockTower();
        }
    }
    public class ArrowStage : Stage
    {
        public ArrowStage() {}
        protected override Tower CreateTower()
        {
            return new ArrowTower();
        }
    }
}