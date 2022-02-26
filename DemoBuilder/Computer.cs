using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoBuilder
{
    public class Monitor
    {
        public string Brand { get; set; }
        public int Size { get; set; }
        public int Frequency { get; set; }

        public Monitor(string brand, int size, int freq)
        {
            Brand = brand;
            Size = size;
            Frequency = freq;
        }

        public override string ToString()
        {
            return "Monitor " + Brand + " " + Size + "\"" + " " + Frequency + "Hz";
        }
    }

    public class Case 
    {
        public double CPU { get; set; }
        public int Ram { get; set; }
        public int Drive { get; set; }

        public Case(double cpu, int ram, int drive)
        {
            CPU = cpu; Ram = ram; Drive = drive;
        }

        public override string ToString()
        {
            return "Case CPU : " + CPU + "GHz, RAM: " + Ram + "Gb, Drive: " + Drive + "Gb";
        }
    }
    public class Computer
    {
        public Monitor CompMonitor { get; set; }
        public Case CompCase { get; set; }

        public override string ToString()
        {
            return CompMonitor + "\n" + CompCase;
        }
    }
}