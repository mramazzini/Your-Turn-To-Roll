using YourTurnToRoll.Core.Enums;
using YourTurnToRoll.Core.Interfaces;

namespace YourTurnToRoll.Core.Models.Classes;

public class Cleric : BaseClass
{
    public override ClassType Type { get; set; } = ClassType.Cleric;
    public override string Name { get; set; } = "Cleric";
    public override string Description { get; set; } = "Clerics are a class in DND";
    public override List<Skill> SkillProficiencies { get; set; } = new();
    public override List<IItem> Items { get; set; } = new();
    public override List<Ability> SavingThrowProficiencies { get; set; } = new();
}