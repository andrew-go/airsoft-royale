using BattleVirusServices.Services;
using Microsoft.AspNetCore.Mvc;

namespace BattleVirusRest.Controllers;

[ApiController]
[Route("")]
public class GameStateController : ControllerBase
{
    private readonly IGameStateService _gameStateService;

    public GameStateController(IGameStateService gameStateService)
    {
        _gameStateService = gameStateService;
    }

    [HttpGet("game-state")]
    public ActionResult GetGameStateBySession([FromHeader(Name = "Authorization")] Guid sessionToken)
    {
        var gameState = _gameStateService.GetGameStateBySession(sessionToken);
        
        if (gameState is null)
        {
            return NotFound();
        }

        return Ok(gameState);
    }
}
