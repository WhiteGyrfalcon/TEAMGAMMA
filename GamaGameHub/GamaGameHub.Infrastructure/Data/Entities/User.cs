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
            this.IsActive= true;
        }

        [Required]
        [MaxLength(CityMaxLength)]
        public string City { get; set; }

        [Required]
        [MaxLength(AddressMaxLength)]
        public string Address { get; set; }

        [Required]
        [MaxLength(CountryMaxLength)]
        public string Country { get; set; }

        public bool IsActive { get; set; }

        public ICollection<Favourite> Favourites { get; set; } = new HashSet<Favourite>();
    }
}
