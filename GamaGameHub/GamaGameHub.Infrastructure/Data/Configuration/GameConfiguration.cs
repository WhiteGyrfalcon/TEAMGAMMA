using GamaGameHub.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamaGameHub.Infrastructure.Data.Configuration
{
    public class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.HasData(CreateGames());
        }

        internal static List<Game> CreateGames()
        {
            var games = new List<Game>();

            var game = new Game()
            {
                Id = 1,
                Name = "Apex Legends™",
                Description = "Apex Legends is the award-winning, free-to-play Hero Shooter from Respawn Entertainment.",
                Thumbnail = "https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/games_15/nintendo_switch_download_software_1/2x1_NSwitchDS_ApexLegends_Season18_image1600w.jpg",
                CreatedOn = DateTime.ParseExact("05-11-2020", "dd-MM-yyyy", CultureInfo.CurrentCulture),
                GameCreatorId = 1,
                AverageStars = 4
            };

            games.Add(game);

            game = new Game()
            {
                Id = 2,
                Name = "Dead by Daylight",
                Description = "A multiplayer horror game where one player takes on the role of the savage Killer, and other four players play as Survivors, trying to escape.",
                Thumbnail = "https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/games_15/nintendo_switch_4/H2x1_NSwitch_DeadByDaylight_image1280w.jpg",
                CreatedOn = DateTime.ParseExact("14-06-2016", "dd-MM-yyyy", CultureInfo.CurrentCulture),
                GameCreatorId = 2,
                AverageStars = 3
            };

            games.Add(game);

            game = new Game()
            {
                Id = 3,
                Name = "EA SPORTS FC™ 24",
                Description = "The World's Game: the most true-to-football experience ever with HyperMotionV, PlayStyles optimized by Opta, and an enhanced Frostbite™ Engine.",
                Thumbnail = "https://image-cdn.essentiallysports.com/wp-content/uploads/EA-Sports-FC-24-1536x864.jpg",
                CreatedOn = DateTime.ParseExact("29-09-2023", "dd-MM-yyyy", CultureInfo.CurrentCulture),
                GameCreatorId = 1,
                AverageStars = 5
            };

            games.Add(game);

            game = new Game()
            {
                Id = 4,
                Name = "Battlefield™ 2042",
                Description = "First-person shooter, marks the return to the iconic warfare of the franchise. With a cutting-edge arsenal, you can engage in multiplayer battles.",
                Thumbnail = "https://assets.xboxservices.com/assets/71/99/71999807-558a-4640-b29a-cb13a721c4bd.jpg?n=299441_GLP-Page-Hero-0_1083x609.jpg",
                CreatedOn = DateTime.ParseExact("19-11-2021", "dd-MM-yyyy", CultureInfo.CurrentCulture),
                GameCreatorId = 2,
                AverageStars = 2
            };

            games.Add(game);

            game = new Game()
            {
                Id = 5,
                Name = "Call of Duty",
                Description = "Call of Duty is a franchise of several multiplayer first-person shooter games published by Activision.",
                Thumbnail = "https://xxboxnews.blob.core.windows.net/prod/sites/2/2022/06/Call-of-Duty-Modern-Warfare-II_Reveal_X1_Wire_Hero_1920x1080-b5aea4e5ca6046ac478e.jpg",
                CreatedOn = DateTime.ParseExact("28-10-2022", "dd-MM-yyyy", CultureInfo.CurrentCulture),
                GameCreatorId = 1,
                AverageStars = 2
            };

            games.Add(game);

            game = new Game()
            {
                Id = 6,
                Name = "Cyberpunk 2077",
                Description = "Open-world, action-adventure RPG set in the Night City, where you play as a cyberpunk mercenary wrapped up in a do-or-die fight for survival.",
                Thumbnail = "https://static.cdprojektred.com/cms.cdprojektred.com/16x9_big/b9ea2dc46d95cf9fa3f77209e27ae7a6488368f1-1920x1080.jpg",
                CreatedOn = DateTime.ParseExact("10-12-2020", "dd-MM-yyyy", CultureInfo.CurrentCulture),
                GameCreatorId = 2,
                AverageStars = 3
            };

            games.Add(game);

            game = new Game()
            {
                Id = 7,
                Name = "New World",
                Description = "Explore a thrilling, open-world MMO filled with danger where you are an adventurer shipwrecked on the supernatural island of Aeternum.",
                Thumbnail = "https://images.ctfassets.net/j95d1p8hsuun/29peK2k7Ic6FsPAVjHWs8W/06d3add40b23b20bbff215f6979267e8/NW_OPENGRAPH_1200x630.jpg",
                CreatedOn = DateTime.ParseExact("28-09-2021", "dd-MM-yyyy", CultureInfo.CurrentCulture),
                GameCreatorId = 1,
                AverageStars = 5
            };

            games.Add(game);

            game = new Game()
            {
                Id = 8,
                Name = "Halo Infinite",
                Description = "In the game's story mode, players assume the role of player character Master Chief, as he wages a war against the Banished, an alien faction.",
                Thumbnail = "https://i.ytimg.com/vi/HZtc5-syeAk/maxresdefault.jpg",
                CreatedOn = DateTime.ParseExact("15-11-2021", "dd-MM-yyyy", CultureInfo.CurrentCulture),
                GameCreatorId = 2,
                AverageStars = 1
            };

            games.Add(game);

            game = new Game()
            {
                Id = 9,
                Name = "The Devourer: Hunted Souls",
                Description = "Play as a paranormal investigator in our hybrid between first person survival and psychological horror story game.",
                Thumbnail = "https://gamefabrique.ru/i/pc/the-devourer-hunted-souls.jpg",
                CreatedOn = DateTime.ParseExact("26-10-2023", "dd-MM-yyyy", CultureInfo.CurrentCulture),
                GameCreatorId = 1,
                AverageStars = 4
            };

            games.Add(game);

            game = new Game()
            {
                Id = 10,
                Name = "Dragonheir: Silent Gods",
                Description = "Open-world high-fantasy strategy RPG that takes players on an epic journey where they can discover a dynamic world.",
                Thumbnail = "https://i.ytimg.com/vi/OQFjIlOFJkg/maxresdefault.jpg",
                CreatedOn = DateTime.ParseExact("27-10-2023", "dd-MM-yyyy", CultureInfo.CurrentCulture),
                GameCreatorId = 2,
                AverageStars = 3
            };

            games.Add(game);

            return games;
        }
    }
}
