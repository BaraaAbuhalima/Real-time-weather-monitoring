using RealTimeWeatherMonitoring.Enums;
using RealTimeWeatherMonitoring.Parsers;
namespace RealTimeWeatherMonitoring.Services;

public class DataParserFactory<T>:IDataParserFactory<T>
{
    public IDataParser<T> Create(DataFormat dataFormat)
    {
        if (dataFormat == DataFormat.Json)
        {
           return new JsonParser<T>();
        }

        if (dataFormat == DataFormat.Xml)
        {
            return new XmlParser<T>();
        }
        
        throw new NotImplementedException();
    }
}

