namespace Real_time_weather_monitoring.IO.Input;

public class FileFileReader : IFileReader
{
    public String Read(string filePath)
    {
      return  File.ReadAllText(filePath);
    }
}