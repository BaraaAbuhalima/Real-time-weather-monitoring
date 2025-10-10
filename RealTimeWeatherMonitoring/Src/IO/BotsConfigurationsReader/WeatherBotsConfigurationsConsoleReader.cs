using RealTimeWeatherMonitoring.Models;
using RealTimeWeatherMonitoring.Models.Bots;

namespace RealTimeWeatherMonitoring.IO.BotsConfigurationsIO;

public class WeatherBotsConfigurationsConsoleReader:IBotsConfigurationsReader
{
    public Dictionary<string,WeatherBotConfiguration?> GetConfigurations()
    {
        throw new NotImplementedException();
    }
}