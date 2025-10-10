using RealTimeWeatherMonitoring.Models;
namespace RealTimeWeatherMonitoring.Services;

public interface IBotFactory<out TBot>
{
    
    public TBot Create(string botName, IBotConfiguration configuration);
    
}