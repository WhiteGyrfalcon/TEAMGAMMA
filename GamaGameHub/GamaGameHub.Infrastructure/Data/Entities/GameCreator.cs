using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static GamaGameHub.Infrastructure.Data.Constants.EntityConstraints.GameCreatorConstraints;

namespace GamaGameHub.Infrastructure.Data.Entities
{
    public class GameCreator
    {
        public GameCreator()
        {
            this.IsActive= true;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }

        public User User { get; set; }

        [Required]
        public int YearOfCreating { get; set; }

        [MaxLength(AdditionalInformationMaxLength)]
        public string AdditionalInformation { get; set; }

        public bool IsActive { get; set; }

        public ICollection<Game> Games { get; set; } = new HashSet<Game>();
    }
}
