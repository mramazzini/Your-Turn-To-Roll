using YourTurnToRoll.Core.Enums;
using YourTurnToRoll.Core.Interfaces.Character;
using YourTurnToRoll.Core.Interfaces.EnumType;
using YourTurnToRoll.Core.Services;

namespace YourTurnToRoll.Core.Models;

public class Character(string name, ISpecies species, IClass cClass, IBackground background) : ICharacter
{
    public int Id { get; set; } = 1;
    public string Name { get; set; } = name;
    public ISpecies Species { get; set; } = species;
    public IBackground Background { get; set; } = background;
    public IClass Class { get; set; } = cClass;

    public int GetAbilityScore(Ability ability)
    {
        return 10 + Species.AbilityBonuses[ability];
    }

    public int GetSkillScore(Skill skill)
    {
        var ability = SkillMapper.GetAbilityForSkill(skill);
        return GetAbilityScore(ability);
    }
}