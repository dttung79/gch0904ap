using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProxy
{
    public class LightBulbControl
    {
        private string connect;
        private IoTLightBulb bulb;
        public LightBulbControl(string connect)
        {
            this.connect = connect;
        }

        public void ChangeConnect(string connect)
        {
            this.connect = connect;
        }


        public void ConnectBulb(LightBulb bulb)
        {
            if (connect == "REMOTE") this.bulb = new LightBulbProxy(bulb);
            else this.bulb = bulb;
        }

        public void TurnOn()
        {
            bulb.TurnOn();
        }
        public void TurnOff()
        {
            bulb.TurnOff();
        }
    }
}