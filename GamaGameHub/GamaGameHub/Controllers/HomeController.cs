using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using GamaGameHub.Core.Models.Home;
using System.Net.Mail;
using System.Net;

namespace GamaGameHub.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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