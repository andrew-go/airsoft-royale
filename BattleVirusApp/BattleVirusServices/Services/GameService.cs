using BattleVirusRepositories.Repositories;
using BattleVirusRepositories.Repositories.Entities;

namespace BattleVirusServices.Services;

public class GameService : IGameService
{
    private readonly IGameRepository _gameRepository;
    private readonly IGameStateRepository _gameStateRepository;

    public GameService(IGameRepository gameRepository, IGameStateRepository gameStateRepository)
    {
        _gameRepository = gameRepository;
        _gameStateRepository = gameStateRepository;
    }

    public async Task JoinGame(Guid teamId, Guid gameId, Guid tokenSession)
    {
        await _gameStateRepository.CreateUserGameStatus(new GameState
        {
            SessionToken = tokenSession,
            TeamId = teamId,
            GameId = gameId
        });
    }

    public async Task<Game> GetGame(Guid gameId)
    {
        return await _gameRepository.GetGame(gameId);
    }

    public async Task CreateGame(Game game)
    {
        await _gameRepository.CreateGame(game);
    }
}
