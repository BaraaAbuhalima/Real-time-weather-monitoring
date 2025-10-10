using System.Diagnostics.CodeAnalysis;
using RealTimeWeatherMonitoring.Enums;
using RealTimeWeatherMonitoring.IO.Output;

namespace RealTimeWeatherMonitoring.Models.Bots;

public class RainBot:BaseWeatherBot
{
    public override BotDependency Dependency => BotDependency.Humidity;
    
    [SetsRequiredMembers]
    public RainBot(WeatherBotConfiguration configuration):base(configuration) 
    {
    }

}