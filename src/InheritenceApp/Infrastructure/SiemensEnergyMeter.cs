using InheritenceApp.Abstractions;

namespace InheritenceApp.Infrastructure
{
    internal class SchneiderEnergyMeter : IEnergyMeter
    {
        private bool _enabled;

        public void SwitchOn()
        {
            _enabled = true;
        }

        public void SwitchOff()
        { 
            _enabled = false;
        }

        public float CalculateVoltage()
        {
            return 220;
        }

        public void Toggle()
        {
            if (_enabled)
            {
                SwitchOff();
            }
            else
            {
                SwitchOn();
            }
        }

        public float GetVoltage()
        {
            return CalculateVoltage();
        }
    }

    internal class SiemensEnergyMeter : IEnergyMeter
    {
        private bool _enabled;

        private const int MinimumVoltage = 200;
        private const int MaximumVoltage = 250;

        private Random _random;

        // Konstruktor
        public SiemensEnergyMeter()
        {
            _enabled = false;
            _random = new Random();
        }

        public float GetVoltage()
        {
            if (_enabled)
            {
                return _random.Next(MinimumVoltage, MaximumVoltage);
            }
            else
            {
                return 0;
            }
        }

        public void Toggle()
        {
            _enabled = !_enabled;
        }
    }
}
