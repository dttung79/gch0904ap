using System;

namespace DemoProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            LightBulb bulb = new LightBulb("YELLOW");

            System.Console.WriteLine("Connect bulb at home.");
            LightBulbControl bulbControl = new LightBulbControl("HOME");
            bulbControl.ConnectBulb(bulb);

            bulbControl.TurnOn();
            bulbControl.TurnOff();

            System.Console.WriteLine("Connect bulb from remote");
            System.Console.WriteLine("Config proxy");
            LightBulbControl remoteBulbControl = new LightBulbControl("REMOTE");
            remoteBulbControl.ConnectBulb(bulb);

            System.Console.WriteLine("Control bulb via proxy");
            remoteBulbControl.TurnOn();
            remoteBulbControl.TurnOff();
        }
    }
}
