using GamaGameHub.Core.Contracts;
using GamaGameHub.Core.Models.Category;
using GamaGameHub.Core.Models.Game;
using GamaGameHub.Core.Models.Pagination;
using GamaGameHub.Core.Models.User;
using GamaGameHub.Infrastructure.Data.Common;
using GamaGameHub.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace GamaGameHub.Core.Services
{
    public class GameService : IGameService
    {
        private readonly IRepository repo;
        private readonly IUserService userService;
        private readonly ICommentService commentService;

        public GameService(IRepository _repo, IUserService _userService, ICommentService commentService)
        {
            repo = _repo;
            userService = _userService;
            this.commentService = commentService;
            this.Pager = null!;
        }

        public Pager Pager { get; set; }

        public async Task Create(GameFormViewModel model)
        {
            var game = new Game()
            {
                Name = model.Name,
                Description = model.Description,
                Thumbnail = model.Thumbnail,
                CreatedOn = DateTime.ParseExact(model.CreatedOn, "yyyy-MM-dd", CultureInfo.CurrentCulture),
                GameCreatorId = model.GameCreatorId,
                AverageStars = model.AverageStars,
                // Images = model.Images,

            };

            //await repo.AddAsync(gameCreator);
            await repo.SaveChangesAsync();
        }

        public async Task<ICollection<GameModel>> GetGames(int page, string controllerName)
        {
            // TODO think if all this data is needed to be loaded, because thats A LOT
            // of data
            // Furthermore pagination should be implemented

            if (page < 1) { page = 1; }

            int totalItems = await repo.All<Game>().CountAsync();
            this.Pager = new Pager(totalItems, page);
            this.Pager.Controller = controllerName;
            int skipGames = (page - 1) * this.Pager.PageSize;

            Game[] games = await repo.All<Game>()
                               .Include(game => game.Reviews)
                               .Include(game => game.GamesGenres)
                               .ThenInclude(gameGenre => gameGenre.Genre)
                               .Include(game => game.GamesCategories)
                               .ThenInclude(gameCategory => gameCategory.Category)
                               .Skip(skipGames)
                               .Take(this.Pager.PageSize)
                               .ToArrayAsync();

            if (games.Length != 0)
            {
                return games.Select(game => new GameModel()
                {
                    Id = game.Id,
                    Name = game.Name,
                    Description = game.Description,
                    Thumbnail = game.Thumbnail,
                    CreatedOn = game.CreatedOn,
                    IsActive = game.IsActive,
                    AverageStars = game.AverageStars,
                    ImagesUrls = game.Images.Select(image => image.UrlPath).ToList(),
                    Genres = game.GamesGenres.Select(gameGenre => new Models.Genre.GenreModel()
                    {
                        Name = gameGenre.Genre.Name,
                        Description = gameGenre.Genre.Description,
                    }).ToList(),
                    Categories = game.GamesCategories.Select(gameCategory => new CategoryModel()
                    {
                        Name = gameCategory.Category.Name,
                        Description = gameCategory.Category.Description
                    }).ToList()
                }).ToList();
            }

            throw new Exception("There are no games in the DB!");
        }

        public async Task<GameModel> GetGame(int id)
        {

            Game? game = repo.All<Game>(game => game.Id == id)
                             .Include(game => game.GamesGenres)
                             .ThenInclude(gameGenre => gameGenre.Genre)
                             .Include(game => game.Reviews)
                             .ThenInclude(review => review.User)
                             .Include(game => game.GameCreator)
                             .ThenInclude(gameCreator => gameCreator.User)
                             .FirstOrDefault();

            List<Game> suggestedGames = repo.All<Game>(game => game.Id != id).ToList();

            if (game is not null)
            {
                Review[] comments = game.Reviews.ToArray();

                return new GameModel()
                {
                    Id = game.Id,
                    Name = game.Name,
                    Description = game.Description,
                    Thumbnail = game.Thumbnail,
                    CreatedOn = game.CreatedOn,
                    IsActive = game.IsActive,
                    AverageStars = game.AverageStars,
                    ImagesUrls = game.Images.Select(image => image.UrlPath).ToList(),
                    Comments = commentService.GetCommentsByGame(game),
                    Genres = game.GamesGenres.Select(gameGenre => new Models.Genre.GenreModel()
                    {
                        Name = gameGenre.Genre.Name,
                        Description = gameGenre.Genre.Description,
                    }).ToList(),
                    Categories = game.GamesCategories.Select(gameCategory => new CategoryModel()
                    {
                        Name = gameCategory.Category.Name,
                        Description = gameCategory.Category.Description
                    }).ToList(),
                    GameCreator = new UserPartialModel()
                    {
                        Id = game.GameCreator.Id.ToString(),
                        Username = game.GameCreator.User.UserName,
                        City = game.GameCreator.User.City,
                        Country = game.GameCreator.User.Country,
                        ProfilePictureUrl = game.GameCreator.User.ProfilePictureUrl,
                    },
                    SuggestedGames = suggestedGames is not null ? suggestedGames.Select(suggestedGame => new GameModel()
                    {
                        Id = suggestedGame.Id,
                        Name = suggestedGame.Name,
                        Description = suggestedGame.Description,
                        Thumbnail = suggestedGame.Thumbnail,
                        CreatedOn = suggestedGame.CreatedOn,
                        IsActive = suggestedGame.IsActive,
                        AverageStars = suggestedGame.AverageStars,
                        ImagesUrls = suggestedGame.Images.Select(image => image.UrlPath).ToList()
                    }).ToList() : new List<GameModel>()
                };

            }

            throw new Exception("Game is null!");
        }
    }
}