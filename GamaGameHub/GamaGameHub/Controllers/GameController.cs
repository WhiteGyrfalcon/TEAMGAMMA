using GamaGameHub.Core.Contracts;
using GamaGameHub.Core.Models.Pagination;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GamaGameHub.Controllers
{
    
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
            var games = await this.gameService.GetGames();

            if (page < 1) { page = 1; }

            int totalItems = games.Count();
            Pager pager = new Pager(totalItems, page);
            int skipGames = (page - 1) * pager.PageSize;

            var data = games.Skip(skipGames).Take(pager.PageSize).ToList();
            pager.Controller = "Game";
            ViewBag.Pager = pager;

            return View(data);
        }
    }
}
