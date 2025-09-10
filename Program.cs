using Real_time_weather_monitoring.Configurations;

namespace Real_time_weather_monitoring;

public class Program
{
    public static void Main(string[] args)
    {
     var list=   WeatherBotsConfigurator.GetAllBots();
     Console.WriteLine(list.Count);
    }
}