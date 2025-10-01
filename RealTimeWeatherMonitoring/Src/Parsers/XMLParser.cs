using System.Xml;
using System.Xml.Serialization;

namespace Real_time_weather_monitoring.Parsers;

public class XmlParser<T> : IDataParser<T>
{
    private readonly XmlSerializer _serializer;
    
    public XmlParser()
    {
        _serializer = new XmlSerializer(typeof(T));
        
    }
    public T Parse(string input)
    {
        using var reader = new StringReader(input);
        return (T)_serializer.Deserialize(reader)!;
    }
}