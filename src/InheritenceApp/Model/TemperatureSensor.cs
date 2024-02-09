using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InheritenceApp.Model
{
    public class TemperatureSensor : Sensor
    {
        public float Temperature { get; set; }

        public float GetTemperatureInFarenhait()
        {
            if (isActive)
            {
                return Temperature;
            }
            else
            {
                return 0;
            }
        }

        public override void Activate()
        {
            Console.WriteLine("Send websocket");

            base.Activate();
        }


    }
}
