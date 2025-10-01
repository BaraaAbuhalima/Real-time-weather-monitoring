using Microsoft.Extensions.DependencyInjection;
using Real_time_weather_monitoring.Models;
using Real_time_weather_monitoring.Parsers;

namespace Real_time_weather_monitoring.Containers;

public class DataParserContainer<T>
{
    private readonly ServiceProvider _serviceProvider=Initialize();

    private static ServiceProvider Initialize()
    {
        var services = new ServiceCollection();
        services.AddSingleton(new XmlParser<T>());
        services.AddSingleton(new JSONParser<T>());
        return services.BuildServiceProvider();
    } 
    public TParser GetWeatherParser<TParser>() where TParser:IDataParser<T>
    {
        return _serviceProvider.GetService<TParser>()!;
    }
    
}

