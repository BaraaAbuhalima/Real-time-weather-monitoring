
namespace Real_time_weather_monitoring.IO.FileIO.Input;

public class FileReader : IFileReader
{
    public string? Read(string filePath)
    {
      return  File.ReadAllText(filePath);
    }
}