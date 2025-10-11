using RealTimeWeatherMonitoring.Models;

namespace RealTimeWeatherMonitoring.Services;

public class EventManager<TEventType,TSubscriber,TData> : IEventManager<TEventType,TSubscriber,TData>
    where TSubscriber: IEventListener<TData>
    where TEventType : notnull
{
   
    private SortedDictionary<TEventType,SortedDictionary<int,TSubscriber>> Listeners { get; }
    
    public EventManager()
    {
        Listeners=[];
    }

    public void Subscribe(TEventType eventType ,TSubscriber subscriber)
    {
        if (!Listeners.ContainsKey(eventType))
        {
            Listeners[eventType] = [];
        }
        Listeners[eventType].Add(subscriber.GetHashCode(),subscriber);
    }
    
    public void Unsubscribe(TEventType eventType,TSubscriber subscriber)
    {
        Listeners[eventType].Remove(subscriber.GetHashCode());
    }
    
    public void Notify(TEventType eventType,TData data)
    {
        foreach (var listener in Listeners[eventType])
        {
            listener.Value.Update(data);
        }

    }
    
}