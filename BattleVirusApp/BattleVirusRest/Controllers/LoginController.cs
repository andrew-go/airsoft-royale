using BattleVirusServices.Services;
using Microsoft.AspNetCore.Mvc;

namespace BattleVirusRest.Controllers;

[ApiController]
[Route("")]
public class LoginController : ControllerBase
{
    private readonly ISessionTokenService _sessionTokenService;

    public LoginController(ISessionTokenService sessionTokenService)
    {
        _sessionTokenService = sessionTokenService;
    }

    // Mock method to validate team code and generate token
    [HttpGet("login")]
    public async Task<ActionResult> Login()
    {
        var sessionToken = await _sessionTokenService.GenerateSessionToken();

        return Ok(sessionToken);
    }
}
