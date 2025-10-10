using RealTimeWeatherMonitoring.Enums;
using RealTimeWeatherMonitoring.Models;
using RealTimeWeatherMonitoring.Models.Bots;

namespace RealTimeWeatherMonitoring.Services;

public  static class WeatherBotDependencyResolver
{
    public static double GetThreshold(BaseWeatherBot bot ,WeatherData data)
    {
        if (bot.Dependency == BotDependency.Humidity)
        {
            return data.Humidity;
        }   
        
        if (bot.Dependency == BotDependency.Temperature)
        {
         return data.Temperature;   
        } 
        
        throw new NotImplementedException();
    }
}