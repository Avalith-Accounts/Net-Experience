using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Net.Experience.Domain.Entities;

namespace Net.Experience.Persistance.Sql
{
    public class NetExperienceDbContext : IdentityDbContext
    {
        public DbSet<Item> Comments { get; set; }

        public NetExperienceDbContext()
        {

        }

        public NetExperienceDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(NetExperienceDbContext).Assembly);
            
            base.OnModelCreating(modelBuilder);
            
            RenameTables(modelBuilder);
        }

        private static void RenameTables(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUser>(b =>
            {
                b.ToTable("Users");
            });

            modelBuilder.Entity<IdentityUserClaim<string>>(b =>
            {
                b.ToTable("UserClaims");
            });

            modelBuilder.Entity<IdentityUserLogin<string>>(b =>
            {
                b.ToTable("UserLogins");
            });

            modelBuilder.Entity<IdentityUserToken<string>>(b =>
            {
                b.ToTable("UserTokens");
            });

            modelBuilder.Entity<IdentityRole>(b =>
            {
                b.ToTable("Roles");
            });

            modelBuilder.Entity<IdentityRoleClaim<string>>(b =>
            {
                b.ToTable("RoleClaims");
            });

            modelBuilder.Entity<IdentityUserRole<string>>(b =>
            {
                b.ToTable("UserRoles");
            });
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
