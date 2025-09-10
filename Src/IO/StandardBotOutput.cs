using Real_time_weather_monitoring.IO.ConsoleIO.Output;
using Real_time_weather_monitoring.Models.Bots;

namespace Real_time_weather_monitoring.IO;

public static class StandardBotOutput
{
   private static readonly IConsoleWriter ConsoleWriter=new ConsoleWriter();
    public static void Message(BaseWeatherBot bot, string message)
    {
        var output= $"{bot.GetType().Name} activated!" +
               $"\n{message}";
        ConsoleWriter.Write(output);
    }
}