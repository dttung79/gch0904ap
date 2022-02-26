using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoBuilder
{
    public abstract class ComputerBuilder
    {
        public abstract void Build(Computer comp);
    }

    public class MonitorBuilder : ComputerBuilder
    {
        public override void Build(Computer comp)
        {
            Console.WriteLine("Build Monitor");
            Console.Write("Enter monitor brand: ");
            string brand = Console.ReadLine();

            Console.Write("Enter monitor size: ");
            int size = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter monitor freq: ");
            int freq = Convert.ToInt32(Console.ReadLine());

            Monitor m = new Monitor(brand, size, freq);
            comp.CompMonitor = m;
        }
    }

    public class CaseBuilder : ComputerBuilder
    {
        public override void Build(Computer comp)
        {
            Console.WriteLine("Build Case");
        

            Console.Write("Enter CPU: ");
            double cpu = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Ram: ");
            int ram = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter hard drive: ");
            int drive = Convert.ToInt32(Console.ReadLine());

            Case c = new Case(cpu, ram, drive);
            comp.CompCase = c;
        }
    }
}