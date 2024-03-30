using BattleVirusRepositories.Repositories.Entities;

namespace BattleVirusServices.Services;

public interface IGameService
{
    // TODO: move to GameStateService
    Task JoinGame(Guid teamId, Guid gameId, Guid tokenSession);

    Task<Game> GetGame(Guid gameId);

    Task CreateGame(Game game);
}
