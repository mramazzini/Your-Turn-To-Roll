using YourTurnToRoll.Core.Enums;

namespace YourTurnToRoll.Core.Services.Mappers;

public class SizeMapper
{
    private static readonly Dictionary<Size, DiceSideCount> SizeToHitdie = new()
    {
        { Size.Tiny, DiceSideCount.D4 },
        { Size.Small, DiceSideCount.D6 },
        { Size.Medium, DiceSideCount.D8 },
        { Size.Large, DiceSideCount.D10 },
        { Size.Huge, DiceSideCount.D12 },
        { Size.Gargantuan, DiceSideCount.D20 }
    };

    public static DiceSideCount GetHitDieForSize(Size size)
    {
        return SizeToHitdie.TryGetValue(size, out var value) ? value : 0;
    }
}