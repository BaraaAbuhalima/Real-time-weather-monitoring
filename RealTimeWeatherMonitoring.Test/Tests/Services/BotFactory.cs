using RealTimeWeatherMonitoring.Models;
using Moq;
using FluentAssertions;
using RealTimeWeatherMonitoring.Models.Bots;
using RealTimeWeatherMonitoring.Services;

namespace RealTimeWeatherMonitoring.Test.Tests.Services;

public class BotFactoryTest
{
    private IBotFactory<BaseWeatherBot> BotFactory { get; init; }

    public BotFactoryTest()
    {
        BotFactory = new BotFactory<BaseWeatherBot>();
    }
    [Theory]
    [InlineData("RainBot")]
    [InlineData("SunBot")]
    [InlineData("SnowBot")]
    public void CreateWeatherBotWithValidBotNameAndConfigurations(string botName)
    {
        var config = new Mock<IBaseWeatherBotConfiguration>();
        var createdBot= BotFactory.Create(botName, config.Object);
        createdBot.Should().NotBeNull();
    }

}