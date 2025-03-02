using YourTurnToRoll.Core.Services;

namespace YourTurnToRoll.Services;

public class DiceService: IDiceService
{
    public int Roll(int sides)
    {
        return sides;
    }
}