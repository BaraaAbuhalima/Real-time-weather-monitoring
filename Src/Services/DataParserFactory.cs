using Real_time_weather_monitoring.Enums;
using Real_time_weather_monitoring.Parsers;

namespace Real_time_weather_monitoring.Services;

public static class DataParserFacotry
{
    public static IDataParser<T> GetParser<T>(DataFormat dataFormat)
    {
        if (dataFormat == DataFormat.JSON)
        {
            return new JSONParser<T>();
        }

        if (dataFormat == DataFormat.XML)
        {
            return new XmlParser<T>();
        }
        
        throw new NotImplementedException();
    }
}