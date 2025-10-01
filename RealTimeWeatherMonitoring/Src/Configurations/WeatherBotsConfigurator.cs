using Real_time_weather_monitoring.IO;
using Real_time_weather_monitoring.Models;
using Real_time_weather_monitoring.Models.Bots;
using Real_time_weather_monitoring.Parsers;
using Real_time_weather_monitoring.Services;

namespace Real_time_weather_monitoring.Configurations;

public  class WeatherBotsConfigurator
{
    private readonly IWeatherBotsConfigurationParser _parser;
    private readonly IWeatherBotsConfigurationReader _reader;
    private readonly IWeatherBotFactory _factory;
    
    public WeatherBotsConfigurator(IWeatherBotsConfigurationReader reader,IWeatherBotsConfigurationParser parser,IWeatherBotFactory factory)
    {
        
        _parser = parser;
        _reader = reader;
        _factory = factory;
    }
   
    public List<BaseWeatherBot?> GetBots()
    {
        var botsConfigurations = GetBotsConfigurations();
        return CreateBots(botsConfigurations);
    }

    private Dictionary<string, WeatherBotConfiguration> GetBotsConfigurations()
    { 
        var configurations = _reader.Read();
        return _parser.Parse(configurations);
    }

    private List<BaseWeatherBot?> CreateBots(Dictionary<string, WeatherBotConfiguration> bots)
    {
        return bots.Select(bot => _factory.CreateBot(bot.Key, bot.Value))
            .Where(bot => bot != null)
            .ToList();
    }
}

