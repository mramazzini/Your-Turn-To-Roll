using YourTurnToRoll.Core.Enums;
using YourTurnToRoll.Core.Interfaces;
using YourTurnToRoll.Core.Interfaces.EnumType;
using YourTurnToRoll.Core.Services.Mappers;

namespace YourTurnToRoll.Core.Models.Creatures.Enemy;

public abstract class BaseEnemy : BaseCreature, IEnemy
{
    protected abstract double CombatRating { get; }
    protected abstract Size Size { get; }
    protected abstract int HitDieAmount { get; }
    protected abstract List<IItem> Items { get; }
    public abstract EnemyType Type { get; }

    public override int GetProficiencyBonus()
    {
        if (CombatRating <= 4) return 2;
        var mod = CombatRating % 4;
        // ReSharper disable once PossibleLossOfFraction
        var prof = (int)Math.Floor(CombatRating / 4) + 1;
        if (mod == 0) return prof;
        return prof + 1;
    }


    protected override int CalcMaxHitPoints()
    {
        var hitDie = SizeMapper.GetHitDieForSize(Size);
        var hitDieValue = DiceMapper.GetNumSides(hitDie);
        // ReSharper disable once PossibleLossOfFraction
        return (int)(Math.Floor(HitDieAmount * (hitDieValue / 2 + 0.5)) +
                     GetAbilityModifier(Ability.Constitution) * HitDieAmount);
    }
}