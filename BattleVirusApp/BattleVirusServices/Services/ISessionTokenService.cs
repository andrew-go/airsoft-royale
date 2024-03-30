using BattleVirusRepositories.Repositories.Entities;

namespace BattleVirusServices.Services;

public interface ISessionTokenService
{
    Task<Session> GenerateSessionToken();
}
