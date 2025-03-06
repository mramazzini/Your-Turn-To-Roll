using YourTurnToRoll.Core.Attributes;
using YourTurnToRoll.Core.Enums;
using YourTurnToRoll.Core.Interfaces.Creatures;

namespace YourTurnToRoll.Core.Interfaces.EnumType;

[EnumType(typeof(EnemyType))]
public interface IEnemy : ICreature
{
    EnemyType Type { get; }
}