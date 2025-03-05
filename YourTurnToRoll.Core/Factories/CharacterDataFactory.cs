using YourTurnToRoll.Core.Services;

namespace YourTurnToRoll.Core.Factories;

public class CharacterEnumsFactory<TEnum, TInterface> : IFactory<TEnum, TInterface> where TEnum : notnull
{
    private readonly Dictionary<TEnum, TInterface> _map;

    public CharacterEnumsFactory(IEnumerable<TInterface> classInstances)
    {
        _map = classInstances.ToDictionary(instance =>
        {
            var property = instance!.GetType().GetProperty("Type")
                           ?? throw new InvalidOperationException(
                               $"Instance {instance.GetType().Name} does not have a 'Type' property.");
            return (TEnum)property.GetValue(instance)!;
        });
    }

    public TInterface GetInstance(TEnum type)
    {
        if (_map.TryGetValue(type, out var instance)) return instance;
        throw new KeyNotFoundException($"No instance registered for {type}");
    }
}