using YourTurnToRoll.Core.Enums;

namespace YourTurnToRoll.Core.Models.DiceSet;

public class Wooden : BaseDiceSet
{
    public override string Name { get; set; } = "Wooden Dice";
    public override string Description { get; set; } = "Wooden Dice are a diceset";
    public override DiceSetType Type { get; set; } = DiceSetType.Wooden;
}