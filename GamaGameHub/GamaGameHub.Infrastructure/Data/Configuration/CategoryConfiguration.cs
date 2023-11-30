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
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(CreateCategories());
        }

        internal static List<Category> CreateCategories()
        {
            var categories = new List<Category>();

            var category = new Category()
            {
                Id = 1,
                Name = "Top 20 most favourited games",
                Description = "Shows the first 20 games, that have most likes."
            };

            categories.Add(category);

            category = new Category()
            {
                Id = 2,
                Name = "Top 5 most reviewed games",
                Description = "Shows 5 games, which have the most reviews."
            };

            categories.Add(category);

            category = new Category()
            {
                Id = 3,
                Name = "Top 25 adventure games",
                Description = "Shows the first 25 adventure games, that have most likes."
            };

            categories.Add(category);
            
            return categories;
        }
    }
}
