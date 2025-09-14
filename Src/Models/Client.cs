using Real_time_weather_monitoring.Configurations;
using Real_time_weather_monitoring.IO.WeatherDataIO;
using Real_time_weather_monitoring.Services;

namespace Real_time_weather_monitoring.Models;

public class Client
{
    private IWeatherReader WeatherReader { get; set; }

    public Client(IWeatherReader weatherReader)
    {
        WeatherReader=weatherReader;
    }
    public Client()
    {
        WeatherReader = new ConsoleWeatherReader();
    }
    public void Run()
    {
    var list=   WeatherBotsConfigurator.CreatBots();
    var weatherBotsEventManager = new WeatherBotsEventManager();
    foreach (var bot in list)
    {
        weatherBotsEventManager.Subscribe(bot);
         
    }

    var weatherdata = WeatherReader.Read();
    weatherBotsEventManager.Notify(weatherdata);
    }
    
}