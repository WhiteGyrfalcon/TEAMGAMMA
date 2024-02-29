using GamaGameHub.Core.Contracts;
using GamaGameHub.Core.Models.Game;
using GamaGameHub.Core.Models.Home;
using GamaGameHub.Core.Models.Pagination;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mail;
using Microsoft.Extensions.Configuration;

namespace GamaGameHub.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGameService gameService;
        private readonly IHomeService homeService;

        public HomeController(ILogger<HomeController> logger, IGameService _gameService, IHomeService homeService)
        {
            _logger = logger;
            gameService = _gameService;
            this.homeService = homeService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Index(int page = 1)
        {
            var games = await this.gameService.GetGames(page, "Home");

            ViewBag.Pager = this.gameService.Pager;
            return View(games);
        }
        public IActionResult AboutUs()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ContactUs()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ContactUs(ContactUsViewModel model)
        {
            if (!ModelState.IsValid) { return View(model); }

            this.homeService.ContactUs(model);
            return View();
        }
    }
}