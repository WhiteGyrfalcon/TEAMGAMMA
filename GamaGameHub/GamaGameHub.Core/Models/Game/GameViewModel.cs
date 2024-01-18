using GamaGameHub.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamaGameHub.Core.Models.Game
{
    public class GameViewModel
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Thumbnail { get; set; }

        public DateTime CreatedOn { get; set; }

        public bool IsActive { get; set; }

        public int GameCreatorId { get; set; }

        public GameCreator GameCreator { get; set; }

        public int AverageStars { get; set; }

        public ICollection<Image> Images { get; set; } = new HashSet<Image>();

        public ICollection<Review> Reviews { get; set; } = new HashSet<Review>();

        [Required]
        public ICollection<GameGenre> GamesGenres { get; set; } = new HashSet<GameGenre>();

        [Required]
        public ICollection<GameCategory> GamesCategories { get; set; } = new HashSet<GameCategory>();

        public ICollection<Favourite> Favourites { get; set; } = new HashSet<Favourite>();
    }
}
