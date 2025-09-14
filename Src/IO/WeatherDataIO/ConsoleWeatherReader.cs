using Real_time_weather_monitoring.IO.ConsoleIO.Input;
using Real_time_weather_monitoring.IO.WeatherData;

namespace Real_time_weather_monitoring.IO.WeatherDataIO;

public class ConsoleWeatherReader: IWeatherReader
{
    private readonly IConsoleReader _consoleReader=new ConsoleReader();

    public string? Read()
    {
        return _consoleReader.Read();
    }
    
}