using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BattleVirusRepositories.Repositories.Entities;

[Table("game_states")]
public class GameState
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public Guid Id { get; set; }
    
    [Column("session_token_id")]
    public Guid SessionToken { get; set; }

    [ForeignKey("games")]
    [Column("game_id")]
    public Guid GameId { get; set; }
    public Game? Game { get; set; }
    
    [Column("team_id")]
    public Guid TeamId { get; set; }
    
    [Column("status")]
    public TeamStatusType TeamStatus { get; set; }
}

public enum TeamStatusType
{
    Alive = 0,
    Vaccinated = 1,
    Dead = 2
}
