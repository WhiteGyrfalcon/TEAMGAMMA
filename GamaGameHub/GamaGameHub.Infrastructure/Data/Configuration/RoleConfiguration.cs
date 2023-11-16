using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamaGameHub.Infrastructure.Data.Configuration
{
    internal class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(new List<IdentityRole>
            {
                new IdentityRole
                {
                    Id ="3023896d-3caf-4d3a-9812-36f654921534" ,
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                },
                new IdentityRole 
                {
                    Id ="37c6416c-0f8e-4820-92c6-ebd52c680c8f" ,
                    Name = "Client",
                    NormalizedName = "CLIENT"
                },
                new IdentityRole 
                {
                    Id = "82254c24-56b0-4a91-9d25-9c43e89f9e92",
                    Name = "GameCreator",
                    NormalizedName = "GAMECREATOR"
                },
            });
        }
    }
}
