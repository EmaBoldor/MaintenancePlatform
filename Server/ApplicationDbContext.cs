using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MaintenancePlatform.Shared;

namespace MaintenancePlatform.Server
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Mentenanta> Mentenanta { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}

