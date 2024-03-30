using BattleVirusRepositories.Repositories.Entities;
using BattleVirusServices.Services;
using Microsoft.AspNetCore.Mvc;

namespace BattleVirusRest.Controllers;

[ApiController]
[Route("")]
public class GameController : ControllerBase
{
    private readonly IGameService _gameService;

    public GameController(IGameService gameService)
    {
        _gameService = gameService;
    }
    
    [HttpGet("games/{gameId:guid}")]
    public async Task<IActionResult> GetGame(Guid gameId)
    {
        var game = await _gameService.GetGame(gameId);
        return Ok(game);
    }

    [HttpPost("games")]
    public async Task<IActionResult> CreateGame(Game game)
    {
        await _gameService.CreateGame(game);
        return Ok();
    }

    [HttpGet("games/{gameId:guid}/teams/{teamId:guid}/join")]
    public async Task<IActionResult> JoinGame(Guid gameId, Guid teamId, [FromHeader(Name = "Authorization")] Guid tokenSession)
    {
        await _gameService.JoinGame(teamId, gameId, tokenSession);
        return Ok();
    }
}
