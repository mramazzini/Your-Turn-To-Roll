using YourTurnToRoll.Core.Enums;
using YourTurnToRoll.Core.Interfaces.Character;
using YourTurnToRoll.Core.Interfaces.EnumType;
using YourTurnToRoll.Core.Interfaces.Game;
using YourTurnToRoll.Core.Models.GameState;
using YourTurnToRoll.Core.Services;

namespace YourTurnToRoll.Services;

public class GameStateManager(
    IFactory<CampaignType, ICampaign> campaignFactory,
    IFactory<DiceSetType, IDiceSet> dicesetFactory) : IGameStateManager
{
    public IGameState State { get; set; } = null!;

    public void Initialize()
    {
        State = new GameState();
        Console.WriteLine("Initializing game state");
    }

    public void AddToParty(ICharacter character)
    {
        State.Party.Add(character);
    }

    public void BeginCampaign(CampaignType campaignType, string seed)
    {
        var campaign = campaignFactory.GetInstance(campaignType);
        campaign.Seed = seed;
        State.Campaign = campaign;
    }


    public void BeginEncounter(IEncounter encounter)
    {
        var e = State.Campaign?.GenerateEncounter();
        State.CurrentEncounter = e;
    }

    public void SelectDiceSet(DiceSetType diceSetType)
    {
        var dice = dicesetFactory.GetInstance(diceSetType);
        State.DiceSet = dice;
    }

    public List<IEncounterPreview> GenerateEncounterPreviews()
    {
        //use campaign seed to generate encounters
        throw new NotImplementedException();
    }
}