using GamaGameHub.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamaGameHub.Infrastructure.Data.Configuration
{
    public class GamesGenresConfigiration : IEntityTypeConfiguration<GameGenre>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<GameGenre> builder)
        {
            builder.HasData(CreateGamesGenres());
        }
        internal static List<GameGenre> CreateGamesGenres()
        {
            var games = new List<GameGenre>();

            var game = new GameGenre()
            {
                GameId = 1,
                GenreId = 1
            };

            games.Add(game);

            game = new GameGenre()
            {
                GameId = 1,
                GenreId = 2
            };

            games.Add(game);

            game = new GameGenre()
            {
                GameId = 2,
                GenreId = 1
            };

            games.Add(game);

            game = new GameGenre()
            {
                GameId = 3,
                GenreId = 3
            };

            games.Add(game);

            game = new GameGenre()
            {
                GameId = 3,
                GenreId = 6
            };

            games.Add(game);

            game = new GameGenre()
            {
                GameId = 4,
                GenreId = 1
            };

            games.Add(game);

            game = new GameGenre()
            {
                GameId = 4,
                GenreId = 2
            };

            games.Add(game);

            game = new GameGenre()
            {
                GameId = 4,
                GenreId = 5
            };

            games.Add(game);

            game = new GameGenre()
            {
                GameId = 5,
                GenreId = 1
            };

            games.Add(game);

            game = new GameGenre()
            {
                GameId = 6,
                GenreId = 1
            };

            games.Add(game);

            game = new GameGenre()
            {
                GameId = 6,
                GenreId = 7
            };

            games.Add(game);

            game = new GameGenre()
            {
                GameId = 7,
                GenreId = 1
            };

            games.Add(game);

            game = new GameGenre()
            {
                GameId = 7,
                GenreId = 2
            };

            games.Add(game);

            game = new GameGenre()
            {
                GameId = 7,
                GenreId = 9
            };

            games.Add(game);

            game = new GameGenre()
            {
                GameId = 7,
                GenreId = 7
            };

            games.Add(game);

            game = new GameGenre()
            {
                GameId = 8,
                GenreId = 1
            };

            games.Add(game);

            game = new GameGenre()
            {
                GameId = 9,
                GenreId = 1
            };

            games.Add(game);

            game = new GameGenre()
            {
                GameId = 9,
                GenreId = 2
            };

            games.Add(game);

            game = new GameGenre()
            {
                GameId = 9,
                GenreId = 4
            };

            games.Add(game);

            game = new GameGenre()
            {
                GameId = 10,
                GenreId = 7
            };

            games.Add(game);

            game = new GameGenre()
            {
                GameId = 10,
                GenreId = 8
            };

            games.Add(game);

            game = new GameGenre()
            {
                GameId = 10,
                GenreId = 9
            };

            games.Add(game);

            return games;
        }
    }
}
