using RealTimeWeatherMonitoring.IO.WeatherBotIO;

namespace RealTimeWeatherMonitoring.IO.Input;

public class ConsoleReader:IReader
{
    public string? Read()
    {
        return Console.ReadLine();
    }
}