using BattleVirusRepositories.Repositories.Entities;

namespace BattleVirusRepositories.Repositories;

public class GameStateRepository : IGameStateRepository
{
    private readonly BattleVirusDbContext _dbContext;

    public GameStateRepository(BattleVirusDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task CreateUserGameStatus(GameState gameState)
    {
        if (_dbContext.GameStates is null)
        {
            throw new Exception("GameStates table is not available");
        }

        await _dbContext.GameStates.AddAsync(gameState);
        
        await _dbContext.SaveChangesAsync();
    }

    public GameState? GetGameStateBySession(Guid sessionToken)
    {
        if (_dbContext.GameStates is null)
        {
            throw new Exception("GameStates table is not available");
        }
        
        var gameState =  _dbContext.GameStates.FirstOrDefault(gs => gs.SessionToken == sessionToken);
        
        return gameState;
    }
}
