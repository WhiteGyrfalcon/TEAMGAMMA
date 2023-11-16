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
    internal class UsersRolesConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(GiveUsersRoles());
        }

        private List<IdentityUserRole<string>> GiveUsersRoles()
        {
            var users = new List<IdentityUserRole<string>>();

            users.Add(new IdentityUserRole<string>()
            {
                RoleId = "37c6416c-0f8e-4820-92c6-ebd52c680c8f",
                UserId = "2c88b9f1-b872-4450-a600-c36f736aeea9"
            });

            users.Add(new IdentityUserRole<string>()
            {
                RoleId = "3023896d-3caf-4d3a-9812-36f654921534",
                UserId = "7113b6b6-07d4-4d57-8173-2a9d053834d4"
            });

            users.Add(new IdentityUserRole<string>()
            {
                RoleId = "82254c24-56b0-4a91-9d25-9c43e89f9e92",
                UserId = "3d9a8eaf-5b3e-4b69-a101-74ff3787b7df"
            });

            users.Add(new IdentityUserRole<string>()
            {
                RoleId = "3023896d-3caf-4d3a-9812-36f654921534",
                UserId = "40b15c7b-dc76-4280-b025-4816f74e5f48"
            });

            users.Add(new IdentityUserRole<string>()
            {
                RoleId = "37c6416c-0f8e-4820-92c6-ebd52c680c8f",
                UserId = "da389127-2cb6-4a2c-9afe-e609253e9391"
            });

            users.Add(new IdentityUserRole<string>()
            {
                RoleId = "82254c24-56b0-4a91-9d25-9c43e89f9e92",
                UserId = "7cd7370d-565d-4f77-9fd5-60d27985bbf1"
            });

            return users;
        }
    }
}
