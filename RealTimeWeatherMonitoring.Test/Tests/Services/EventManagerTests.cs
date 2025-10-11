using Moq;
using Moq.AutoMock;
using RealTimeWeatherMonitoring.Enums;
using RealTimeWeatherMonitoring.Models;
using RealTimeWeatherMonitoring.Models.Bots;
using RealTimeWeatherMonitoring.Services;

namespace RealTimeWeatherMonitoring.Test.Tests.Services;

public class EventManagerTests
{
    private AutoMocker _mocker;
    public EventManagerTests()
    {
        _mocker=new AutoMocker();
    }
    [Theory]
    [InlineData(WeatherEvent.Reading)]
    public void NotifyingRainBotWithWeatherEventsAndWeatherDataToCheckIfItNotifyTheBot(WeatherEvent weatherEvent)
    {
 
        var eventManager = new EventManager<WeatherEvent,BaseWeatherBot,IWeatherData>();
        var subscriber = _mocker.GetMock<BaseWeatherBot>();
        var weatherData = _mocker.GetMock<IWeatherData>();
        
        eventManager.Subscribe(WeatherEvent.Reading,subscriber.Object);
        eventManager.Notify(weatherEvent,weatherData.Object);
        
        subscriber.Verify(s=>s.Update(weatherData.Object), Times.Once);
       
    }
}