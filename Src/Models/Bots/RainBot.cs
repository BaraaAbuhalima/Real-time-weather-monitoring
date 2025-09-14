using System.Diagnostics.CodeAnalysis;
using Real_time_weather_monitoring.Enums;

namespace Real_time_weather_monitoring.Models.Bots;

public class RainBot:BaseWeatherBot
{
    public override BotDependency Depedency() => BotDependency.Humidity;
    public override BotType WeatherBotType()=> BotType.Rain;
    
    [SetsRequiredMembers]
    public RainBot(WeatherBotConfiguration configuration)
    {
        this.Configuration = configuration;
    }

}