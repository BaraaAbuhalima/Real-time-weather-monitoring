
namespace Real_time_weather_monitoring.IO.FileIO.Input;

public class FileFileReader : IFileReader
{
    public string? Read(string filePath)
    {
      return  File.ReadAllText(filePath);
    }
}