using System.Reflection;
using RealTimeWeatherMonitoring.Models;
using RealTimeWeatherMonitoring.Models.Bots;

namespace RealTimeWeatherMonitoring.Services;

public class BotFactory<TBot> :IBotFactory<TBot>where TBot :IBot
{
    
    private const string Namespace = "RealTimeWeatherMonitoring.Models.Bots";
    
    public TBot Create(string botName, IBotConfiguration configuration)
    {
        var botType =GetBotType(botName);
        
        if (botType == null)
        {
            throw new TypeLoadException($"Can't find any bot of type {botName}");
        }
        
        return (TBot)Activator.CreateInstance(
            botType,
           configuration
        )!;
    }

    private Type? GetBotType(string botName)
    {
        return  Assembly.GetAssembly(typeof(IBot))?
            .GetTypes()
            .FirstOrDefault(t => typeof(IBot).IsAssignableFrom(t) && t.Name == botName);
    }
}