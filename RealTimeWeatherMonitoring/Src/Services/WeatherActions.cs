using RealTimeWeatherMonitoring.Enums;
using RealTimeWeatherMonitoring.IO.WeatherDataIO;
using RealTimeWeatherMonitoring.Models.Bots;
using RealTimeWeatherMonitoring.Services;

namespace RealTimeWeatherMonitoring.Models;

public class WeatherActions
{
    public EventManager<WeatherEvent, BaseWeatherBot, WeatherData> Events { get; set; }

    public WeatherActions()
    {
        Events = new EventManager<WeatherEvent, BaseWeatherBot, WeatherData>();
    }
    
    public void ReadWeather(IWeatherDataConfigurationReader  reader)
    {
        var weatherData = reader.Read();
        Events.Notify(WeatherEvent.Reading, weatherData);
    }
}