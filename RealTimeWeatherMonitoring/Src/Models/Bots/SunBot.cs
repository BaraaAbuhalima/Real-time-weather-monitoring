using Real_time_weather_monitoring.Enums;

namespace Real_time_weather_monitoring.Models.Bots;

public class SunBot:BaseWeatherBot
{
    
    public override BotDependency Depedency() => BotDependency.Temperature;
    public override BotType WeatherBotType()=> BotType.Sun;
    
    public SunBot(WeatherBotConfiguration configuration)
    {
        this.Configuration = configuration;
    }
    
}