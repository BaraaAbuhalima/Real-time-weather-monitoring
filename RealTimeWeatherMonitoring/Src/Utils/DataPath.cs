using Real_time_weather_monitoring.Utils;

namespace Real_time_weather_monitoring.Configurations;

public static class DataPath
{
    public static readonly string WeatherData= PathResolver.ResolvePath("Data/WeatherData.txt");
    public static readonly string BotsConfiguration= PathResolver.ResolvePath("BotsConfiguration.json");
}