using System.ComponentModel;

namespace ThermostatEventsApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

public class HeatSensor : IHeatSensor
{
    event EventHandler<TemperatureEventArgs> IHeatSensor.TemperatureReachesEmergencyLevelEventHandler
    {
        add
        {
            throw new NotImplementedException();
        }

        remove
        {
            throw new NotImplementedException();
        }
    }

    event EventHandler<TemperatureEventArgs> IHeatSensor.TemperatureReachesWarningLevelEventHandler
    {
        add
        {
            throw new NotImplementedException();
        }

        remove
        {
            throw new NotImplementedException();
        }
    }

    event EventHandler<TemperatureEventArgs> IHeatSensor.TemperatureFallsBelowWarningLevelEventHandler
    {
        add
        {
            throw new NotImplementedException();
        }

        remove
        {
            throw new NotImplementedException();
        }
    }

    void IHeatSensor.RunHeatSensor()
    {
        throw new NotImplementedException();
    }
}

public interface IHeatSensor
{
    event EventHandler<TemperatureEventArgs> TemperatureReachesEmergencyLevelEventHandler;
    event EventHandler<TemperatureEventArgs> TemperatureReachesWarningLevelEventHandler;
    event EventHandler<TemperatureEventArgs> TemperatureFallsBelowWarningLevelEventHandler;

    void RunHeatSensor();
}

public class TemperatureEventArgs : EventArgs
{
    public double Temperature { get; set; }
    public DateTime CurrentDateTime { get; set; }

}
