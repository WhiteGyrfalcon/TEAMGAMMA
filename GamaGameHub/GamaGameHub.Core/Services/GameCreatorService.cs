using GamaGameHub.Core.Contracts;
using GamaGameHub.Core.Models.User;
using GamaGameHub.Infrastructure.Data.Common;
using GamaGameHub.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace GamaGameHub.Core.Services
{
    public class GameCreatorService : IGameCreatorService
    {

        private readonly IRepository repo;
        private readonly IUserService userService;

        public GameCreatorService(IRepository _repo, IUserService _userService)
        {
            repo = _repo;
            userService = _userService;
        }

        public async Task Create(string userId, string AdditionalInformation, int yearOfCreating)
        {
            var gameCreator = new GameCreator()
            {
                UserId = userId,
                AdditionalInformation = AdditionalInformation,
                YearOfCreating = yearOfCreating
            };

            await repo.AddAsync(gameCreator);
            await repo.SaveChangesAsync();
        }

        public async Task Update(string userId, string? AdditionalInformation, int yearOfCreating)
        {
            var gameCreator = await GetGameCreatorByUserId(userId);

            gameCreator.AdditionalInformation = AdditionalInformation;
            gameCreator.YearOfCreating = yearOfCreating;

            await repo.SaveChangesAsync();
        }

        public async Task<GameCreatorModel> GetGameCreatorByUserId(string userId)
        {
            GameCreator gameCreator = await repo.All<GameCreator>()
                                                .Where(gc => gc.UserId == userId)
                                                .FirstOrDefaultAsync();
            
            UserModel user = await userService.GetUserById(userId);

            if (gameCreator != null)
            {
                return new GameCreatorModel()
                {
                    Email = user.Email,
                    Username = user.Username,
                    PhoneNumber = user.PhoneNumber,
                    Address = user.Address,
                    City = user.City,
                    Country = user.Country,
                    ProfilePictureUrl = user.ProfilePictureUrl,
                    AdditionalInformation = gameCreator?.AdditionalInformation,
                    YearOfCreating = gameCreator.YearOfCreating
                };
            }
            else if(user != null)
            {
                return new GameCreatorModel()
                {
                    Email = user.Email,
                    Username = user.Username,
                    PhoneNumber = user.PhoneNumber,
                    Address = user.Address,
                    City = user.City,
                    Country = user.Country,
                    ProfilePictureUrl = user.ProfilePictureUrl,
                    // TODO this should be refactored
                    AdditionalInformation = null,
                    YearOfCreating = -1
                };
            }

            throw new ArgumentException("User is null!");
        }
    }
}
