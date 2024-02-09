using InheritenceApp.Abstractions;
using InheritenceApp.Infrastructure;
using InheritenceApp.Model;
using System.Diagnostics;
using System.Xml.Linq;

namespace InheritenceApp
{
    internal class Program
    {
        public static object Debug { get; private set; }

        static void LogToConsole(string content)
        {
            Console.WriteLine($"[{DateTime.Now}] {content}");
        }

        static void Main(string[] args)
        {
            Server server = new Server("192.168.0.1");
            var settings = new SkyllaChargerServiceSettings();
            IChargerService chargerService = new SkyllaChargerService(server, settings);
            var parameters = chargerService.GetChargerParameters();


            var temperatureSensor1 = new TemperatureSensor();
            temperatureSensor1.Name = "abc";
            temperatureSensor1.Temperature = 21;

            // Obsługa delegata za pomoca wyrazenia lambda
            temperatureSensor1.Calculate += (content) => content.Length * 10;

            temperatureSensor1.Activate();

            IEnergyMeter energyMeter = new SchneiderEnergyMeter();
            energyMeter.Toggle();
            while (true)
            {
                var voltage = energyMeter.GetVoltage();

                Console.WriteLine($"{voltage}V");

                Thread.Sleep( 1000 );

            }


            var humaditySensor = new { Name = "Abc", Value = 10.0F };


           

            // Obsluga delegata
            temperatureSensor1.LogEvent += LogToConsole;

            temperatureSensor1.LogEvent += Console.WriteLine;

            temperatureSensor1.LogEvent += delegate (string message)
            {
                System.Diagnostics.Debug.WriteLine($"[{DateTime.Now}] {message}");
            };

            temperatureSensor1.LogEvent += x => System.Diagnostics.Debug.WriteLine($"[{DateTime.Now}] {x}");

            temperatureSensor1.LogEvent -= LogToConsole;

            temperatureSensor1.LogEvent = null;


            temperatureSensor1.Activate();

            var temperatureSensor2 = new TemperatureSensor();
            temperatureSensor2.Name = "xyz";
            temperatureSensor2.Temperature = 20;

            var motionSensor = new MotionSensor();
            motionSensor.Name = "aaa";

            var name = temperatureSensor1.Name;

            Console.WriteLine(name);

            var temperature = temperatureSensor1.GetTemperatureInFarenhait();
            Console.WriteLine(temperature);



            List<Sensor> sensors = new List<Sensor>();
            sensors.Add(temperatureSensor1);
            sensors.Add(temperatureSensor2);
            sensors.Add(motionSensor);
            sensors.Add(new HumaditySensor());

            foreach (var sensor in sensors)
            {
                sensor.Activate();
            }

            List<Sensor> filteredSensors = new List<Sensor>();

            foreach (var b in sensors)
            {
                if (b.Name.StartsWith('a'))
                {
                    filteredSensors.Add(b);
                }
            }

            // LINQ
            List<Sensor> filteredSensors2 = sensors.Where(b => b.Name.StartsWith('a')).ToList();


        }
    }
}
