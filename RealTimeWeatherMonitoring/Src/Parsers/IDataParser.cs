namespace RealTimeWeatherMonitoring.Parsers;

public interface IDataParser<out T>
{
    public T Parse(string inputString);
}