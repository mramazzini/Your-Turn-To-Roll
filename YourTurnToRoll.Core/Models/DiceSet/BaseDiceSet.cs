using YourTurnToRoll.Core.Enums;
using YourTurnToRoll.Core.Interfaces.EnumType;

namespace YourTurnToRoll.Core.Models.DiceSet;

public abstract class BaseDiceSet : IDiceSet
{
    public abstract string Name { get; set; }
    public abstract string Description { get; set; }
    public abstract DiceSetType Type { get; set; }
}