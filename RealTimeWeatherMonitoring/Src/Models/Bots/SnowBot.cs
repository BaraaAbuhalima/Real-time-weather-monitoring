using System.Diagnostics.CodeAnalysis;
using Real_time_weather_monitoring.Enums;

namespace Real_time_weather_monitoring.Models.Bots;

public class SnowBot:BaseWeatherBot
{
    public override BotDependency Depedency() => BotDependency.Temperature;
    public override BotType WeatherBotType() => BotType.Snow;
    [SetsRequiredMembers]
    public SnowBot(WeatherBotConfiguration configuration)
    {
        this.Configuration = configuration;
    }
    
}