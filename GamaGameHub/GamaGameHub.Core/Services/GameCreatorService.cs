using GamaGameHub.Core.Contracts;
using GamaGameHub.Infrastructure.Data.Common;
using GamaGameHub.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamaGameHub.Core.Services
{
    public class GameCreatorService : IGameCreatorService
    {

        private readonly IRepository repo;

        public GameCreatorService(IRepository _repo)
        {
            repo = _repo;
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
    }
}
