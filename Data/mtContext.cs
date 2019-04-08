using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Moto_ShowsCore.Models;
using Microsoft.EntityFrameworkCore;

namespace Moto_ShowsCore.Data
{
    public class mtContext : DbContext
    {
        public mtContext(DbContextOptions<mtContext> options) : base(options) { }
        public DbSet<MotoShows> MotoShows {get; set;}
        public DbSet<Directors> Directors { get; set; }
        public DbSet<Subdivisions> Subdivisions { get; set; }
        public DbSet<Cars> Cars { get; set; }
        public DbSet<Clients> Clients { get; set; }
    }
}
