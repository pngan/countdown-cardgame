using Countdown_CardGame.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Countdown_CardGame.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MainGameController : ControllerBase
    {
        private readonly ILogger<MainGameController> _logger;

        public MainGameController(ILogger<MainGameController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [Route("countdown/{playerName}")]
        public Task<string> CreateCountdownGameAsync(string playerName, [FromBody] GameInfo gameInfo)
        {
            return Task.FromResult<string>($"Hello {gameInfo.PlayerName}");
        }


       // [Route("countdown")]
        [HttpGet]
        public Task<string> Get()
        {
            return Task.FromResult<string>("abcd");
        }
    }
}