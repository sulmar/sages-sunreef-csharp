using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceApp.Model
{

    // Czujnik ruchu dziedziczy własciwosci oraz metody po czujniku Sensor
    public class MotionSensor : Sensor
    {
        public bool IsMotionDetected { get; set; }
        public Batery Batery { get; set; }

        // Nadpisujemy metode wirtualna z klasy bazowej Sensor
        public override void Activate()
        {
            Console.WriteLine("Send Modbus");

            // Wywolujemy metode z klasy bazowej Sensor
            base.Activate();
        }
    }
}
