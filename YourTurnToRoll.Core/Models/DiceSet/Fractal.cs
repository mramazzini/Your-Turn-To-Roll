using YourTurnToRoll.Core.Enums;

namespace YourTurnToRoll.Core.Models.DiceSet;

public class Fractal : BaseDiceSet
{
    public override string Name { get; set; } = "Fractal Dice";
    public override string Description { get; set; } = "Fractal Dice are a diceset";
    public override DiceSetType Type { get; set; } = DiceSetType.Fractal;
}