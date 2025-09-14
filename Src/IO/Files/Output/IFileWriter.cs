namespace Real_time_weather_monitoring.IO.Files.Output;

public interface IFileWriter
{
    public void Write(string filePath, string content);
}