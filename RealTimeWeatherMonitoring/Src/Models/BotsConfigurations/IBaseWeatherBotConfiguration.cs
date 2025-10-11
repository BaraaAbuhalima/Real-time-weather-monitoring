namespace RealTimeWeatherMonitoring.Models;

public interface IBaseWeatherBotConfiguration:IBotConfiguration
{
    public bool Enabled { get; set; }
    public double Threshold { get; set; }
    public string Message { get; set; }
}