using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceApp.Abstractions
{
    internal interface IEnergyMeter
    {
        void Toggle();
        float GetVoltage();
    }
}
