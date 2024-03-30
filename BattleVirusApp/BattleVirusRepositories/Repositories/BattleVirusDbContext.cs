using BattleVirusRepositories.Repositories.Entities;
using Microsoft.EntityFrameworkCore;

namespace BattleVirusRepositories.Repositories;

public class BattleVirusDbContext : DbContext
{
    public BattleVirusDbContext(DbContextOptions<BattleVirusDbContext> options)
        : base(options)
    {
    }

    public DbSet<Session>? Sessions { get; set; }

    public DbSet<Game>? Games { get; set; }

    public DbSet<GameState>? GameStates { get; set; }
}
