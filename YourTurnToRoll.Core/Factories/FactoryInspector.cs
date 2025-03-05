using YourTurnToRoll.Core.Enums;
using YourTurnToRoll.Core.Interfaces.Character;
using YourTurnToRoll.Core.Interfaces.Game;
using YourTurnToRoll.Core.Services;

namespace YourTurnToRoll.Core.Factories;

public static class FactoryInspector
{
    public static void PrintRegisteredFactories(IServiceProvider serviceProvider)
    {
        Console.WriteLine("\n--- Injected Factories and Implementations ---\n");

        var factoryTypes = new List<Type>
        {
            typeof(IFactory<ClassType, IClass>),
            typeof(IFactory<BackgroundType, IBackground>),
            typeof(IFactory<SpeciesType, ISpecies>),
            typeof(IFactory<CampaignType, ICampaign>)
        };

        foreach (var factoryType in factoryTypes)
        {
            // Retrieve the factory instance
            var factory = serviceProvider.GetService(factoryType);
            if (factory == null)
            {
                Console.WriteLine($"[ERROR] Factory not found for {factoryType.Name}");
                continue;
            }

            Console.WriteLine($"✅ Factory: {factoryType.Name}");

            // Use reflection to call GetInstance on the factory
            var enumType = factoryType.GenericTypeArguments[0];
            var interfaceType = factoryType.GenericTypeArguments[1];

            var enumValues = Enum.GetValues(enumType);
            foreach (var enumValue in enumValues)
                try
                {
                    var method = factoryType.GetMethod("GetInstance");
                    var instance = method.Invoke(factory, new[] { enumValue });

                    Console.WriteLine($"   - [{enumValue}] -> {instance.GetType().Name}");
                }
                catch
                {
                    Console.WriteLine($"   - [{enumValue}] -> ❌ No implementation found");
                }
        }

        Console.WriteLine("\n--- End of Factory List ---\n");
    }
}