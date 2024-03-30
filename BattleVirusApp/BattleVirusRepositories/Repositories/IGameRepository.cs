using BattleVirusRepositories.Repositories.Entities;

namespace BattleVirusRepositories.Repositories;

public interface IGameRepository
{
    Task CreateGame(Game game);

    Task<Game> GetGame(Guid gameId);
}
