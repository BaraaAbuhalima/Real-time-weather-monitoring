using RealTimeWeatherMonitoring.IO.WeatherDataIO;
using RealTimeWeatherMonitoring.Models;

namespace RealTimeWeatherMonitoring;

public static class Program
{
    public static void Main(string[] args)
    {
        var weatherConfigReader = new WeatherDataConfigurationConsoleReader();
        var client = new Client(weatherConfigReader);
        client.Run();
    }
}
