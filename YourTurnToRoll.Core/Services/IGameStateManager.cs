using YourTurnToRoll.Core.Enums;
using YourTurnToRoll.Core.Interfaces.Character;
using YourTurnToRoll.Core.Interfaces.Game;

namespace YourTurnToRoll.Core.Services;

public interface IGameStateManager
{
    protected IGameState State { get; set; }
    public void Initialize();

    public void AddToParty(ICharacter character);

    public void BeginCampaign(CampaignType campaignType, string Seed);
    public void BeginEncounter(IEncounter encounter);
    public void SelectDiceSet(DiceSetType diceSetType);
}