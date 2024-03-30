using BattleVirusRepositories.Repositories.Entities;

namespace BattleVirusRepositories.Repositories;

public class SessionTokenRepository : ISessionTokenRepository
{
    private readonly BattleVirusDbContext _dbContext;

    public SessionTokenRepository(BattleVirusDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Session> CreateSessionToken()
    {
        if (_dbContext.Sessions is null)
        {
            throw new Exception("Sessions table is not available");
        }

        var session = new Session();
        await _dbContext.Sessions.AddAsync(session);
        
        await _dbContext.SaveChangesAsync();

        return session;
    }
}
