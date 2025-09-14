namespace Real_time_weather_monitoring.Models.Bots;

public class SunBot:BaseWeatherBot
{
    
    public SunBot(bool enabled, double threshold, string message)
    {
        Enabled = enabled;
        Threshold = threshold;
        Message = message;
    }
    
}