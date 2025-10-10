using RealTimeWeatherMonitoring.Models;
using RealTimeWeatherMonitoring.Models.Bots;

namespace RealTimeWeatherMonitoring.IO.BotsConfigurationsIO;

public interface IBotsConfigurationsReader
{
    public Dictionary<string,WeatherBotConfiguration> GetConfigurations();
}