using BattleVirusRepositories.Repositories.Entities;
using Microsoft.EntityFrameworkCore;

namespace BattleVirusRepositories.Repositories;

public class GameRepository : IGameRepository
{
    private readonly BattleVirusDbContext _dbContext;

    public GameRepository(BattleVirusDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task CreateGame(Game game)
    {
        if (_dbContext.Games is null)
        {
            throw new Exception("Games table is not available");
        }

        _dbContext.Games.Add(game);
        return _dbContext.SaveChangesAsync();
    }

    public async Task<Game> GetGame(Guid gameId)
    {
        if (_dbContext.Games is null)
        {
            throw new Exception("Games table is not available");
        }

        var game = await _dbContext.Games.FirstOrDefaultAsync(game => game.Id == gameId);
        
        if (game is null)
        {
            throw new Exception("Game not found");
        }

        return game;
    }
}
