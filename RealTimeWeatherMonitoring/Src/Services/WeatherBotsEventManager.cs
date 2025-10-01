using Real_time_weather_monitoring.Enums;
using Real_time_weather_monitoring.Models;
using Real_time_weather_monitoring.Models.Bots;
using Real_time_weather_monitoring.Models.WeatherData;

namespace Real_time_weather_monitoring.Services;

public class WeatherBotsEventManager
{
    private readonly SortedDictionary<BotType,BaseWeatherBot> _bots = [];

    public void Subscribe(BaseWeatherBot bot)
    {
        _bots.Add(bot.WeatherBotType(),bot);
    }

    public void Unsubscribe(BotType botType,BaseWeatherBot bot)
    {
        _bots.Remove(botType);
    }

    public void Notify(WeatherData data)
    {
        foreach (var bot in _bots)
        {
            
           var botThreshold= WeatherBotDependencyFactory.GetDependency(bot.Value, data);
           bot.Value.Update(botThreshold);
            
        }
    }
    
}