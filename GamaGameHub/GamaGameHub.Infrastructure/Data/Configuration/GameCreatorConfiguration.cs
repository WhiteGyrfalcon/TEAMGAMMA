using GamaGameHub.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamaGameHub.Infrastructure.Data.Configuration
{
    public class GameCreatorConfiguration : IEntityTypeConfiguration<GameCreator>
    {
        public void Configure(EntityTypeBuilder<GameCreator> builder)
        {
            builder.HasData(CreateGameCreators());
        }

        private List<GameCreator> CreateGameCreators()
        {
            var creators = new List<GameCreator>();

            var creator = new GameCreator()
            {
                Id = 1,
                UserId = "3d9a8eaf-5b3e-4b69-a101-74ff3787b7df",
                YearOfCreating = 1982,
                AdditionalInformation = "Driven by passion, we are a global leader in digital interactive entertainment. We develop and deliver games, content, and online services for Internet-connected consoles, mobile devices, and PCs."
            };

            creators.Add(creator);

            creator = new GameCreator()
            {
                Id = 2,
                UserId = "7cd7370d-565d-4f77-9fd5-60d27985bbf1",
                YearOfCreating = 1992,
                AdditionalInformation = "Innovation is our business. We strongly believe in trying new tech, methods, and ideas. It’s the result that counts, not how we get there."
            };

            creators.Add(creator);

            return creators;
        }
    }
}
