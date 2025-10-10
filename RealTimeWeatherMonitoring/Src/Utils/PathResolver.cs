namespace RealTimeWeatherMonitoring.Utils;
public static class PathResolver
{
    public static string ResolvePath(string filePath)
    {
        
        var projectRoot = Directory.GetParent(AppContext.BaseDirectory)!.Parent!.Parent!.Parent!.FullName;
        return Path.Combine(projectRoot, filePath);
    }
}