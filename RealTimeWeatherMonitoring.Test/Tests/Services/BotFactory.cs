using RealTimeWeatherMonitoring.Models;
using Moq;
using FluentAssertions;
using RealTimeWeatherMonitoring.Models.Bots;
using RealTimeWeatherMonitoring.Services;

namespace RealTimeWeatherMonitoring.Test.Tests.Services;

public class BotFactoryTest
{
   
    [Theory]
    [InlineData("RainBot")]
    [InlineData("SunBot")]
    [InlineData("SnowBot")]
    public void CreateWeatherBotWithValidBotNameAndConfigurations(string botName)
    {
        
        var config = new Mock<IBaseWeatherBotConfiguration>();
        var botFactory = new BotFactory<BaseWeatherBot>();
        var createdBot= botFactory.Create(botName, config.Object);
        createdBot.Should().NotBeNull();
    }

}