using System.Text.Json;

namespace Real_time_weather_monitoring.Parsers;

public class JSONParser< T>: IDataParser<T>
{
    public T Parse(string inputString)
    {
        return JsonSerializer.Deserialize<T>(inputString)!;
    }
}