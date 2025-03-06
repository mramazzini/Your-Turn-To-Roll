using YourTurnToRoll.Core.Enums;
using YourTurnToRoll.Core.Interfaces;
using YourTurnToRoll.Core.Interfaces.EnumType;

namespace YourTurnToRoll.Core.Models.Backgrounds;

public abstract class BaseBackground : IBackground
{
    public abstract BackgroundType Type { get; }
    public abstract List<Skill> SkillProficiencies { get; }
    public abstract List<IItem> StartingItems { get; }
    public abstract string Name { get; }
    public abstract string Description { get; }
}