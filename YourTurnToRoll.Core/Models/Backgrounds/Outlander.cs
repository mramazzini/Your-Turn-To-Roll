using YourTurnToRoll.Core.Enums;
using YourTurnToRoll.Core.Interfaces;

namespace YourTurnToRoll.Core.Models.Backgrounds;

public class Outlander : BaseBackground
{
    public override BackgroundType Type { get; } = BackgroundType.Outlander;
    public override string Name { get; } = "Outlander";
    public override string Description { get; } = "Outlanders are a background in DND";
    public override List<Skill> SkillProficiencies { get; } = new();
    public override List<IItem> StartingItems { get; } = new();
}