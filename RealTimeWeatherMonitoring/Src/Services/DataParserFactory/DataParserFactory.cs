using RealTimeWeatherMonitoring.Enums;
using RealTimeWeatherMonitoring.Parsers;
namespace RealTimeWeatherMonitoring.Services;

public class DataParserFactory<T>:IDataParserFactory<T>
{
    public IDataParser<T> Create(ParserType parserType)
    {
        if (parserType == ParserType.Json)
        {
           return new JsonParser<T>();
        }

        if (parserType == ParserType.Xml)
        {
            return new XmlParser<T>();
        }
        
        throw new NotImplementedException();
    }
}

