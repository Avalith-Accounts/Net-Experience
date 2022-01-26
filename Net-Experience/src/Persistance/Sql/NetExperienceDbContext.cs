using Microsoft.EntityFrameworkCore;

namespace Net.Experience.Persistance.Sql
{
    public class NetExperienceDbContext : DbContext
    {
        public NetExperienceDbContext()
        {

        }

        public NetExperienceDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(NetExperienceDbContext).Assembly);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionBuilder)
        {
            if (!dbContextOptionBuilder.IsConfigured)
            {
                dbContextOptionBuilder.UseSqlServer("SqlConnection");
            }
        }
    }
}
