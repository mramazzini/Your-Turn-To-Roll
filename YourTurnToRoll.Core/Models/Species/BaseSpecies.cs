using YourTurnToRoll.Core.Enums;
using YourTurnToRoll.Core.Interfaces.EnumType;

namespace YourTurnToRoll.Core.Models.Species;

public abstract class BaseSpecies : ISpecies
{
    public abstract Dictionary<Ability, int> AbilityBonuses { get; set; }
    public abstract string Name { get; set; }
    public abstract string Description { get; set; }
    public abstract SpeciesType Type { get; set; }
}