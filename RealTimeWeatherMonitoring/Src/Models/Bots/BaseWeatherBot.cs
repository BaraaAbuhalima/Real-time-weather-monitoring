using System.Runtime.CompilerServices;
using Real_time_weather_monitoring.Enums;
using Real_time_weather_monitoring.IO;
using Real_time_weather_monitoring.IO.ConsoleIO.Output;

namespace Real_time_weather_monitoring.Models.Bots;

public abstract class BaseWeatherBot:IBot
{

    public abstract BotDependency Depedency();
    public abstract BotType WeatherBotType();
    
    public WeatherBotConfiguration Configuration;

    public void Update(double threshold)
    {
        
        if (!Configuration.Enabled)
        {
            return;
        }
        if (Configuration.Threshold > threshold)
        {
            return;
        }
        StandardBotOutput.Message(this,Configuration.Message);
        
    }

}