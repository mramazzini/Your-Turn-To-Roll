using YourTurnToRoll.Core.Enums;
using YourTurnToRoll.Core.Interfaces;

namespace YourTurnToRoll.Core.Models.Creatures.Enemy;

public class Goblin : BaseEnemy
{
    protected override double CombatRating => 0.25;
    protected override Size Size => Size.Small;
    protected override int HitDieAmount => 2;
    protected override List<IItem> Items { get; } = new();
    public override EnemyType Type => EnemyType.Goblin;
    protected override CreatureType CreatureType { get; } = CreatureType.Humanoid;

    protected override Dictionary<Ability, int> BaseAbilityScores { get; } = new()
    {
        {
            Ability.Strength, 8
        },
        {
            Ability.Dexterity, 14
        },
        {
            Ability.Constitution, 10
        },
        {
            Ability.Intelligence, 10
        },
        {
            Ability.Wisdom, 8
        },
        {
            Ability.Charisma, 8
        }
    };
}