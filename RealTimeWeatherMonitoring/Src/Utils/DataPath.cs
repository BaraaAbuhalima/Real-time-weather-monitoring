namespace RealTimeWeatherMonitoring.Utils;

public static class DataPath
{
    public static readonly string WeatherData= PathResolver.ResolvePath("Data/WeatherData.txt");
    public static readonly string WeatherBotsConfiguration= PathResolver.ResolvePath("BotsConfiguration.json");
}


