using YourTurnToRoll.Core.Enums;

namespace YourTurnToRoll.Core.Models.Campaigns;

public class WoodlandStroll : BaseCampaign
{
    public override string Name { get; set; } = "Woodland Stroll";
    public override string Description { get; set; } = "Woodland Stroll is a Campaign";
    public override CampaignType Type { get; set; } = CampaignType.WoodlandStroll;
    public new required string Seed { get; set; }
}