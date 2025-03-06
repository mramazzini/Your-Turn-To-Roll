using Microsoft.Extensions.DependencyInjection;
using YourTurnToRoll.Core.Extensions;
using YourTurnToRoll.Core.Factories;
using YourTurnToRoll.Core.Interfaces.EnumType;
using YourTurnToRoll.Core.Services;
using YourTurnToRoll.Services;

namespace YourTurnToRoll.CLI;

internal static class Program
{
    private static void Main()
    {
        // Setup Dependency Injection
        var services = new ServiceCollection()
            .AddSingleton<IDiceService, DiceService>()
            .AddSingleton<ICharacterService, CharacterService>()
            .AddSingleton<IGameStateManager, GameStateManager>();

        services.RegisterInterfacesWithDi(typeof(IClass), typeof(IBackground), typeof(ISpecies), typeof(ICampaign),
            typeof(IDiceSet));

        var serviceProvider = services.BuildServiceProvider();
        var characterService = serviceProvider.GetService<ICharacterService>();
        var gameStateManager = serviceProvider.GetService<IGameStateManager>();
        FactoryInspector.PrintRegisteredFactories(serviceProvider);

        gameStateManager.Initialize();
    }
}