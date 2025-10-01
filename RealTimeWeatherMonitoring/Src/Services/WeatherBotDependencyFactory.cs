using Real_time_weather_monitoring.Enums;
using Real_time_weather_monitoring.Models;
using Real_time_weather_monitoring.Models.Bots;
using Real_time_weather_monitoring.Models.WeatherData;

namespace Real_time_weather_monitoring.Services;

public  static class WeatherBotDependencyFactory
{
    public static double GetDependency(BaseWeatherBot bot ,WeatherData data)
    {
        if (bot.Depedency() == BotDependency.Humidity)
        {
            return data.Humidity;
        }   
        if (bot.Depedency() == BotDependency.Temperature)
        {
         return data.Temperature;   
        } 
        throw new NotImplementedException();
    }
}