using YourTurnToRoll.Core.Enums;

namespace YourTurnToRoll.Core.Models.Species;

public class Human : BaseSpecies
{
    public override string Description { get; set; } = "Human's are a Species in DND";
    public override SpeciesType Type { get; set; } = SpeciesType.Human;

    public override Dictionary<Ability, int> AbilityBonuses { get; set; } = new()
    {
        {
            Ability.Charisma, 1
        },
        {
            Ability.Dexterity, 1
        },
        {
            Ability.Intelligence, 1
        },
        {
            Ability.Strength, 1
        },
        {
            Ability.Wisdom, 1
        },
        {
            Ability.Constitution, 1
        }
    };

    public override string Name { get; set; } = "Human";
}