using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksApp.Model
{

    internal class GpsLocation
    {
        public DateTime TimeStamp { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public GpsLocation(double lat, double lng)
        {
            TimeStamp = DateTime.Now;

            Latitude = lat;
            Longitude = lng;
        }

        public override string ToString()
        {
            return $"{this.TimeStamp} ({this.Longitude}, {this.Latitude})";
        }

    }
}
