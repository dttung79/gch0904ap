using System;

namespace DemoFactoryMethod
{
    public abstract class Tower
    {
        protected int level;
        public int Level
        {
            get { return level; }
        }
        public Tower()
        {
            level = 1;
        }
        public void Upgrade()
        {
            level++;
        }
        public abstract void Shot();
    }
}