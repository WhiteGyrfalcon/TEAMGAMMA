using GamaGameHub.Core.Models.Game;
using GamaGameHub.Core.Models.Pagination;

namespace GamaGameHub.Core.Contracts
{
    public interface IGameService
    {
        public Task<ICollection<GameModel>> GetGames(int page, string controllerName);

        public Pager Pager { get; set; }

        public Task<GameModel> GetGame(int id);
    }
}
