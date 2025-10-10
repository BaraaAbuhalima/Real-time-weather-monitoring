using RealTimeWeatherMonitoring.Configurations;
using RealTimeWeatherMonitoring.Enums;
using RealTimeWeatherMonitoring.IO.BotsConfigurationsIO;
using RealTimeWeatherMonitoring.IO.Output;
using RealTimeWeatherMonitoring.IO.WeatherDataIO;
using RealTimeWeatherMonitoring.Models.Bots;
using RealTimeWeatherMonitoring.Services;

namespace RealTimeWeatherMonitoring.Models;

public class Client
{
    private IWeatherDataConfigurationReader WeatherDataConfigurationReader { get; set; }

    public Client(IWeatherDataConfigurationReader weatherDataConfigurationReader)
    {
        WeatherDataConfigurationReader=weatherDataConfigurationReader;
    }
    
    public void Run()
    {
        
        var builder = new BotsBuilder<BaseWeatherBot>(new BotFactory<BaseWeatherBot>(),new WeatherBotsConfigurationsFileReader());
        var bots=   builder.CreatBots();
        var editor = new WeatherActions();
        foreach (var bot in bots)
        {
           Console.WriteLine(bot.Dependency);
            editor.Events.Subscribe(WeatherEvent.Reading,bot);
        }
        editor.ReadWeather(WeatherDataConfigurationReader);
    }
    
}