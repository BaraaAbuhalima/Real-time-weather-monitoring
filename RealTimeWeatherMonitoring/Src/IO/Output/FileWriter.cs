namespace RealTimeWeatherMonitoring.IO.Output;

public class FileWriter: IWriter
{
    public string FilePath { get; set; }
    public FileWriter(string filePath)
    {
        FilePath = filePath;
    }
    public void Write(string content)
    {
        File.WriteAllText(FilePath, content);
        
    }
}