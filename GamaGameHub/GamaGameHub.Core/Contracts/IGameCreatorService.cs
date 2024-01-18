using GamaGameHub.Core.Models.User;

namespace GamaGameHub.Core.Contracts
{
    public interface IGameCreatorService
    {
        Task Create(string userId, string AdditionalInformation, int yearOfCreating);
        Task<GameCreatorModel> GetGameCreatorByUserId(string userId);
        Task Update(string userId, string? AdditionalInformation, int yearOfCreating);
    }
}
