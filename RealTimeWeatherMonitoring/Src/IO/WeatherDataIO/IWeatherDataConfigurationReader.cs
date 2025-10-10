using RealTimeWeatherMonitoring.Enums;
using RealTimeWeatherMonitoring.Models;
using RealTimeWeatherMonitoring.Models.Bots;
using RealTimeWeatherMonitoring.Services;

namespace RealTimeWeatherMonitoring.IO.WeatherDataIO;

public interface IWeatherDataConfigurationReader
{
    public WeatherData Read();
}