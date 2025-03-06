using YourTurnToRoll.Core.Enums;
using YourTurnToRoll.Core.Interfaces.Creatures;
using YourTurnToRoll.Core.Services.Mappers;

// ReSharper disable MemberCanBePrivate.Global

namespace YourTurnToRoll.Core.Models.Creatures;

public abstract class BaseCreature : ICreature
{
    protected int HitPoints;
    protected int TempHitPoints;
    protected abstract CreatureType CreatureType { get; }

    protected abstract Dictionary<Ability, int> BaseAbilityScores { get; }

    protected virtual List<Skill> SkillProficiencies { get; } = new();
    protected virtual List<Ability> SavingThrowProficiencies { get; } = new();
    public bool IsAlive { get; set; }

    public virtual int GetAbilityScore(Ability ability)
    {
        return BaseAbilityScores.GetValueOrDefault(ability, 0);
    }

    public int GetAbilityModifier(Ability ability)
    {
        var score = GetAbilityScore(ability);
        // ReSharper disable once PossibleLossOfFraction
        return (int)Math.Floor((decimal)((score - 10) / 2));
    }

    public virtual int GetSkillScore(Skill skill)
    {
        var ability = SkillMapper.GetAbilityForSkill(skill);
        var isProficient = SkillProficiencies.Contains(skill);
        var modifier = GetAbilityModifier(ability);
        var profBonus = GetProficiencyBonus();

        return isProficient ? modifier + profBonus : modifier;
    }

    public virtual int GetSavingThrowScore(Ability ability)
    {
        var modifier = GetAbilityModifier(ability);
        var isProficient = SavingThrowProficiencies.Contains(ability);
        var profBonus = GetProficiencyBonus();
        return isProficient ? modifier + profBonus : modifier;
    }

    public abstract int GetProficiencyBonus();

    public virtual void TakeDamage(int damage)
    {
        if (TempHitPoints > 0)
        {
            TempHitPoints -= damage;
            if (TempHitPoints <= 0)
            {
                HitPoints += TempHitPoints;
                TempHitPoints = 0;
            }
        }

        if (HitPoints <= 0)
        {
            IsAlive = false;
            HitPoints = 0;
        }
    }

    public void ApplyTempHealth(int health)
    {
        TempHitPoints = health;
    }

    public virtual void Heal(int heal)
    {
        var maxHitPoints = CalcMaxHitPoints();
        HitPoints += heal;
        if (HitPoints > maxHitPoints) HitPoints = maxHitPoints;
    }

    public virtual void Initialize()
    {
        IsAlive = true;
        var maxHitPoints = CalcMaxHitPoints();
        HitPoints = maxHitPoints;
    }

    protected abstract int CalcMaxHitPoints();
}