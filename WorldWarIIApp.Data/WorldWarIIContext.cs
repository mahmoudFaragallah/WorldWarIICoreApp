using Microsoft.EntityFrameworkCore;
using WorldWarIIApp.Domain;

namespace WorldWarIIApp.Data
{
    public class WorldWarIIContext : DbContext
    {
        public WorldWarIIContext(DbContextOptions<WorldWarIIContext> options) : base(options)
        {

        }
        public DbSet<Solider> Soliders { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Battle> Battles { get; set; }

    }
}
