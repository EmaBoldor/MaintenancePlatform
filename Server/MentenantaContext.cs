using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MaintenancePlatform.Shared;

namespace MaintenancePlatform.Server
{
    public class MentenantaContext : DbContext
    {
        public MentenantaContext(DbContextOptions<MentenantaContext> options)
            : base(options)
        {
        }

        public DbSet<Mentenanta> Mentenante { get; set; }
    }
}
