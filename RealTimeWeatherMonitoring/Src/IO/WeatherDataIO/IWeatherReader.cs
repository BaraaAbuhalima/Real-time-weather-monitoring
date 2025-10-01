using Real_time_weather_monitoring.Models.WeatherData;


public interface IWeatherReader
{
    public WeatherData? Read();
}