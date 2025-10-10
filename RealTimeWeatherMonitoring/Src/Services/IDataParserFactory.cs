using RealTimeWeatherMonitoring.Enums;
using RealTimeWeatherMonitoring.Parsers;

namespace RealTimeWeatherMonitoring.Services;

public interface IDataParserFactory<out T>
{
    public IDataParser<T> Create(DataFormat dataFormat);
}