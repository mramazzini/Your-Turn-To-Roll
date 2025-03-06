using YourTurnToRoll.Core.Enums;

namespace YourTurnToRoll.Core.Models.Campaigns;

public class AquaticBlast : BaseCampaign
{
    public override string Name { get; set; } = "Aquatic Blast";
    public override string Description { get; set; } = "Aquatic Blast is a Campaign";
    public override CampaignType Type { get; set; } = CampaignType.AquaticBlast;
    public new required string Seed { get; set; }
}