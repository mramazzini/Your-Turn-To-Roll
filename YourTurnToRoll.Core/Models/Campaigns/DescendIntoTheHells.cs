using YourTurnToRoll.Core.Enums;

namespace YourTurnToRoll.Core.Models.Campaigns;

public class DescendIntoTheHells : BaseCampaign
{
    public override string Name { get; set; } = "Descend Into The Hells";
    public override string Description { get; set; } = "Descend Into The Hells";
    public override CampaignType Type { get; set; } = CampaignType.DescentIntoTheHells;
    public new required string Seed { get; set; }
}