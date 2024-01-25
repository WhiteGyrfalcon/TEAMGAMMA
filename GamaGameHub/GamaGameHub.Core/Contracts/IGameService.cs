using GamaGameHub.Core.Models.Game;

namespace GamaGameHub.Core.Contracts
{
    public interface IGameService
    {
        public Task<ICollection<GameModel>> GetGames();
    }
}
