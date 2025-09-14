namespace Real_time_weather_monitoring.Models.Bots;

public class BaseWeatherBot:IBot
{
    
    public required bool Enabled { get; set; }
    public required double Threshold { get; set; }
    public required string Message { get; set; }
    
}