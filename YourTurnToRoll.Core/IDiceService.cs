namespace YourTurnToRoll.Core;

public class IDiceService
{
    private Random _random = new Random();
    public int Roll(int sides) => _random.Next(1, sides + 1);
}