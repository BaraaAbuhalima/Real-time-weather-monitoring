using Real_time_weather_monitoring.IO;
using Real_time_weather_monitoring.Models.Bots;
using Real_time_weather_monitoring.Parsers;
using Real_time_weather_monitoring.Services;

namespace Real_time_weather_monitoring.Configurations;

public static class WeatherBotsConfigurator
{
    public static List<BaseWeatherBot?> CreatBots()
    {
        var reader = new BotsConfigurationReader();
        var parser = new BotsConfigurationParser();
        var configurations = reader.Read();
        var bots = parser.Parse(configurations);
        return bots.Select(bot => BotFactory.CreateBot(bot.Key, bot.Value))
            .Where(bot => bot != null)
            .ToList();
        
    }
}

