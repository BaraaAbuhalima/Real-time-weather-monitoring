namespace RealTimeWeatherMonitoring.Models;

public interface IWeatherData
{
    public string Location { get; set; }
    public double Temperature { get; set; }
    public double Humidity { get; set; }
}