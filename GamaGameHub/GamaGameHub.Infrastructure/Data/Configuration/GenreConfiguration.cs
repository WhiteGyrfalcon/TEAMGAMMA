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
    internal class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasData(CreateGenres());
        }

        internal static List<Genre> CreateGenres()
        {
            var genres = new List<Genre>();

            var genre = new Genre()
            {
                Name = "Action",
                Description = "An action game is a video game genre that emphasizes physical challenges, including hand–eye coordination and reaction time. The genre includes a large variety of sub-genres, such as fighting games, beat 'em ups, shooter games, and platform games.",
            };

            genres.Add(genre);

            genre = new Genre()
            {
                Name = "Adventure",
                Description = "An adventure game (rarely called a quest game) is a video game genre in which the player assumes the role of a protagonist in an interactive story, driven by exploration and/or puzzle-solving. Most adventure games are designed for a single player."
            };

            genres.Add(genre);

            genre = new Genre()
            {
                Name = "Sports",
                Description = "Sports games are a video game genre that simulates sports. They are usually based on real-world sports, but can also be fictional or exaggerated. These games usually let the player control one or more athletes during competition."
            };

            genres.Add(genre);

            genre = new Genre()
            {
                Name = "Indie",
                Description = "Indie games stand for “independent video games.” At the highest level, they are games created by individuals or small teams who operate independently from major studios, both financially and creatively."
            };

            genres.Add(genre);

            genre = new Genre()
            {
                Name = "Casual",
                Description = "A casual game is a video game targeted at a mass market audience, as opposed to a hardcore game, which is targeted at hobbyist gamers. Casual games may exhibit any type of gameplay and genre. They generally involve simpler rules, shorter sessions, and require less learned skill."
            };

            genres.Add(genre);

            genre = new Genre()
            {
                Name = "Simulation",
                Description = "Simulation games are a diverse super-category of video games, generally designed to closely simulate real world activities. A simulation game attempts to copy various activities from real life in the form of a game for various purposes such as training, analysis, prediction, or entertainment."
            };

            genres.Add(genre);

            genre = new Genre()
            {
                Name = "RPG",
                Description = "Role-playing video game is electronic game genre in which players advance through a story quest, and often many side quests, for which their character or party of characters gain experience that improves various attributes and abilities."
            };

            genres.Add(genre);

            genre = new Genre()
            {
                Name = "Strategy",
                Description= "A strategy game is a game in which the players' uncoerced, and often autonomous, decision-making skills have a high significance in determining the outcome. Almost all strategy games require internal decision tree-style thinking, and typically very high situational awareness."
            };

            genres.Add(genre);

            genre = new Genre()
            {
                Name = "Massively Multiplayer",
                Description = "A massively multiplayer online game (MMOG or MMO) is an online video game with a large number of players on the same server. MMOs usually feature a huge, persistent open world, although there are games that differ. These games can be found for most network-capable platforms."
            };

            genres.Add(genre);

            return genres;
        }
    }
}
