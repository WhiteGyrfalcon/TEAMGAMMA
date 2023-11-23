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
    internal class GameConfiguration : IEntityTypeConfiguration<Game>
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
                Name = "Dead by Daylight",
                Description = "A multiplayer horror game where one player takes on the role of the savage Killer, and other four players play as Survivors, trying to escape.",
                Thumbnail = "https://static0.gamerantimages.com/wordpress/wp-content/uploads/2023/05/dead_by_daylight_splash.jpg?q=50&fit=contain&w=1140&h=&dpr=1.5",
                CreatedOn = DateTime.ParseExact("14-061-2016", "dd-MM-yyyy", CultureInfo.CurrentCulture),
                GameCreatorId = 2,
                AverageStars = 3
            };

            games.Add(game);

            game = new Game()
            {
                Name = "EA SPORTS FC™ 24",
                Description = "The World's Game: the most true-to-football experience ever with HyperMotionV, PlayStyles optimized by Opta, and an enhanced Frostbite™ Engine.",
                Thumbnail = "https://assets.nintendo.com/image/upload/c_fill,w_1200/q_auto:best/f_auto/dpr_2.0/ncom/software/switch/70010000061749/bd653d83bdcc1613cfacae62845933633ce97fffc52e7e4070014eb41f9e75f7",
                CreatedOn = DateTime.ParseExact("29-09-2023", "dd-MM-yyyy", CultureInfo.CurrentCulture),
                GameCreatorId = 1,
                AverageStars = 5
            };

            games.Add(game);

            game = new Game()
            {
                Name = "Battlefield™ 2042",
                Description = "First-person shooter, marks the return to the iconic warfare of the franchise. With a cutting-edge arsenal, you can engage in multiplayer battles.",
                Thumbnail = "https://cdn1.epicgames.com/offer/52f57f57120c440fad9bfa0e6c279317/EGS_Battlefield2042_DICE_S1_2560x1440-4fd7701f78a23c971e429093fc1f6341",
                CreatedOn = DateTime.ParseExact("19-11-2021", "dd-MM-yyyy", CultureInfo.CurrentCulture),
                GameCreatorId = 2,
                AverageStars = 2
            };

            games.Add(game);

            game = new Game()
            {
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
                Name = "Cyberpunk 2077",
                Description = "Open-world, action-adventure RPG set in the Night City, where you play as a cyberpunk mercenary wrapped up in a do-or-die fight for survival.",
                Thumbnail = "https://cdn1.epicgames.com/offer/77f2b98e2cef40c8a7437518bf420e47/EGS_Cyberpunk2077_CDPROJEKTRED_S1_03_2560x1440-359e77d3cd0a40aebf3bbc130d14c5c7",
                CreatedOn = DateTime.ParseExact("10-12-2020", "dd-MM-yyyy", CultureInfo.CurrentCulture),
                GameCreatorId = 2,
                AverageStars = 3
            };

            games.Add(game);

            game = new Game()
            {
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
                Name = "The Devourer: Hunted Souls",
                Description = "Play as a paranormal investigator in our hybrid between first person survival and psychological horror story game.",
                Thumbnail = "https://cdn.akamai.steamstatic.com/steam/apps/2309400/capsule_616x353.jpg?t=1698626279",
                CreatedOn = DateTime.ParseExact("26-10-2023", "dd-MM-yyyy", CultureInfo.CurrentCulture),
                GameCreatorId = 1,
                AverageStars = 4
            };

            games.Add(game);

            game = new Game()
            {
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
