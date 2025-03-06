using YourTurnToRoll.Core.Enums;

namespace YourTurnToRoll.Core.Interfaces.Creatures;

public interface ICreature
{
    public bool IsAlive { get; set; }
    public void Initialize();
    public int GetAbilityScore(Ability ability);
    public int GetAbilityModifier(Ability ability);
    public int GetSkillScore(Skill skill);
    public int GetSavingThrowScore(Ability ability);
    public int GetProficiencyBonus();
    public void TakeDamage(int damage);
    public void ApplyTempHealth(int health);
    public void Heal(int heal);
}