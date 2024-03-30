using BattleVirusRepositories.Repositories.Entities;

namespace BattleVirusRepositories.Repositories;

public interface ISessionTokenRepository
{
    Task<Session> CreateSessionToken();
}
