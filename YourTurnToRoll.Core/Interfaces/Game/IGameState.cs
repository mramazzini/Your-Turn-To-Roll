using YourTurnToRoll.Core.Interfaces.Character;

namespace YourTurnToRoll.Core.Interfaces.Game;

public interface IGameState
{
    ICampaign? Campaign { get; set; }
    IEncounter? CurrentEncounter { get; set; }
    List<ICharacter> Party { get; set; }
    List<string> RollHistory { get; set; }
    public int ProgressionLevel { get; set; }
    public void AddRoll(string rollResult);
    public void AdvanceProgress();
}