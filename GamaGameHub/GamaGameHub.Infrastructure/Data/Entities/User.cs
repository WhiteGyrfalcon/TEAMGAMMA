using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static GamaGameHub.Infrastructure.Data.Constants.EntityConstraints.UserConstraints;


namespace GamaGameHub.Infrastructure.Data.Entities
{
    public class User : IdentityUser
    {
        public User()
        {
            this.IsActive = true;
        }

        [MaxLength(CityMaxLength)]
        public string? City { get; set; }

        [MaxLength(AddressMaxLength)]
        public string? Address { get; set; }
        
        [MaxLength(CountryMaxLength)]
        public string? Country { get; set; }

        public bool IsActive { get; set; }

        public string? ProfilePictureUrl { get; set; }

        public ICollection<Favourite> Favourites { get; set; } = new HashSet<Favourite>();
    }
}
