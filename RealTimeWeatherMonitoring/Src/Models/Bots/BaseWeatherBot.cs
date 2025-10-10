using RealTimeWeatherMonitoring.Enums;
using RealTimeWeatherMonitoring.IO.Output;
using RealTimeWeatherMonitoring.Services;
using RealTimeWeatherMonitoring.Utils;

namespace RealTimeWeatherMonitoring.Models.Bots;

public abstract class BaseWeatherBot:IBot,IEventListener <WeatherData>
{

    public abstract BotDependency Dependency { get;  }

    public required WeatherBotConfiguration Configuration { get; set; }

    protected BaseWeatherBot(WeatherBotConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void Update(WeatherData weatherData)
    {
        
        if (!Configuration.Enabled)
        {
            return;
        }

        if (Configuration.Threshold > WeatherBotDependencyResolver.GetThreshold(this, weatherData)) 
        {
            return;
        }
        
        Message( Configuration.Message);
    }

    private void Message(string message)
    {
        var writer=new ConsoleWriter();
        var output= $"{this.GetType().Name} activated!" +
                        $"\n{this.GetType().Name} : {message}";
        writer.Write(output);
    }
    
}