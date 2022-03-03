using System;

namespace DemoObserver
{
    public abstract class Observer
    {
        protected SaleData data;
        public Observer(SaleData data)
        {
            this.data = data;
        }

        public abstract void Update();
    }

    public class DataTable : Observer
    {
        public DataTable(SaleData data) : base(data) {}

        public override void Update()
        {
            Console.WriteLine(String.Format("{0, -5}{1, -10}{2, -10}", "No", "Product", "Sales"));
            Console.WriteLine(String.Format("{0, -5}{1, -10}{2, -10}", "1", "Mobiles", data.Mobiles));
            Console.WriteLine(String.Format("{0, -5}{1, -10}{2, -10}", "2", "PCs", data.PCs));
            Console.WriteLine(String.Format("{0, -5}{1, -10}{2, -10}", "3", "Tablets", data.Tablets));
        }
    }
    public class DataChart : Observer
    {
        public DataChart(SaleData data) : base(data) {}

        public override void Update()
        {
            Console.WriteLine("Sale Chart");
            DrawBar("Mobile", data.Mobiles);
            DrawBar("PCs", data.PCs);
            DrawBar("Tablets", data.Tablets);
        }

        private void DrawBar(string product, int sales)
        {
            Console.Write(String.Format("{0, -10}{1}", product, ": "));
            int n = sales / 10;
            for (int i = 0; i < n; i++) Console.Write("=");
            Console.WriteLine();
        }
    }
}