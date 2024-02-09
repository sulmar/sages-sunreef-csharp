using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceApp.Model
{
    internal class BaseParameters
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsEnabled { get; set; }

    }
    internal class InverterParameters : BaseParameters
    {
        public int Z { get; set; }
    }

    internal class ChargerParameters : BaseParameters
    {
        public int D { get; set; }
        public int H { get; set; }
    }
}
