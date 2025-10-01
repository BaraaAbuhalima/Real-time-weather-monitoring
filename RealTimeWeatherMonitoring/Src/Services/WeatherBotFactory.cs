using Real_time_weather_monitoring.Models;
using Real_time_weather_monitoring.Models.Bots;

namespace Real_time_weather_monitoring.Services;

public class WeatherBotFactory:IWeatherBotFactory
{
    private static readonly string Namespace = "Real_time_weather_monitoring.Models.Bots";

    public  BaseWeatherBot? CreateBot(string botName, WeatherBotConfiguration configuration)
    {
        var botType = Type.GetType($"{Namespace}.{botName}");
        if (botType == null || !typeof(BaseWeatherBot).IsAssignableFrom(botType))
            return null;
        return (BaseWeatherBot)Activator.CreateInstance(
            botType,
           configuration
        )!;
    }
}

public interface IWeatherBotFactory
{
    public BaseWeatherBot? CreateBot(string botName, WeatherBotConfiguration configuration);
    
}