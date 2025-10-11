using RealTimeWeatherMonitoring.Enums;
using RealTimeWeatherMonitoring.IO.WeatherDataIO;
using RealTimeWeatherMonitoring.Models.Bots;
using RealTimeWeatherMonitoring.Services;

namespace RealTimeWeatherMonitoring.Models;

public class WeatherActions:IWeatherActions
{
    public IEventManager<WeatherEvent, BaseWeatherBot, IWeatherData> Events { get; set; }

    public WeatherActions()
    {
        Events = new EventManager<WeatherEvent, BaseWeatherBot, IWeatherData>();
    }
    
    public void ReadWeather(IWeatherDataConfigurationReader  reader)
    {
        var weatherData = reader.Read();
        Events.Notify(WeatherEvent.Reading, weatherData);
    }
}

