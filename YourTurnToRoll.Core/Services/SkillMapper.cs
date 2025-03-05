using YourTurnToRoll.Core.Enums;

namespace YourTurnToRoll.Core.Services;

public static class SkillMapper
{
    private static readonly Dictionary<Skill, Ability> SkillToAbility = new()
    {
        { Skill.Athletics, Ability.Strength },
        { Skill.Acrobatics, Ability.Dexterity },
        { Skill.Stealth, Ability.Dexterity },
        { Skill.SleightOfHand, Ability.Dexterity },
        { Skill.Arcana, Ability.Intelligence },
        { Skill.History, Ability.Intelligence },
        { Skill.Investigation, Ability.Intelligence },
        { Skill.Nature, Ability.Intelligence },
        { Skill.Religion, Ability.Intelligence },
        { Skill.AnimalHandling, Ability.Wisdom },
        { Skill.Insight, Ability.Wisdom },
        { Skill.Medicine, Ability.Wisdom },
        { Skill.Perception, Ability.Wisdom },
        { Skill.Survival, Ability.Wisdom },
        { Skill.Deception, Ability.Charisma },
        { Skill.Intimidation, Ability.Charisma },
        { Skill.Performance, Ability.Charisma },
        { Skill.Persuasion, Ability.Charisma }
    };

    public static Ability GetAbilityForSkill(Skill skill)
    {
        return SkillToAbility.GetValueOrDefault(skill);
    }
}