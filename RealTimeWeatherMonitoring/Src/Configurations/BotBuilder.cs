using RealTimeWeatherMonitoring.IO.BotsConfigurationsIO;
using RealTimeWeatherMonitoring.Models;
using RealTimeWeatherMonitoring.Models.Bots;
using RealTimeWeatherMonitoring.Services;

namespace RealTimeWeatherMonitoring.Configurations;

public class BotsBuilder<TBot> where TBot : IBot
{
    private readonly  IBotFactory<TBot> _botFactory;
    private readonly IBotsConfigurationsReader _configurationsReader;
    
    public BotsBuilder(IBotFactory<TBot> botFactory, IBotsConfigurationsReader reader)
    {
        _botFactory=botFactory;
        _configurationsReader = reader;
    }
    
    public List<TBot> CreatBots()
    {

        var botConfigurations = _configurationsReader.GetConfigurations();
        return botConfigurations.Select(bot => _botFactory.Create(bot.Key, bot.Value))
                .ToList();
        
    }
}

