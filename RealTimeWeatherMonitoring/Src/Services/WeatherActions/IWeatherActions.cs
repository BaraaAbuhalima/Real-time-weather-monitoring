using RealTimeWeatherMonitoring.Enums;
using RealTimeWeatherMonitoring.IO.WeatherDataIO;
using RealTimeWeatherMonitoring.Models.Bots;
using RealTimeWeatherMonitoring.Services;

namespace RealTimeWeatherMonitoring.Models;

public interface IWeatherActions
{
    public IEventManager<WeatherEvent, BaseWeatherBot, IWeatherData> Events { get; set; }



    public void ReadWeather(IWeatherDataConfigurationReader reader);
}