using RealTimeWeatherMonitoring.Models;

namespace RealTimeWeatherMonitoring.Services;



public interface IEventManager<TEventType,TSubscriber,TData> 
    where TSubscriber: IEventListener<TData>
    where TEventType : notnull
{


    public void Subscribe(TEventType eventType, TSubscriber subscriber);

    public void Unsubscribe(TEventType eventType, TSubscriber subscriber);

    public void Notify(TEventType eventType, TData data);

}