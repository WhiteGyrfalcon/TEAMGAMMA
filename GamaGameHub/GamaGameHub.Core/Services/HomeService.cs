using GamaGameHub.Core.Contracts;
using GamaGameHub.Core.Models.Home;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GamaGameHub.Core.Services
{
    public class HomeService : IHomeService
    {
        public void ContactUs(ContactUsViewModel viewModel)
        {
            var config = new ConfigurationBuilder().AddUserSecrets("aspnet-GamaGameHub-17c66339-cd75-4595-a367-ea84292bee64").Build();

            MailMessage mailMessage = new MailMessage(viewModel.From, config["GmailUserName"]);
            mailMessage.Subject = viewModel.Subject;
            mailMessage.Body = $"Name: {viewModel.SenderName}\nEmail: {viewModel.From}\nMessage: {viewModel.Body}\n";
            mailMessage.IsBodyHtml = false;

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential(config["GmailUserName"], config["GmailUserPass"]);
            smtpClient.Send(mailMessage);
        }
    }
}
