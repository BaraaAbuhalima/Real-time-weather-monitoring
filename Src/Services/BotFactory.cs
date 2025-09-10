using Real_time_weather_monitoring.Models.Bots;

namespace Real_time_weather_monitoring.Services;

public static  class BotFactory
{
    private static readonly string Namespace = "Real_time_weather_monitoring.Models.Bots";

    public static BaseWeatherBot? CreateBot(string botName, BaseWeatherBot config)
    {
        var botType = Type.GetType($"{Namespace}.{botName}");
        if (botType == null || !typeof(BaseWeatherBot).IsAssignableFrom(botType))
            return null;

        return (BaseWeatherBot)Activator.CreateInstance(
            botType,
            config.Enabled,
            config.Threshold,
            config.Message
        )!;
    }
}