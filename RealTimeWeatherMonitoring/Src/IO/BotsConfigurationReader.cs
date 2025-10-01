using Real_time_weather_monitoring.Configurations;
using Real_time_weather_monitoring.IO.FileIO.Input;

namespace Real_time_weather_monitoring.IO;

public class WeatherBotsConfigurationReader:IWeatherBotsConfigurationReader
{
    private readonly string _filePath = DataPath.BotsConfiguration;

    public string Read()
    {
        var reader = new FileReader();
        return reader.Read(_filePath)!;
    }
}

public interface IWeatherBotsConfigurationReader
{
    public string Read();
}