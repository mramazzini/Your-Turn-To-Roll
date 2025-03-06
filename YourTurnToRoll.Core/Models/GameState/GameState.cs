using YourTurnToRoll.Core.Interfaces.Character;
using YourTurnToRoll.Core.Interfaces.EnumType;
using YourTurnToRoll.Core.Interfaces.Game;

namespace YourTurnToRoll.Core.Models.GameState;

public class GameState : IGameState
{
    public ICampaign? Campaign { get; set; }
    public List<ICharacter> Party { get; set; } = [];
    public IEncounter? CurrentEncounter { get; set; }
    public List<string> RollHistory { get; set; } = [];
    public IDiceSet DiceSet { get; set; } = null!;
    public int ProgressionLevel { get; set; }
}