using GamaGameHub.Core.Contracts;
using GamaGameHub.Core.Models.Pagination;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GamaGameHub.Controllers
{
    [Authorize]
    public class GameController : Controller
    {
        private readonly IGameService gameService;
        public GameController(IGameService gameService)
        {
            this.gameService = gameService;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int page = 1)
        {
            var games = await this.gameService.GetGames(page, "Game");

            ViewBag.Pager = this.gameService.Pager;

            return View(games);
        }
    }
}
