using YourTurnToRoll.Core.Enums;
using YourTurnToRoll.Core.Interfaces.EnumType;
using YourTurnToRoll.Core.Interfaces.Game;

namespace YourTurnToRoll.Core.Models.Campaigns;

public abstract class BaseCampaign : ICampaign
{
    public abstract string Name { get; set; }
    public abstract string Description { get; set; }
    public abstract CampaignType Type { get; set; }
    public string Seed { get; set; } = "";

    public IEncounter GenerateEncounter()
    {
        throw new NotImplementedException();
    }
}