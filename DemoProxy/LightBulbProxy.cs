using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProxy
{
    public class LightBulbProxy : IoTLightBulb
    {
        private LightBulb bulb;
        private string username;
        private string password;

        public LightBulbProxy(LightBulb bulb)
        {
            this.bulb = bulb;
            Config();
        }

        public void Config()
        {
            Console.Write("Enter username: ");
            username = Console.ReadLine();
            Console.Write("Enter password: ");
            password = Console.ReadLine();
        }

        public override void TurnOn()
        {
            if (Verify())
                bulb.TurnOn();
            else
                Console.WriteLine("Incorrect username or password!");
        }

        private bool Verify()
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            if (this.username == username && this.password == password)
                return true;
            else
                return false;
        }

        public override void TurnOff()
        {
            if (Verify())
                bulb.TurnOff();
            else
                Console.WriteLine("Incorrect username or password!");
        }
    }
}