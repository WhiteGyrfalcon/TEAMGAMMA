using GamaGameHub.Core.Contracts;
using GamaGameHub.Core.Models.Account;
using GamaGameHub.Core.Models.Game;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GamaGameHub.Controllers
{
    [Authorize]
    public class GameController : Controller
    {
        private readonly ILogger<GameController> _logger;
        private readonly IGameService gameService;

        public GameController(ILogger<GameController> logger, IGameService _gameService)
        {
            _logger = logger;
            gameService = _gameService;
        }

        [HttpGet]
        [Route("Game/Index/{gameId}")]
        public async Task<IActionResult> Index(int gameId)
        {
            try
            {
                GameModel game = await gameService.GetGame(gameId);

                return View(game);
            }
            catch (Exception _)
            {
                return this.RedirectToAction("Index", "Home");
            }
        }
    }
}
