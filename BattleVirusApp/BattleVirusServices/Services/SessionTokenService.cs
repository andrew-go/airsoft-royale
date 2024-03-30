using BattleVirusRepositories.Repositories;
using BattleVirusRepositories.Repositories.Entities;

namespace BattleVirusServices.Services;

public class SessionTokenService : ISessionTokenService
{
    private readonly ISessionTokenRepository _sessionTokenRepository;

    public SessionTokenService(ISessionTokenRepository sessionTokenRepository)
    {
        _sessionTokenRepository = sessionTokenRepository;
    }

    public async Task<Session> GenerateSessionToken()
    {
        var session = await _sessionTokenRepository.CreateSessionToken();
        
        return session;
    }
}
