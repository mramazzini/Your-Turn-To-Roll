using YourTurnToRoll.Core.Enums;
using YourTurnToRoll.Core.Interfaces.Character;
using YourTurnToRoll.Core.Models;
using YourTurnToRoll.Core.Services;

namespace YourTurnToRoll.Services;

public class CharacterService : ICharacterService
{
    private readonly IDiceService _diceService;

    public CharacterService(IDiceService diceService)
    {
        _diceService = diceService;
    }

    public int RollAbilityScore(ICharacter character, Ability ability)
    {
        var roll = _diceService.Roll(20);
        return roll + character.GetAbilityScore(ability);
    }

    public int RollSkillScore(ICharacter character, Skill skill)
    {
        var roll = _diceService.Roll(20);
        return roll + character.GetSkillScore(skill);
    }

    public ICharacter GenerateCharacter(ISpecies species, IBackground background, IClass cClass)
    {
        return new Character("Bob", species, cClass, background);
    }
}