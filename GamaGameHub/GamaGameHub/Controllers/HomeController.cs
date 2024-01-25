using GamaGameHub.Core.Contracts;
using GamaGameHub.Core.Models.Game;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GamaGameHub.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGameService gameService;

        public HomeController(ILogger<HomeController> logger, IGameService _gameService)
        {
            _logger = logger;
            gameService = _gameService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            ICollection<GameModel> games = await gameService.GetGames();

            return View(games);
        }
        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }
    }
}