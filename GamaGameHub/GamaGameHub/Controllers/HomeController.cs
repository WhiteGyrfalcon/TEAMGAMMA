using GamaGameHub.Core.Contracts;
using GamaGameHub.Core.Models.Game;
using GamaGameHub.Core.Models.Home;
using GamaGameHub.Core.Models.Pagination;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mail;

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
        public async Task<IActionResult> Index(int page = 1)
        {
            var games = await this.gameService.GetGames();

            if (page < 1) { page = 1; }

            int totalItems = games.Count();
            Pager pager = new Pager(totalItems, page);
            int skipGames = (page - 1) * pager.PageSize;

            var data = games.Skip(skipGames).Take(pager.PageSize).ToList();

            pager.Controller = "Home";
            ViewBag.Pager = pager;

            return View(data);
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

            MailMessage mailMessage = new MailMessage(model.From,"meribelcheva@gmail.com");
            mailMessage.Subject = model.Subject;
            mailMessage.Body = $"Name: {model.SenderName}\nEmail: {model.From}\nMessage: {model.Body}\n";
            mailMessage.IsBodyHtml = false;

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential("meribelcheva@gmail.com", "beky gwha odgp hbnj");
            smtpClient.Send(mailMessage);

            return View();
        }
    }
}