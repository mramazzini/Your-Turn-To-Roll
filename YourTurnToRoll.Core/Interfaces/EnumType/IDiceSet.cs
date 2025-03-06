using YourTurnToRoll.Core.Attributes;
using YourTurnToRoll.Core.Enums;

namespace YourTurnToRoll.Core.Interfaces.EnumType;

[EnumType(typeof(DiceSetType))]
public interface IDiceSet
{
    string Name { get; set; }
    string Description { get; set; }
    DiceSetType Type { get; set; }
}