using Real_time_weather_monitoring.Modles;

namespace Real_time_weather_monitoring.Parsers;

public interface IDataParser<out T>
{
    public T Parse(string inputString);
}