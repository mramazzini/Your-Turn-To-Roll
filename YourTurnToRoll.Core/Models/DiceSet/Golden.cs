using YourTurnToRoll.Core.Enums;

namespace YourTurnToRoll.Core.Models.DiceSet;

public class Golden : BaseDiceSet
{
    public override string Name { get; set; } = "Golden Dice";
    public override string Description { get; set; } = "Golden Dice are a diceset";
    public override DiceSetType Type { get; set; } = DiceSetType.Golden;
}