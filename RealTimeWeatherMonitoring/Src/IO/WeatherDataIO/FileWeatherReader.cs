using Real_time_weather_monitoring.Configurations;
using Real_time_weather_monitoring.IO.FileIO.Input;
using Real_time_weather_monitoring.Models.WeatherData;

namespace Real_time_weather_monitoring.IO.WeatherDataIO;

public class FileWeatherReader: IWeatherReader
{
    private readonly IFileReader _fileReader = new FileReader();
    private readonly string _weatherFilePathReader = DataPath.WeatherData;
    
    public WeatherData? Read()
    {
        throw new NotImplementedException();
    }
}