using System.Xml.Serialization;

namespace RealTimeWeatherMonitoring.Parsers;

public class XmlParser<T> : IDataParser<T>
{
    public T Parse(string input)
    {
        var serializer = new XmlSerializer(typeof(T));
        using var reader = new StringReader(input);
        
        return (T)serializer.Deserialize(reader)!;
    }
}