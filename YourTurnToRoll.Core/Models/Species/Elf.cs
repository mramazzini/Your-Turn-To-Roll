using YourTurnToRoll.Core.Enums;

namespace YourTurnToRoll.Core.Models.Species;

public class Elf : BaseSpecies
{
    public override Dictionary<Ability, int> AbilityBonuses { get; set; } = new()
    {
        {
            Ability.Dexterity, 2
        }
    };

    public override string Name { get; set; } = "Elf";
    public override string Description { get; set; } = "Elves are a Species in DND";
    public override SpeciesType Type { get; set; } = SpeciesType.Elf;
}