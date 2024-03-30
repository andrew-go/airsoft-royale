using BattleVirusRepositories.Repositories.Entities;

namespace BattleVirusRepositories.Repositories;

public interface IGameStateRepository
{
    Task CreateUserGameStatus(GameState gameState);

    GameState? GetGameStateBySession(Guid sessionToken);
}
