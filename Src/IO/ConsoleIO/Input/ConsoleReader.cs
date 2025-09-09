namespace Real_time_weather_monitoring.IO.ConsoleIO.Input;

public class ConsoleReader:IConsoleReader
{
    public string? Reader()
    {
        return Console.ReadLine();
    }
}