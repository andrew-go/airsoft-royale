using BattleVirusRepositories.Repositories.Entities;

namespace BattleVirusServices.Services;

public interface IGameStateService
{
    GameState? GetGameStateBySession(Guid sessionToken);
}
