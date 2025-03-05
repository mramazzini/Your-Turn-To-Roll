using YourTurnToRoll.Core.Enums;

namespace YourTurnToRoll.Core.Interfaces.Character;

public interface ICharacter
{
    public int Id { get; set; }
    public string Name { get; set; }

    public ISpecies Species { get; set; }
    public IBackground Background { get; set; }
    public IClass Class { get; set; }

    public int GetAbilityScore(Ability ability);
    public int GetSkillScore(Skill skill);
}