using System.Text.Json;

namespace RealTimeWeatherMonitoring.Parsers;

public class JsonParser< T>: IDataParser<T>
{
    public T Parse(string inputString)
    {
        return JsonSerializer.Deserialize<T>(inputString)!;
    }
}