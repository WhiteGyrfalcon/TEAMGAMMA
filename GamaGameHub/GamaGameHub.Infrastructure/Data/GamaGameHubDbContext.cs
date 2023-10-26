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
    }
}
