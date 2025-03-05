using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using YourTurnToRoll.Core.Attributes;
using YourTurnToRoll.Core.Factories;
using YourTurnToRoll.Core.Services;

namespace YourTurnToRoll.Core.Extensions;

public static class ServiceCollectionExtensions
{
    public static void RegisterInterfacesWithDi(this IServiceCollection services, params Type[] interfaceTypes)
    {
        var assembly = Assembly.GetExecutingAssembly();
        foreach (var interfaceType in interfaceTypes)
        {
            var implementations = assembly.GetTypes()
                .Where(t => interfaceType.IsAssignableFrom(t) && t.IsClass && !t.IsAbstract);

            foreach (var implType in implementations) services.AddSingleton(interfaceType, implType);

            // Register the corresponding factory dynamically
            var factoryType = typeof(IFactory<,>).MakeGenericType(GetEnumType(interfaceType), interfaceType);
            var concreteFactoryType =
                typeof(CharacterEnumsFactory<,>).MakeGenericType(GetEnumType(interfaceType), interfaceType);

            services.AddSingleton(factoryType, concreteFactoryType);
        }
    }

    private static Type GetEnumType(Type interfaceType)
    {
        var attribute = interfaceType.GetCustomAttribute<EnumTypeAttribute>();
        return attribute?.EnumType
               ?? throw new InvalidOperationException($"No EnumTypeAttribute found for {interfaceType.Name}");
    }
}