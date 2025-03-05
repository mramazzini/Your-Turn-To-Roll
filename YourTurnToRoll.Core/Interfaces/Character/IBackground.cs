using YourTurnToRoll.Core.Attributes;
using YourTurnToRoll.Core.Enums;

namespace YourTurnToRoll.Core.Interfaces.Character;

[EnumType(typeof(BackgroundType))]
public interface IBackground
{
    string Name { get; }
    string Description { get; }
    BackgroundType Type { get; }
    List<Skill> SkillProficiencies { get; }
    List<IItem> StartingItems { get; }
}