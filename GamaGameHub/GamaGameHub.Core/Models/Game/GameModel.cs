using GamaGameHub.Core.Models.Category;
using GamaGameHub.Core.Models.Comment;
using GamaGameHub.Core.Models.Genre;
using GamaGameHub.Core.Models.User;

namespace GamaGameHub.Core.Models.Game
{
    public class GameModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Thumbnail { get; set; }

        public DateTime CreatedOn { get; set; }

        public bool IsActive { get; set; }
        public UserPartialModel GameCreator { get; set; }

        public int AverageStars { get; set; }

        public ICollection<string> ImagesUrls { get; set; } = new List<string>();

        public List<CommentModel> Comments { get; set; } = new List<CommentModel>();

        public ICollection<GenreModel> Genres { get; set; } = new List<GenreModel>();

        public ICollection<CategoryModel> Categories { get; set; } = new List<CategoryModel>();

        public List<GameModel> SuggestedGames { get; set; } = new List<GameModel>();
    }
}
