namespace InheritenceApp.Model
{
    // Klasa bazowa
    public abstract class Sensor
    {
        public string Name { get; set; }
        public string Location { get; set; }

        protected bool isActive;

        // Sygnatura metody
        public delegate void LogEventHandler(string message);
        public LogEventHandler LogEvent;

        public delegate decimal CalculateDelegate(string content);
        public CalculateDelegate Calculate;

        public event LogEventHandler OnLogEvent;

        public virtual void Activate()
        {
            LogEvent?.Invoke($"Aktywacja czujnika {Name}");
            OnLogEvent?.Invoke($"Aktywacja czujnika {Name}");

            isActive = true;

            var cost = Calculate?.Invoke(Name);
            Console.WriteLine($"Label {cost}");

        }

        public void Deactivate()
        {
            LogEvent?.Invoke($"Deaktywacja czujnika {Name}");

            isActive = false;
        }
    }
}
