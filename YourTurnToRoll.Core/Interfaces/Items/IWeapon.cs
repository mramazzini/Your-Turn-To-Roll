using YourTurnToRoll.Core.Enums;

namespace YourTurnToRoll.Core.Interfaces;

public interface IWeapon
{
    string Name { get; }
    string Description { get; }

    RangedOrMelee RangedOrMelee { get; }
    WeaponComplexity Complexity { get; }
}