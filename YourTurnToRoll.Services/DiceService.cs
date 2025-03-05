using YourTurnToRoll.Core.Services;

namespace YourTurnToRoll.Services;

public class DiceService : IDiceService
{
    private readonly Random _random = new();

    public int Roll(int sides)
    {
        return _random.Next(1, sides);
    }
}