using Real_time_weather_monitoring.Containers;
using Real_time_weather_monitoring.Enums;
using Real_time_weather_monitoring.Models;
using Real_time_weather_monitoring.Parsers;
namespace Real_time_weather_monitoring.Services;

public static class DataParserFactory<T>
{
    private static DataParserContainer<T> _dataParserContainer =new DataParserContainer<T>();
    public static IDataParser<T> GetParser(DataFormat dataFormat)
    {
        if (dataFormat == DataFormat.JSON)
        {
           return _dataParserContainer.GetWeatherParser<JSONParser<T>>();
        }

        if (dataFormat == DataFormat.XML)
        {
            return _dataParserContainer.GetWeatherParser<XmlParser<T>>();
        }
        
        throw new NotImplementedException();
    }
}