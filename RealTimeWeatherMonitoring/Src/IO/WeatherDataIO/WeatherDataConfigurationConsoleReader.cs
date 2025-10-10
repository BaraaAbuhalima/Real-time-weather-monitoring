using RealTimeWeatherMonitoring.Enums;
using RealTimeWeatherMonitoring.IO.Input;
using RealTimeWeatherMonitoring.IO.Output;
using RealTimeWeatherMonitoring.IO.WeatherBotIO;
using RealTimeWeatherMonitoring.Models;
using RealTimeWeatherMonitoring.Models.Bots;
using RealTimeWeatherMonitoring.Services;

namespace RealTimeWeatherMonitoring.IO.WeatherDataIO;

public class WeatherDataConfigurationConsoleReader: IWeatherDataConfigurationReader
{
    private IReader Reader { get; }
    private IWriter Writer{get;}

    public WeatherDataConfigurationConsoleReader()
    {
        Reader = new ConsoleReader();
        Writer=new ConsoleWriter();

    }


    public WeatherData Read()
    {
        Writer.Write("Please enter the weather data:");
        Writer.Write("Location : ");
        var location= Reader.Read()!;
        Writer.Write("Temperature : ");
        var temperature = Convert.ToInt32(Reader.Read()!);
        Writer.Write("Humidity : ");
        var humidity = Convert.ToInt32(Reader.Read()!);
        return new WeatherData(location, temperature, humidity);
    }
    
}