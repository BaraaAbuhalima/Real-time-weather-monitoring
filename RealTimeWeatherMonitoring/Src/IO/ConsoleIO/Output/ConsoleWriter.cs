namespace Real_time_weather_monitoring.IO.ConsoleIO.Output;

public class ConsoleWriter:IConsoleWriter
{
    public void Write(string content)
    {
        Console.WriteLine(content);
    }
}