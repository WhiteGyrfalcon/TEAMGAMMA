using GamaGameHub.Core.Models.Game;

namespace GamaGameHub.Core.Contracts
{
    public interface IGameService
    {
        public ICollection<GameModel> GetGames();

        public Task<GameModel> GetGame(int id);
    }
}
