namespace Real_time_weather_monitoring.Models.WeatherData;

public class WeatherData
{

    public string Location { get; set; }
    public double Temperature { get; set; }
    public double Humidity { get; set; }
    
    public WeatherData(string location, double temperature, double humidity)
    {
        Location = location;
        Temperature = temperature;
        Humidity = humidity;
    }
    
}