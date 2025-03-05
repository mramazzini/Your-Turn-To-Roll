using YourTurnToRoll.Core.Enums;
using YourTurnToRoll.Core.Interfaces;

namespace YourTurnToRoll.Core.Models.Classes;

public class Barbarian : BaseClass
{
    public override string Name { get; set; } = "Barbarian";
    public override string Description { get; set; } = "Barbarian";
    public override List<Skill> SkillProficiencies { get; set; } = new();
    public override List<IItem> Items { get; set; } = new();
    public override List<Ability> SavingThrowProficiencies { get; set; } = new();
    public override ClassType Type { get; set; } = ClassType.Barbarian;
    public List<Ability> Abilities { get; set; } = [];
    public List<Skill> Skills { get; set; } = [];
}