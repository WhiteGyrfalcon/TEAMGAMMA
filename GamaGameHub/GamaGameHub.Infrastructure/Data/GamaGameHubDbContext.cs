using GamaGameHub.Infrastructure.Data.Configuration;
using GamaGameHub.Infrastructure.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamaGameHub.Infrastructure.Data
{
    public class GamaGameHubDbContext : IdentityDbContext<User>
    {
        public GamaGameHubDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Favourite> Favourites { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostComment> PostComments { get; set; }
        public DbSet<Review> Review { get; set; }
        public DbSet<ReviewComment> ReviewComments { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
                 .Property(u => u.UserName)
                 .HasMaxLength(20)
                 .IsRequired();

            builder.Entity<User>()
                .Property(u => u.Email)
                .HasMaxLength(60)
                .IsRequired();

            
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new GenreConfiguration());
            builder.ApplyConfiguration(new GameCreatorConfiguration());
            builder.ApplyConfiguration(new GameConfiguration());
            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new UsersRolesConfiguration());
            

            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }
    }
}
