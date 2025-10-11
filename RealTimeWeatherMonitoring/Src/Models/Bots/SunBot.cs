using RealTimeWeatherMonitoring.Enums;
using RealTimeWeatherMonitoring.IO.Output;

namespace RealTimeWeatherMonitoring.Models.Bots;

public class SunBot:BaseWeatherBot
{
    
    public override BotDependency Dependency => BotDependency.Temperature;

    
    public SunBot(IBaseWeatherBotConfiguration configuration) :base(configuration) 
    {

    }
    
}