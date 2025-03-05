using YourTurnToRoll.Core.Enums;
using YourTurnToRoll.Core.Interfaces;
using YourTurnToRoll.Core.Interfaces.Character;

namespace YourTurnToRoll.Core.Models.Classes;

public abstract class BaseClass : IClass
{
    public abstract ClassType Type { get; set; }
    public abstract string Name { get; set; }
    public abstract string Description { get; set; }
    public abstract List<Skill> SkillProficiencies { get; set; }
    public abstract List<IItem> Items { get; set; }
    public abstract List<Ability> SavingThrowProficiencies { get; set; }
}