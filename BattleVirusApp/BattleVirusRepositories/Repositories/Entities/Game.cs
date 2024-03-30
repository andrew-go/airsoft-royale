using System.ComponentModel.DataAnnotations.Schema;

namespace BattleVirusRepositories.Repositories.Entities;

[Table("games")]
public class Game
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("zone_level")]
    public int ZoneLevel { get; set; }
    
    [Column("zone_duration_in_minutes")]
    public int ZoneDurationInMinutes { get; set; }
    
    [Column("start_time")]
    public DateTime StartTime { get; set; }
    
    // TODO: Game type
}
