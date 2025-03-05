using YourTurnToRoll.Core.Enums;
using YourTurnToRoll.Core.Interfaces;

namespace YourTurnToRoll.Core.Models.Classes;

public class Bard : BaseClass
{
    public override ClassType Type { get; set; } = ClassType.Bard;
    public override string Name { get; set; } = "Bard";
    public override string Description { get; set; } = "Bard is a class in dnd";
    public override List<Skill> SkillProficiencies { get; set; } = new();
    public override List<IItem> Items { get; set; } = new();
    public override List<Ability> SavingThrowProficiencies { get; set; } = new();
}