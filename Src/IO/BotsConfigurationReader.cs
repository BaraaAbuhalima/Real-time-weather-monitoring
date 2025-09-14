using Real_time_weather_monitoring.Configurations;
using Real_time_weather_monitoring.IO.FileIO.Input;

namespace Real_time_weather_monitoring.IO;

public class BotsConfigurationReader
{
    private readonly string _filePath = DataPath.BotsConfiguration;

    public string Read()
    {
        var reader = new FileReader();
        return reader.Read(_filePath)!;
    }
}