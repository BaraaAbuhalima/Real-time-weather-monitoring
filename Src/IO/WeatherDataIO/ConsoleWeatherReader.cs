using Real_time_weather_monitoring.IO.ConsoleIO.Input;
using Real_time_weather_monitoring.IO.ConsoleIO.Output;

namespace Real_time_weather_monitoring.IO.WeatherDataIO;

public class ConsoleWeatherReader: IWeatherReader
{
    private readonly IConsoleReader _consoleReader=new ConsoleReader();
    private readonly IConsoleWriter _consoleWriter=new ConsoleWriter();
    public Models.WeatherData.WeatherData? Read()
    {
        _consoleWriter.Write("Please enter the weather data:");
        _consoleWriter.Write("Location : ");
        string location= _consoleReader.Read()!;
        _consoleWriter.Write("Temperature : ");
        int temperature = Convert.ToInt32(_consoleReader.Read()!);
        _consoleWriter.Write("Humidity : ");
        int humidity = Convert.ToInt32(_consoleReader.Read()!);
        return new Models.WeatherData.WeatherData(location, temperature, humidity);
    }
    
}