using GamaGameHub.Core.Contracts;
using GamaGameHub.Core.Models.User;
using GamaGameHub.Infrastructure.Data.Common;
using GamaGameHub.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace GamaGameHub.Core.Services
{
    public class UserService : IUserService    
    {

        private readonly IRepository repo;

        public UserService(IRepository _repo)
        {
            repo = _repo;
        }


        public async Task<bool> UserByEmailExists(string email)
        {
            var user = await repo.All<User>()
                .FirstOrDefaultAsync(u => u.Email == email && u.IsActive == true);

            return user != null;
        }

        public async Task<UserModel> GetUserById(string userId)
        {
            User user = await repo.All<User>()
                                  .Where(u => u.Id == userId)
                                  .FirstOrDefaultAsync();

            if (user != null)
            {
                return new UserModel()
                {
                    Email = user.Email,
                    Username = user.UserName,
                    PhoneNumber = user.PhoneNumber,
                    Address = user.Address,
                    City = user.City,
                    Country = user.Country,
                    ProfilePictureUrl = user.ProfilePictureUrl
                };
            }

            throw new Exception("User is null!");
        }
    }
}
