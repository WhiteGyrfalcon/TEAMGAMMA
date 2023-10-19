<<<<<<< Updated upstream
﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
=======
﻿using GamaGameHub.Infrastructure.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
>>>>>>> Stashed changes
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamaGameHub.Infrastructure.Data
{
<<<<<<< Updated upstream
    internal class GamaGameHubDbContext/*: IdentityDbContext<User>*/
    {
=======
    public class GamaGameHubDbContext : IdentityDbContext<User>
    {
        public GamaGameHubDbContext(DbContextOptions options) : base(options)
        {
        }
>>>>>>> Stashed changes
    }
}
