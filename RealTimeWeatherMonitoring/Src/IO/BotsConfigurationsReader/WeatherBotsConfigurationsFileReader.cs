using RealTimeWeatherMonitoring.Enums;
using RealTimeWeatherMonitoring.IO.Input;
using RealTimeWeatherMonitoring.Models;
using RealTimeWeatherMonitoring.Parsers;
using RealTimeWeatherMonitoring.Services;
using RealTimeWeatherMonitoring.Utils;

namespace RealTimeWeatherMonitoring.IO.BotsConfigurationsIO;

public class WeatherBotsConfigurationsFileReader:IBotsConfigurationsReader
{
    private readonly FileReader _fileReader;
    private const DataFormat Format = DataFormat.Json;

    private readonly IDataParser<Dictionary<string,WeatherBotConfiguration>> _parser;
    
    public WeatherBotsConfigurationsFileReader()
    {
        _fileReader = new FileReader(DataPath.WeatherBotsConfiguration);
        var dataParserFactory = new DataParserFactory<Dictionary<string,WeatherBotConfiguration>>();
        _parser = dataParserFactory.Create(Format);
    }
    
    public Dictionary<string,WeatherBotConfiguration> GetConfigurations()
    {
        var file= _fileReader.Read();
        return _parser.Parse(file);
    }
}