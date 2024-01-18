using GamaGameHub.Infrastructure.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamaGameHub.Infrastructure.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(CreateUsers());
        }
        private List<User> CreateUsers()
        {
            var users = new List<User>();
            var hasher = new PasswordHasher<User>();

            var user = new User()
            {
                Id = "2c88b9f1-b872-4450-a600-c36f736aeea9",
                UserName = "petar",
                NormalizedUserName = "PETAR",
                Email = "petar@gmail.com",
                NormalizedEmail = "PETAR@GMAIL.COM",
                PhoneNumber = "0893052673",
                City = "Karnobat",
                Address = "Aleksandar Batenberg 28",
                Country = "Bulgaria",
                ProfilePictureUrl= "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.freeiconspng.com%2Fimages%2Fprofile-icon-png&psig=AOvVaw3wTqNvIRQgdxukevliNioM&ust=1701414266054000&source=images&cd=vfe&opi=89978449&ved=0CBEQjRxqFwoTCIi0rJmU64IDFQAAAAAdAAAAABAE"
            };

            user.PasswordHash =
                 hasher.HashPassword(user, "111111");

            users.Add(user);

            user = new User()
            {
                Id = "7113b6b6-07d4-4d57-8173-2a9d053834d4",
                UserName = "silvia",
                NormalizedUserName = "SILVIA",
                Email = "silvia@gmail.com",
                NormalizedEmail = "SILVIA@GMAIL.COM",
                PhoneNumber = "0888752419",
                City = "Kazanlak",
                Address = "Hristo Botev 15",
                Country = "Bulgaria",
                ProfilePictureUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.freeiconspng.com%2Fimages%2Fprofile-icon-png&psig=AOvVaw3wTqNvIRQgdxukevliNioM&ust=1701414266054000&source=images&cd=vfe&opi=89978449&ved=0CBEQjRxqFwoTCIi0rJmU64IDFQAAAAAdAAAAABAE"
            };

            user.PasswordHash =
                 hasher.HashPassword(user, "111111");

            users.Add(user);

            user = new User()
            {
                Id = "3d9a8eaf-5b3e-4b69-a101-74ff3787b7df",
                UserName = "Electronic Arts",
                NormalizedUserName = "ELECTRONIC ARTS",
                Email = "electronicarts@gmail.com",
                NormalizedEmail = "ELECTRONICARTS@GMAIL.COM",
                PhoneNumber = "16059719337",
                City = "Redwood City, Northern California",
                Address = "Redwood Shores Parkway 209",
                Country = "USA",
                ProfilePictureUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.freeiconspng.com%2Fimages%2Fprofile-icon-png&psig=AOvVaw3wTqNvIRQgdxukevliNioM&ust=1701414266054000&source=images&cd=vfe&opi=89978449&ved=0CBEQjRxqFwoTCIi0rJmU64IDFQAAAAAdAAAAABAE"
            };

            user.PasswordHash =
            hasher.HashPassword(user, "111111");

            users.Add(user);

            user = new User()
            {
                Id = "7cd7370d-565d-4f77-9fd5-60d27985bbf1",
                UserName = "Behaviour Interactive Inc.",
                NormalizedUserName = "BEHAVIOUR INTERACTIVE INC.",
                Email = "bhvrinteractive@gmail.com",
                NormalizedEmail = "BHVRINTERACTIVE@GMAIL.COM",
                PhoneNumber = "136579373378",
                City = "Toronto",
                Address = "Main Street 22",
                Country = "Canada",
                ProfilePictureUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.freeiconspng.com%2Fimages%2Fprofile-icon-png&psig=AOvVaw3wTqNvIRQgdxukevliNioM&ust=1701414266054000&source=images&cd=vfe&opi=89978449&ved=0CBEQjRxqFwoTCIi0rJmU64IDFQAAAAAdAAAAABAE"
            };

            user.PasswordHash =
            hasher.HashPassword(user, "111111");

            users.Add(user);

            user = new User()
            {
                Id = "40b15c7b-dc76-4280-b025-4816f74e5f48",
                UserName = "gergana",
                NormalizedUserName = "GERGANA",
                Email = "gergana@gmail.com",
                NormalizedEmail = "GERGANA@GMAIL.COM",
                PhoneNumber = "0986999728",
                City = "Stara Zagora",
                Address = "Metodii Kusev 32",
                Country = "Bulgaria",
                ProfilePictureUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.freeiconspng.com%2Fimages%2Fprofile-icon-png&psig=AOvVaw3wTqNvIRQgdxukevliNioM&ust=1701414266054000&source=images&cd=vfe&opi=89978449&ved=0CBEQjRxqFwoTCIi0rJmU64IDFQAAAAAdAAAAABAE"
            };

            user.PasswordHash =
            hasher.HashPassword(user, "111111");

            users.Add(user);

            user = new User()
            {
                Id = "da389127-2cb6-4a2c-9afe-e609253e9391",
                UserName = "stoyan",
                NormalizedUserName = "STOYAN",
                Email = "stoyan@gmail.com",
                NormalizedEmail = "STOYAN@GMAIL.COM",
                PhoneNumber = "0898508050",
                City = "Varna",
                Address = "Vasil Levski 8",
                Country = "Bulgaria",
                ProfilePictureUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.freeiconspng.com%2Fimages%2Fprofile-icon-png&psig=AOvVaw3wTqNvIRQgdxukevliNioM&ust=1701414266054000&source=images&cd=vfe&opi=89978449&ved=0CBEQjRxqFwoTCIi0rJmU64IDFQAAAAAdAAAAABAE"
            };

            user.PasswordHash =
            hasher.HashPassword(user, "111111");
            
            users.Add(user);

            return users;
        }


    }
}
