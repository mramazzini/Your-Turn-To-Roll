using YourTurnToRoll.Core.Enums;
using YourTurnToRoll.Core.Interfaces.Character;

namespace YourTurnToRoll.Core.Services;

public interface ICharacterService
{
    ICharacter GenerateCharacter(ISpecies species, IBackground background, IClass cClass);
    int RollAbilityScore(ICharacter character, Ability ability);
    int RollSkillScore(ICharacter character, Skill skill);
}