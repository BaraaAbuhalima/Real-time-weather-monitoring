namespace Real_time_weather_monitoring.Models;

public class WeatherBotConfiguration
{
    public bool Enabled { get; set; }
    public double Threshold { get; set; }
    public string Message { get; set; }

    public WeatherBotConfiguration(bool enabled, double threshold, string message)
    {
        Enabled = enabled;
        Threshold = threshold;
        Message = message;
        
    }
}