using YourTurnToRoll.Core.Enums;
using YourTurnToRoll.Core.Interfaces;

namespace YourTurnToRoll.Core.Models.Creatures.Enemy;

public class Worg : BaseEnemy
{
    protected override double CombatRating => 0.5;
    protected override Size Size => Size.Medium;
    protected override int HitDieAmount => 4;
    protected override List<IItem> Items { get; } = new();
    public override EnemyType Type => EnemyType.Worg;
    protected override CreatureType CreatureType => CreatureType.Beast;

    protected override Dictionary<Ability, int> BaseAbilityScores { get; } = new()
    {
        {
            Ability.Strength, 16
        },
        {
            Ability.Dexterity, 13
        },
        {
            Ability.Constitution, 13
        },
        {
            Ability.Intelligence, 7
        },
        {
            Ability.Wisdom, 11
        },
        {
            Ability.Charisma, 8
        }
    };
}