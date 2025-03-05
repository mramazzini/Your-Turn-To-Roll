using YourTurnToRoll.Core.Enums;
using YourTurnToRoll.Core.Interfaces.Character;
using YourTurnToRoll.Core.Interfaces.Game;
using YourTurnToRoll.Core.Models.GameState;
using YourTurnToRoll.Core.Services;

namespace YourTurnToRoll.Services;

public class GameStateManager : IGameStateManager
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

    public void BeginCampaign(CampaignType campaignType)
    {
        //Generate campaign seed
        //Store in game state
    }

    public IEncounter GenerateEncounter()
    {
        throw new NotImplementedException();
    }

    public void BeginEncounter(IEncounter encounter)
    {
        throw new NotImplementedException();
    }

    public void SelectDiceSet(DiceSetType diceSetType)
    {
        throw new NotImplementedException();
    }

    public List<IEncounterPreview> GenerateEncounterPreviews()
    {
        //use campaign seed to generate encounters
        throw new NotImplementedException();
    }
}