namespace YourTurnToRoll.Core.Services;

public interface IFactory<in TEnum, out TInterface>
{
    public TInterface GetInstance(TEnum type);
}