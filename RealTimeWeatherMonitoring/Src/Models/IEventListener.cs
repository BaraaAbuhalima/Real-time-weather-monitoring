namespace RealTimeWeatherMonitoring.Models;

public interface IEventListener<in TEventType>
{
    public void Update(TEventType context);
}