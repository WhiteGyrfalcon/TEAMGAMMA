using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamaGameHub.Core.Models.Home
{
    public class ContactUsViewModel
    {
        [Required]
        public string SenderName { get; set; } = null!;

        [Required]
        [EmailAddress]
        public string From { get; set; } = null!;

        [Required]
        public string Subject { get; set; } = null!;

        [Required]
        public string Body { get; set; } = null!;
    }
}
