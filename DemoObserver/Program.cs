using System;

namespace DemoObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            // create subject
            SaleData fptshop = new SaleData(0, 0, 0);
            // create observers
            DataTable table = new DataTable(fptshop);
            DataChart chart = new DataChart(fptshop);
            // attach observers to subject
            fptshop.Attach(table);
            fptshop.Attach(chart);

            int n = 2;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter mobile sales: ");
                int mobiles = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter PC sales: ");
                int pcs = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter tablet sales: ");
                int tablets = Convert.ToInt32(Console.ReadLine());
                fptshop.ChangeData(mobiles, pcs, tablets);
            }
        }
    }
}
