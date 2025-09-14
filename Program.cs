using Real_time_weather_monitoring.Models;

namespace Real_time_weather_monitoring;

public static class Program
{
    public static void Main(string[] args)
    {
        var client = new Client();
        client.Run();
    }
}