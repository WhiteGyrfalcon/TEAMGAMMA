using GamaGameHub.Core.Models.Category;
using GamaGameHub.Core.Models.Genre;
using System.ComponentModel.DataAnnotations;

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

        public int AverageStars { get; set; }

        public ICollection<string> ImagesUrls { get; set; } = new List<string>();

        public ICollection<int> ReviewsId { get; set; } = new List<int>();

        [Required]
        public ICollection<GenreModel> Genres { get; set; } = new List<GenreModel>();

        [Required]
        public ICollection<CategoryModel> GamesCategories { get; set; } = new List<CategoryModel>();

    }
}
