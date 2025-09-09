namespace Real_time_weather_monitoring.IO.Files.Output;

public class FileWriter: IFileWriter
{
    public void Write(string filePath, string content)
    {
        File.WriteAllText(filePath, content);
    }
}