using System;

namespace DemoProxy
{
    public abstract class IoTLightBulb
    {
        public abstract void TurnOn();
        public abstract void TurnOff();
    }

    public class LightBulb : IoTLightBulb
    {
        private string Color { get; set; }
        private bool status;
        public bool Status
        {
            get { return status; }
        }

        public LightBulb()
        {
            Color = "WHITE";
            status = false;
        }

        
        public LightBulb(string color)
        {
            Color = color;
            status = false;
        }

        public override void TurnOn()
        {
            if (status == true)
                Console.WriteLine("Already ON");
            else 
            {
                status = true;
                Console.WriteLine("Bulb is ON with color " + Color);
            }
        }
        public override void TurnOff()
        {
            if (status == false)
                Console.WriteLine("Already OFF");
            else
            {
                Console.WriteLine("Bulb is OFF");
                status = false;
            }
        }
    }
}