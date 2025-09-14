namespace Real_time_weather_monitoring.IO.FileIO.Output;
public interface IFileWriter
{
    public void Write(string filePath, string content);
}