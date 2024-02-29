using GamaGameHub.Core.Contracts;
using GamaGameHub.Core.Models.Category;
using GamaGameHub.Core.Models.Comment;
using GamaGameHub.Core.Models.Game;
using GamaGameHub.Infrastructure.Data.Common;
using GamaGameHub.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace GamaGameHub.Core.Services
{
    public class CommentService : ICommentService
    {
        private readonly IRepository repo;
        private readonly IUserService userService;

        public CommentService(IRepository _repo, IUserService _userService)
        {
            repo = _repo;
            userService = _userService;
        }

        public Task Add(string userId, string Content, DateTime dateOfAdding)
        {
            throw new NotImplementedException();
        }

        public List<CommentModel> GetCommentsByGame(Game game)
        {
            return game.Reviews.Select(review => new CommentModel()
            {
                Id = review.Id,
                Content = review.MainContent,
                Creator = new Models.User.UserPartialModel()
                {
                    Id = review.User.Id,
                    Username = review.User.UserName,
                    City = review.User.City,
                    Country = review.User.Country,
                    ProfilePictureUrl = review.User.ProfilePictureUrl,
                },
                CreatedOn = review.CreatedOn,
                Likes = review.Likes,
                IsActive = review.IsActive
            }).ToList();
        }

        public Task GetCommentsByUserId(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
