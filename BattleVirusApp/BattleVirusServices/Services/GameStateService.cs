using BattleVirusRepositories.Repositories;
using BattleVirusRepositories.Repositories.Entities;

namespace BattleVirusServices.Services;

public class GameStateService : IGameStateService
{
    private readonly IGameStateRepository _gameStateRepository;

    public GameStateService(IGameStateRepository gameStateRepository)
    {
        _gameStateRepository = gameStateRepository;
    }

    public GameState? GetGameStateBySession(Guid sessionToken)
    {
        return _gameStateRepository.GetGameStateBySession(sessionToken);
    }
}
