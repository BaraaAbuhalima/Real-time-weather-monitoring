namespace Real_time_weather_monitoring.Configurations;

public static class DataPath
{
    private static string ResolvePath(string filePath)
    {
        string projectRoot = Directory.GetParent(AppContext.BaseDirectory)!.Parent!.Parent!.Parent!.FullName;
        return Path.Combine(projectRoot, filePath);
        
    }
    public static readonly string WeatherData=ResolvePath("Data/WeatherData.txt");
}