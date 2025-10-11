using FluentAssertions;
using Moq;
using RealTimeWeatherMonitoring.Enums;
using RealTimeWeatherMonitoring.IO.WeatherDataIO;
using RealTimeWeatherMonitoring.Models;
using RealTimeWeatherMonitoring.Models.Bots;
using RealTimeWeatherMonitoring.Services;

namespace RealTimeWeatherMonitoring.Test.Tests.Services;

public class WeatherActionsTests
{
    private WeatherActions  _weatherActions;
    public WeatherActionsTests()
    {
        _weatherActions= new WeatherActions();
    }
    [Fact]
    public void ReadingWeatherUsingIDataConfigurationReaderToCheckIfItReadItAndNotifyTheSubscribers()
    {
        var reader = new Mock<IWeatherDataConfigurationReader>();
        var mockEventManager = new Mock<IEventManager<WeatherEvent, BaseWeatherBot, IWeatherData>>();
        _weatherActions.Events = mockEventManager.Object;
        
        _weatherActions.ReadWeather(reader.Object);
        
        reader.Verify(r => r.Read(), Times.Once);
        mockEventManager.Verify(e=>e.Notify(
        It.IsAny<WeatherEvent>(),It.IsAny<IWeatherData>())
                ,Times.Once);
    }
}