using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BattleVirusRepositories.Repositories.Entities;

[Table("sessions")]
public class Session
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("session_token_id")]
    public Guid SessionTokenId { get; set; }
}
