using System.Diagnostics.CodeAnalysis;

namespace Real_time_weather_monitoring.Models.Bots;

public class RainBot:BaseWeatherBot
{
    
    [SetsRequiredMembers]
    public RainBot(bool enabled, double threshold, string message)
    {
        Enabled = enabled;
        Threshold = threshold;
        Message = message;
    }
    
}