using GamaGameHub.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamaGameHub.Infrastructure.Data.Configuration
{
    public class GamesCategoriesConfiguration : IEntityTypeConfiguration<GameCategory>
    {
        public void Configure(EntityTypeBuilder<GameCategory> builder)
        {
            builder.HasData(CreateGamesGenres());
        }
        internal static List<GameCategory> CreateGamesGenres()
        {
            var games = new List<GameCategory>();

            var game = new GameCategory()
            {
                GameId = 1,
                CategoryId = 1
            };

            games.Add(game);

            game = new GameCategory()
            {
                GameId = 1,
                CategoryId = 2
            };

            games.Add(game);

            game = new GameCategory()
            {
                GameId = 2,
                CategoryId = 2
            };

            games.Add(game);

            game = new GameCategory()
            {
                GameId = 2,
                CategoryId = 3
            };

            games.Add(game);

            game = new GameCategory()
            {
                GameId = 3,
                CategoryId = 1
            };

            games.Add(game);

            game = new GameCategory()
            {
                GameId = 3,
                CategoryId = 3
            };

            games.Add(game);

            game = new GameCategory()
            {
                GameId = 4,
                CategoryId = 1
            };

            games.Add(game);

            game = new GameCategory()
            {
                GameId = 4,
                CategoryId = 2
            };

            games.Add(game);

            game = new GameCategory()
            {
                GameId = 5,
                CategoryId = 2
            };

            games.Add(game);

            game = new GameCategory()
            {
                GameId = 5,
                CategoryId = 3
            };

            games.Add(game);

            game = new GameCategory()
            {
                GameId = 6,
                CategoryId = 1
            };

            games.Add(game);

            game = new GameCategory()
            {
                GameId = 6,
                CategoryId = 3
            };

            games.Add(game);

            game = new GameCategory()
            {
                GameId = 7,
                CategoryId = 1
            };

            games.Add(game);

            game = new GameCategory()
            {
                GameId = 7,
                CategoryId = 2
            };

            games.Add(game);

            game = new GameCategory()
            {
                GameId = 8,
                CategoryId = 2
            };

            games.Add(game);

            game = new GameCategory()
            {
                GameId = 8,
                CategoryId = 3
            };

            games.Add(game);

            game = new GameCategory()
            {
                GameId = 9,
                CategoryId = 1
            };

            games.Add(game);

            game = new GameCategory()
            {
                GameId = 9,
                CategoryId = 3
            };

            games.Add(game);

            game = new GameCategory()
            {
                GameId = 10,
                CategoryId = 1
            };

            games.Add(game);

            game = new GameCategory()
            {
                GameId = 10,
                CategoryId = 2
            };

            games.Add(game);

            return games;
        }
    }
}
