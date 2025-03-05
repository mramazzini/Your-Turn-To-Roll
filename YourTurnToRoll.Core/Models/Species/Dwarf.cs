using YourTurnToRoll.Core.Enums;

namespace YourTurnToRoll.Core.Models.Species;

public class Dwarf : BaseSpecies
{
    public override string Description { get; set; } = "Dwarf";

    public override Dictionary<Ability, int> AbilityBonuses { get; set; } = new()
    {
        { Ability.Constitution, 2 }
    };

    public override string Name { get; set; } = "Dwarf";
    public override SpeciesType Type { get; set; } = SpeciesType.Dwarf;
}