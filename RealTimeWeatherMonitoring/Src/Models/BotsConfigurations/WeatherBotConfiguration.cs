namespace RealTimeWeatherMonitoring.Models;

public class WeatherBotConfiguration:IBaseWeatherBotConfiguration
{
    public required bool Enabled { get; set; }
    public  required double Threshold { get; set; }
    public required string Message { get; set; }

    public WeatherBotConfiguration(bool enabled, double threshold, string message)
    {
        Enabled = enabled;
        Threshold = threshold;
        Message = message;
        
    }
}
