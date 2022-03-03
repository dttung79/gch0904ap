using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoObserver
{
    public class SaleData
    {
        private int mobiles;
        public int Mobiles 
        {
            get { return mobiles; }
        }
        private int pcs;

        public int PCs 
        {
            get { return pcs; }
        }
        private int tablets;

        public int Tablets 
        {
            get { return tablets; }
        }
        private List<Observer> observers;

        public SaleData(int mobiles, int pcs, int tablets)
        {
            mobiles = pcs = tablets = 0;
            observers = new List<Observer>();
            ChangeData(mobiles, pcs, tablets);
        }
        public void ChangeData(int mobiles, int pcs, int tablets)
        {
            this.mobiles += mobiles;
            this.pcs += pcs;
            this.tablets += tablets;
            Notify(); // notify to observers, tell them to update
        }

        public void Notify()
        {
            foreach (Observer ob in observers)
            {
                ob.Update();
            }
        }

        public void Attach(Observer ob) 
        {
            observers.Add(ob);
        }

        public void Dettach(Observer ob)
        {
            observers.Remove(ob);
        }
        
    }
}