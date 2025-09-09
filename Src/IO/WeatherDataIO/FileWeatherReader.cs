using Real_time_weather_monitoring.Configurations;
using Real_time_weather_monitoring.IO.FileIO.Input;

namespace Real_time_weather_monitoring.IO.WeatherData;

public class FileWeatherReader: IWeatherReader
{
    private readonly IFileReader _fileReader = new FileFileReader();
    private readonly string _weatherFilePathReader = DataPath.WeatherData;
    
    public string? Read()
    {
        return _fileReader.Read(_weatherFilePathReader);
    }
}