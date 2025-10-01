namespace Real_time_weather_monitoring.IO.ConsoleIO.Input;

public class ConsoleReader:IConsoleReader
{
    public string? Read()
    {
        return Console.ReadLine();
    }
}