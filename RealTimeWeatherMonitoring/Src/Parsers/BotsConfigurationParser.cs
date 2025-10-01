using Real_time_weather_monitoring.Enums;
using Real_time_weather_monitoring.Models;
using Real_time_weather_monitoring.Models.Bots;
using Real_time_weather_monitoring.Services;

namespace Real_time_weather_monitoring.Parsers;

public class WeatherBotsConfigurationParser:IWeatherBotsConfigurationParser
{
    public Dictionary<string, WeatherBotConfiguration> Parse(string json)
    {
        try
        {
            var parser = DataParserFactory<Dictionary<string, WeatherBotConfiguration>>.GetParser(DataFormat.JSON);
            return parser.Parse(json);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
}

public interface IWeatherBotsConfigurationParser
{
    public Dictionary<string, WeatherBotConfiguration> Parse(string json);
}