using GamaGameHub.Infrastructure.Data.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static GamaGameHub.Infrastructure.Data.Constants.EntityConstraints.GameConstraints;
using Microsoft.AspNetCore.Http;

namespace GamaGameHub.Core.Models.Game
{
    public class GameFormViewModel
    {

        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string Name { get; set; }

        [Required]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength)]
        public string Description { get; set; }

        [Required]
        public string Thumbnail { get; set; }

        public string CreatedOn { get; set; }

        public bool IsActive { get; set; }

        [Required]
        [ForeignKey(nameof(GameCreator))]
        public int GameCreatorId { get; set; }

        [Required]
        [Range(StarsMax, StarsMin)]
        public int AverageStars { get; set; }

        [Required]
        public ICollection<IFormFile> Images { get; set; } = new HashSet<IFormFile>();

        [Required]
        public ICollection<int> GenreIds { get; set; } = new HashSet<int>();

        [Required]
        public ICollection<int> CategoriesIds { get; set; } = new HashSet<int>();
    }
}
