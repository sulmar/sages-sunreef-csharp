using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceApp.Model
{
    internal class HumaditySensor : Sensor
    {
        public override void Activate()
        {
            Console.WriteLine( "Set registry in modbus");
            base.Activate();
        }
    }
}
