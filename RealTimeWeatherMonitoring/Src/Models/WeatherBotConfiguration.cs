using System.Diagnostics.CodeAnalysis;

namespace Real_time_weather_monitoring.Models;

public class WeatherBotConfiguration:IWeatherBotConfiguration
{
    public required bool Enabled { get; set; }
    public required double Threshold { get; set; }
    public required string Message { get; set; }

    public WeatherBotConfiguration() {}
    
    [SetsRequiredMembers]
    public WeatherBotConfiguration(bool enabled, double threshold, string message)
    {
        Enabled = enabled;
        Threshold = threshold;
        Message = message;
        
    }


    
}

public interface IWeatherBotConfiguration
{
    public bool Enabled { get; set; }
    public double Threshold { get; set; }
    public string Message { get; set; }
}
