using YourTurnToRoll.Core.Attributes;
using YourTurnToRoll.Core.Enums;
using YourTurnToRoll.Core.Interfaces.Game;

namespace YourTurnToRoll.Core.Interfaces.EnumType;

[EnumType(typeof(CampaignType))]
public interface ICampaign
{
    public string Name { get; set; }
    public string Description { get; set; }
    public CampaignType Type { get; set; }
    public string Seed { get; set; }
    public IEncounter GenerateEncounter();
}