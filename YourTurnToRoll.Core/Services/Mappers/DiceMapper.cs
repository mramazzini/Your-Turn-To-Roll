using YourTurnToRoll.Core.Enums;

namespace YourTurnToRoll.Core.Services.Mappers;

public class DiceMapper
{
    private static readonly Dictionary<DiceSideCount, int> DiceSideToValue = new()
    {
        { DiceSideCount.D4, 4 },
        { DiceSideCount.D6, 6 },
        { DiceSideCount.D8, 8 },
        { DiceSideCount.D10, 10 },
        { DiceSideCount.D12, 12 },
        { DiceSideCount.D20, 20 }
    };

    public static int GetNumSides(DiceSideCount size)
    {
        return DiceSideToValue[size];
    }
}