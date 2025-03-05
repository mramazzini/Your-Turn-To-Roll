using YourTurnToRoll.Core.Attributes;
using YourTurnToRoll.Core.Enums;

namespace YourTurnToRoll.Core.Interfaces.Character;

[EnumType(typeof(SpeciesType))]
public interface ISpecies
{
    string Name { get; set; }
    string Description { get; set; }
    public Dictionary<Ability, int> AbilityBonuses { get; set; }
    SpeciesType Type { get; set; }
}