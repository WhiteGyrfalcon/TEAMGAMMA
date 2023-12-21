using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using static GamaGameHub.Infrastructure.Data.Constants.EntityConstraints.UserConstraints;
using static GamaGameHub.Infrastructure.Data.Constants.EntityConstraints.GameCreatorConstraints;

namespace GamaGameHub.Core.Models.Account
{
    public class ProfileViewModel
    {

        [Required]
        [EmailAddress]
        [StringLength(EmailMaxLength, MinimumLength = EmailMinLength)]
        public string Email { get; set; } = null!;

        [Required]
        [StringLength(UsernameMaxLength, MinimumLength = UserNameMinLength)]
        public string Username { get; set; } = null!;

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        [Required]
        [Compare(nameof(Password))]
        [DataType(DataType.Password)]
        public string PasswordRepeat { get; set; } = null!;

        [Phone]
        public string? PhoneNumber { get; set; }

        [StringLength(AddressMaxLength, MinimumLength = AddressMinLength)]
        public string? Address { get; set; }

        [StringLength(CityMaxLength, MinimumLength = CityMinLength)]
        public string? City { get; set; }

        [StringLength(CountryMaxLength, MinimumLength = CountryMinLength)]
        public string? Country { get; set; }

        [StringLength(AdditionalInformationMaxLength, MinimumLength = AdditionalInformationMinLength)]
        public string? AdditionalInformation { get; set; }

        public IFormFile? ProfilePicture { get; set; }
    }
}
