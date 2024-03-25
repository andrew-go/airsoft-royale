using Microsoft.AspNetCore.Mvc;

namespace BattleVirusRest.Controllers;

[ApiController]
[Route("[controller]")]
public class LobbyController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<LobbyController> _logger;

    public LobbyController(ILogger<LobbyController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "JoinLobby")]
    public IActionResult Get()
    {
        return Ok();
    }
}
