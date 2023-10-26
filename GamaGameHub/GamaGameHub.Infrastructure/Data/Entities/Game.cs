using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static GamaGameHub.Infrastructure.Data.Constants.EntityConstraints.GameConstraints;

namespace GamaGameHub.Infrastructure.Data.Entities
{
    public class Game
    {
        public Game()
        {
            this.IsActive = true;
            this.CreatedOn = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string  Name { get; set; }

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; }

        [Required]
        public string Thumbnail { get; set; }

        public DateTime CreatedOn { get; set; }

        public bool IsActive { get; set; }

        [Required]
        [ForeignKey(nameof(GameCreator))]
        public int GameCreatorId { get; set; }

        public GameCreator GameCreator { get; set; }

        [Required]
        [Range(StarsMax, StarsMin)]
        public int AverageStars { get; set; }

        [Required]
        public ICollection<Image> Images { get; set; } = new HashSet<Image>();

        public ICollection<Review> Reviews { get; set; } = new HashSet<Review>();

        [Required]
        public ICollection<Genre> Genres { get; set; } = new HashSet<Genre>();

        [Required]
        public ICollection<Category> Categories { get; set; }  = new HashSet<Category>();

        public ICollection<Favourite> Favourites { get; set; }  = new HashSet<Favourite>();
    }
}
