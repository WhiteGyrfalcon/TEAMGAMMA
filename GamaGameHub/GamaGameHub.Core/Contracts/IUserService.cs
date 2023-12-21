using GamaGameHub.Core.Models.User;

namespace GamaGameHub.Core.Contracts
{
    public interface IUserService
    {
        Task<bool> UserByEmailExists(string email);
        Task<UserModel> GetUserById(string userId);

    }
}
