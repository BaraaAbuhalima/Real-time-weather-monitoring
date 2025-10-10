using RealTimeWeatherMonitoring.IO.WeatherBotIO;

namespace RealTimeWeatherMonitoring.IO.Input;

public class FileReader : IReader
{
    public string FilePath { get; set; }

    public FileReader(string filePath)
    {
        FilePath = filePath;
    }
    public string Read()
    {

            return File.ReadAllText(FilePath);

    }
}