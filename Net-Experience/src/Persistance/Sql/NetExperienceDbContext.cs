using Microsoft.EntityFrameworkCore;

namespace Net.Experience.Persistance.Sql
{
    public class NetExperienceDbContext : DbContext
    {
        public NetExperienceDbContext(DbContextOptions<NetExperienceDbContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(NetExperienceDbContext).Assembly);

        }
    }
}
