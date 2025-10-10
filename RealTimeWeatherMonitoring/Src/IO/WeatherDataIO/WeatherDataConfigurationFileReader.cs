using RealTimeWeatherMonitoring.Enums;
using RealTimeWeatherMonitoring.IO.Input;
using RealTimeWeatherMonitoring.IO.WeatherBotIO;
using RealTimeWeatherMonitoring.Models;
using RealTimeWeatherMonitoring.Models.Bots;
using RealTimeWeatherMonitoring.Services;
using RealTimeWeatherMonitoring.Utils;

namespace RealTimeWeatherMonitoring.IO.WeatherDataIO;

public class WeatherDataConfigurationFileReader: IWeatherDataConfigurationReader
{
    private IReader Reader { get; }
    private static string _filePath = DataPath.WeatherData;
    private const DataFormat Format = DataFormat.Json;
    public WeatherDataConfigurationFileReader(string filePath)
    {
        Reader=new FileReader(filePath);
    }
    
    public WeatherData Read()
    {
       throw new NotImplementedException();
    }
}