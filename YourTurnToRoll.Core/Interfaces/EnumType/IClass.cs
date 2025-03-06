using YourTurnToRoll.Core.Attributes;
using YourTurnToRoll.Core.Enums;

namespace YourTurnToRoll.Core.Interfaces.EnumType;

[EnumType(typeof(ClassType))]
public interface IClass
{
    string Name { get; set; }
    string Description { get; set; }

    List<Skill> SkillProficiencies { get; }
    List<IItem> Items { get; set; }
    List<Ability> SavingThrowProficiencies { get; }
    ClassType Type { get; set; }
}