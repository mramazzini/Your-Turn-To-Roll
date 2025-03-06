using YourTurnToRoll.Core.Enums;
using YourTurnToRoll.Core.Interfaces.Character;
using YourTurnToRoll.Core.Interfaces.EnumType;
using YourTurnToRoll.Core.Models;
using YourTurnToRoll.Core.Services;

namespace YourTurnToRoll.Services;

public class CharacterService(IDiceService diceService) : ICharacterService
{
    public int RollAbilityScore(ICharacter character, Ability ability)
    {
        var roll = diceService.Roll(20);
        return roll + character.GetAbilityScore(ability);
    }

    public int RollSkillScore(ICharacter character, Skill skill)
    {
        var roll = diceService.Roll(20);
        return roll + character.GetSkillScore(skill);
    }

    public ICharacter GenerateCharacter(ISpecies species, IBackground background, IClass cClass)
    {
        return new Character("Bob", species, cClass, background);
    }
}