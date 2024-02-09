using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksApp.Model;

namespace TasksApp
{
    internal class GpsLocalizator
    {
        // Długotrwajaca operacja
        public GpsLocation GetCurrentLocation()
        {
            Console.WriteLine("Locating...");

            Thread.Sleep(3000);

            var location = new GpsLocation(54, 18);
            Console.WriteLine(location);

            return location;
        }
    }
}
