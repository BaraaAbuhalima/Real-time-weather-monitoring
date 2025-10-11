using System.Diagnostics.CodeAnalysis;
using RealTimeWeatherMonitoring.Enums;
using RealTimeWeatherMonitoring.IO.Output;

namespace RealTimeWeatherMonitoring.Models.Bots;

public class SnowBot:BaseWeatherBot
{
    public override BotDependency Dependency => BotDependency.Temperature;
    
    [SetsRequiredMembers]
    public SnowBot(IBaseWeatherBotConfiguration configuration):base(configuration) 
    {
    }
    
}